using Newtonsoft.Json;

namespace NoteApp;

public static class ProjectManager
{
	private const string Path = "../../../../NoteApp.notes";

	public static void Serialize(Project project)
	{
		var settings = new JsonSerializerSettings
			{ DateFormatString = "dd.MM.yyyy HH:mm:ss" };

		string contents = JsonConvert.SerializeObject(
			project.Notes, Formatting.Indented, settings);

		File.WriteAllText(Path, contents);
	}

	public static Project Deserialize()
	{
		return new Project
		{
			Notes = JsonConvert.DeserializeObject<List<Note>>
				(File.ReadAllText(Path))
		};
	}
}