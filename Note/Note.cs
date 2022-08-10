using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace NoteApp;


using System.Text;
using System.Text.Json;


public class Note : ISerializer, IDeserializer
{
	private const int MaxTitleLength = 50;

	private string _title;

	public string Title
	{
		get => _title;
		set
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentNullException(nameof(Title));

			if (value.Length > MaxTitleLength)
				throw new ArgumentException("Note title is longer than 50 symbols");

			_title = value;
		}
	}

	public NoteCategory Category { get; set; }

	public DateTime CreationTime { get; }

	public DateTime LastModifyTime { get; private set; }

	public StringBuilder NoteText { get; set; }

	
	public Note()
	{
		Title = "Без названия";
		Category = NoteCategory.Work;
		CreationTime = DateTime.Now;
		LastModifyTime = DateTime.Now;
		NoteText = new StringBuilder();
	}
	
	public void Serialize()
	{
		var options = new JsonSerializerOptions
		{
			WriteIndented = true,
			Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
		};
		
		using (FileStream file = new FileStream("Note.json", FileMode.OpenOrCreate))
		{
			//JsonSerializer.SerializeToDocument(this, options);
			JsonSerializer.Serialize<Note>(file, this, options);
		}
	}
}