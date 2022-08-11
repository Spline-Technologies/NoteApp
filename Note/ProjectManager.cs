using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NoteApp;

/// <summary>
/// Пока просто заглушка
/// </summary>
public static class ProjectManager
{
	public static void Serialize(Project project)
	{
		/*Parallel.ForEach(project.Notes, note =>
		{
			string output = JsonConvert.SerializeObject(note);
		});*/
		int i = 0;
		foreach (var note in project.Notes)
		{
			note.Title += " " + i.ToString();
			JsonSerializer serializer = new JsonSerializer();
			serializer.Converters.Add(new JavaScriptDateTimeConverter());
			serializer.NullValueHandling = NullValueHandling.Ignore;
			serializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
			//serializer.DateFormatString = ;
			//serializer.DateParseHandling;
			//serializer.DateTimeZoneHandling;
			i++;
			string path = "Note_" + i.ToString() + ".json";
			using (StreamWriter sw =
			       new StreamWriter(path))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, note);
			}
		}
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