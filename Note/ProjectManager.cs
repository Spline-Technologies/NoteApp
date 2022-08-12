using Newtonsoft.Json;

namespace NoteApp;

public static class ProjectManager
{
	private const string Path = "NoteApp.notes";

	public static void Serialize(Project project)
	{
		var settings = new JsonSerializerSettings
			{ DateFormatString = "dd.MM.yyyy HH:mm:ss" };

		string contents = JsonConvert.SerializeObject(
			project.Notes, Formatting.Indented, settings);
		
		File.WriteAllText(Path, contents);
	}

	/// <summary>
	/// должна сама находить .json и конвертировать
	/// </summary>
	/// <returns>класс со списком всех Note</returns>
	public static Project Deserialize()
	{
		return new Project();
	}
}