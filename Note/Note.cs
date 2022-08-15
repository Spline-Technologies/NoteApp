using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Note
{
	/// <summary>
    /// Main class, that contains note data
    /// </summary>
    public class Note : ICloneable
    {
    	private const int MaxTitleLength = 50;
    
    	private string _title;
    	private string _noteText;
    	private NoteCategory _category;
    
    	/// <summary>
    	/// Head text of note
    	/// </summary>
    	/// <exception cref="ArgumentNullException">new value is null</exception>
    	/// <exception cref="ArgumentException">The title is too long (51 and more)</exception>
    	public string Title
    	{
    		get => _title;
    		set
    		{
    			if (string.IsNullOrWhiteSpace(value))
    				throw new ArgumentNullException(nameof(Title));
    
    			if (value.Length > MaxTitleLength)
    				throw new ArgumentException(
    					"Note title is longer than 50 symbols");
    
    			_title = value;
    			LastModifyTime = DateTime.Now;
    		}
    	}
    
    	/// <summary>
    	/// Category of note
    	/// </summary>
    	[JsonConverter(typeof(StringEnumConverter))]
    	public NoteCategory Category
    	{
    		get => _category;
    		set
    		{
    			_category = value;
    			LastModifyTime = DateTime.Now;
    		}
    	}
    
    	/// <summary>
    	/// Date and time of note creation;
    	/// format dd.MM.yyyy HH:mm:ss
    	/// </summary>
    	public DateTime CreationTime { get; }
    
    	/// <summary>
    	/// Date and time of last note modification;
    	/// format dd.MM.yyyy HH:mm:ss
    	/// </summary>
    	public DateTime LastModifyTime { get; private set; }
    
    	/// <summary>
    	/// Body text of note
    	/// </summary>
    	/// <exception cref="ArgumentNullException">new value is null</exception>
    	public string NoteText
    	{
    		get => _noteText;
    		set
    		{
    			_noteText = value ??
    			            throw new ArgumentNullException(nameof(NoteText));
    
    			LastModifyTime = DateTime.Now;
    		}
    	}
    
    
    	public Note()
    	{
    		Title = "Без названия";
    		Category = NoteCategory.Work;
    		CreationTime = DateTime.Now;
    		LastModifyTime = DateTime.Now;
    		NoteText = "";
    	}
    
    	public object Clone() => new Note
    	{
    		Title = Title,
    		Category = Category,
    		LastModifyTime = DateTime.Now,
    		NoteText = NoteText
    	};
    }
}