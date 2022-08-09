using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note;

internal class Note
{
	private const int _maxTitleLength = 50;
	private string _title = "Без названия";

	public string Title
	{
		get { return _title; }
		set
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentNullException("value");

			if (value.Length > _maxTitleLength)
				throw new ArgumentException("");

			_title = value;
		}
	}

	private NoteCategory _category;

	//todo добавить проверку на действительность времени
	private DateTime _creationTime;

	public DateTime CreationTime
	{
		get { return _creationTime; }
		set { _creationTime = value; }
	}

	private DateTime _lastModifyTime;

	public DateTime LastModifyTime
	{
		get { return _lastModifyTime; }
		set { _lastModifyTime = value; }
	}

	private StringBuilder _noteText;

	public StringBuilder NoteText
	{
		get { return _noteText; }
		set { _noteText = value; }
	}

}
