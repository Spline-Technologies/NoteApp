using System.Text;

namespace Note;

internal class Note
{
	private const int MaxTitleLength = 50;

	private string _title = "Без названия";

	public string Title
	{
		get => _title;
		set
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentNullException("value");

			if (value.Length > MaxTitleLength)
				throw new ArgumentException("value");

			_title = value;
		}
	}

	private NoteCategory Category { get; set; } = NoteCategory.Work;

	private DateTime CreationTime { get; init; }

	private DateTime LastModifyTime { get; set; }

	private StringBuilder NoteText { get; set; }
}
