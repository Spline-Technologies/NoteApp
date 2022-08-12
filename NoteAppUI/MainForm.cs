namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Contains all notes while program is running.
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Contains selected by user note.
        /// </summary>
        private Note _selectedNote;

        private void SetNoteDescriptionVisibility(bool isVisible)
        {
            noteTitleLabel.Visible = isVisible;
            createdTextLabel.Visible = isVisible;
            createdDateLabel.Visible = isVisible;
            modifiedTextLAbel.Visible = isVisible;
            modifiedDateLabel.Visible = isVisible;
            noteTextBox.Visible = isVisible;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetNoteDescriptionVisibility(false);
        }

        private void addNewNoteButton_Click(object sender, EventArgs e)
        {
            var note = new Note();
            _notes.Add(note);
            noteListBox.Items.Add(note);
            _selectedNote = note;
            noteListBox_SelectedIndexChanged(sender, e);
        }

        private void noteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedNote = _notes[noteListBox.SelectedIndex];
            noteTitleLabel.Text = _selectedNote.Title;
            createdDateLabel.Text = 
                Convert.ToString(_selectedNote.CreationTime);
            modifiedDateLabel.Text = 
                Convert.ToString(_selectedNote.LastModifyTime);
            noteTextBox.Text = Convert.ToString(_selectedNote.NoteText);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm();
        }
    }
}