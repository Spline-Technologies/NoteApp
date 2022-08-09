using System.Text;

namespace Note;

internal class Note
{
	private const int MaxTitleLength = 50;

	private string _title;

	public string Title
	{
		get => _title;
		set
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentNullException("Note title can't be empty");

			if (value.Length > MaxTitleLength)
				throw new ArgumentException("Note title can't be longer than 50 symbols");

			_title = value;
		}
	}

	private NoteCategory Category { get; set; }

	private DateTime CreationTime { get; init; }

	private DateTime LastModifyTime { get; set; }

	private StringBuilder NoteText { get; set; }

	public Note()
	{
		Title = "Без названия";
		Category = NoteCategory.Work;
		CreationTime = DateTime.Now;
		LastModifyTime = DateTime.Now;
		NoteText = new StringBuilder();
	}
}
