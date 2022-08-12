namespace NoteApp;

public class Project
{
	public List<Note> Notes { get; }

	public Project()
	{
		Notes = new List<Note>();
	}
}