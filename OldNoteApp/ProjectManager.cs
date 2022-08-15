namespace NoteApp;


using Newtonsoft.Json;


/// <summary>
/// Convert list of notes to the file and back
/// </summary>
public static class ProjectManager
{
	/// <summary>
	/// Path to the root project folder
	/// </summary>
	private const string Path = "../../../../NoteApp.notes";


	/// <summary>
	/// Serialize class with notes list into the file
	/// </summary>
	/// <param name="project">class with list of notes</param>
	public static void Serialize(Project project)
	{
		var settings = new JsonSerializerSettings
			{ DateFormatString = "dd.MM.yyyy HH:mm:ss" };

		var contents = JsonConvert.SerializeObject(
			project.Notes, Formatting.Indented, settings);

		File.WriteAllText(Path, contents);
	}

	/// <summary>
	/// Deserialize file with notes
	/// </summary>
	/// <returns>Class with list of notes</returns>
	public static Project Deserialize()
	{
		//todo Добавить проверку на отсутствие файла
		//todo Добавить проверку на правильность файла
		return new Project
		{
			Notes = JsonConvert.DeserializeObject<List<Note>>
				(File.ReadAllText(Path))
		};
	}
}