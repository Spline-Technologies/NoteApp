using System.Text;

namespace Note;

public class Note
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
				throw new ArgumentException("Note title can't be longer than 50 symbols");

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
}
