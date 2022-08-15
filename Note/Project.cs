using System.Collections.Generic;

namespace NoteCore
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