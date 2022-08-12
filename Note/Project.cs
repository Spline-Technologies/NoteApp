namespace NoteApp;

public class Project
{
	public List<Note> Notes { get; init; }

	public Project()
	{
		Notes = new List<Note>();
	}
}