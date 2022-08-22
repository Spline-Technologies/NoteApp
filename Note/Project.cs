using System.Collections.Generic;

namespace NoteAppCore
{
	/// <summary>
	/// Class with list of notes
	/// </summary>
	public class Project
	{
		public List<Note> Notes { get; set; }

		public Project()
		{
			Notes = new List<Note>();
		}
	}
}