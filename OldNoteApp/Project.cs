namespace NoteApp;


/// <summary>
/// Class with list of notes
/// </summary>
public class Project
{
	public List<Note> Notes { get; init; }

	public Project()
	{
		Notes = new List<Note>();
	}
}