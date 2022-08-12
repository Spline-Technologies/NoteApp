namespace NoteApp;


using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


public class Note : ICloneable
{
	private const int MaxTitleLength = 50;

	private string _title;
	private string _noteText;
	private NoteCategory _category;

	public string Title
	{
		get => _title;
		set
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentNullException(nameof(Title));

			if (value.Length > MaxTitleLength)
				throw new ArgumentException(
					"Note title is longer than 50 symbols");

			_title = value;
			LastModifyTime = DateTime.Now;
		}
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public NoteCategory Category
	{
		get => _category;
		set
		{
			_category = value;
			LastModifyTime = DateTime.Now;
		}
	}

	public DateTime CreationTime { get; }

	public DateTime LastModifyTime { get; private set; }

	public string NoteText
	{
		get => _noteText;
		set
		{
			_noteText = value ??
			            throw new ArgumentNullException(nameof(NoteText));

			LastModifyTime = DateTime.Now;
		}
	}


	public Note()
	{
		Title = "Без названия";
		Category = NoteCategory.Work;
		CreationTime = DateTime.Now;
		LastModifyTime = DateTime.Now;
		NoteText = "";
	}

	public object Clone() => new Note
	{
		Title = Title,
		Category = Category,
		LastModifyTime = DateTime.Now,
		NoteText = NoteText.Clone().ToString()
	};
}