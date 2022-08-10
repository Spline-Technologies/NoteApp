namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addNewNoteButton = new System.Windows.Forms.Button();
            this.categoryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryTypeLabel = new System.Windows.Forms.Label();
            this.noteListBox = new System.Windows.Forms.ListBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.createdTextLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.modifiedTextLAbel = new System.Windows.Forms.Label();
            this.modifiedDateLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.addNoteToolStripMenuItem.Text = "Add note";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addNewNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.categoryTypeComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.categoryTypeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.noteListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.modifiedDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.modifiedTextLAbel);
            this.splitContainer1.Panel2.Controls.Add(this.createdDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.createdTextLabel);
            this.splitContainer1.Panel2.Controls.Add(this.noteNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.noteTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 512);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 1;
            // 
            // addNewNoteButton
            // 
            this.addNewNoteButton.Location = new System.Drawing.Point(12, 466);
            this.addNewNoteButton.Name = "addNewNoteButton";
            this.addNewNoteButton.Size = new System.Drawing.Size(181, 34);
            this.addNewNoteButton.TabIndex = 3;
            this.addNewNoteButton.Text = "Add new note";
            this.addNewNoteButton.UseVisualStyleBackColor = true;
            // 
            // categoryTypeComboBox
            // 
            this.categoryTypeComboBox.FormattingEnabled = true;
            this.categoryTypeComboBox.Location = new System.Drawing.Point(146, 13);
            this.categoryTypeComboBox.Name = "categoryTypeComboBox";
            this.categoryTypeComboBox.Size = new System.Drawing.Size(224, 33);
            this.categoryTypeComboBox.TabIndex = 2;
            // 
            // categoryTypeLabel
            // 
            this.categoryTypeLabel.AutoSize = true;
            this.categoryTypeLabel.Location = new System.Drawing.Point(12, 13);
            this.categoryTypeLabel.Name = "categoryTypeLabel";
            this.categoryTypeLabel.Size = new System.Drawing.Size(128, 25);
            this.categoryTypeLabel.TabIndex = 1;
            this.categoryTypeLabel.Text = "Category type:";
            // 
            // noteListBox
            // 
            this.noteListBox.FormattingEnabled = true;
            this.noteListBox.ItemHeight = 25;
            this.noteListBox.Location = new System.Drawing.Point(3, 53);
            this.noteListBox.Name = "noteListBox";
            this.noteListBox.Size = new System.Drawing.Size(367, 404);
            this.noteListBox.TabIndex = 0;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(20, 96);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(715, 404);
            this.noteTextBox.TabIndex = 0;
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteNameLabel.Location = new System.Drawing.Point(20, 16);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(122, 30);
            this.noteNameLabel.TabIndex = 1;
            this.noteNameLabel.Text = "NoteName";
            // 
            // createdTextLabel
            // 
            this.createdTextLabel.AutoSize = true;
            this.createdTextLabel.Location = new System.Drawing.Point(20, 53);
            this.createdTextLabel.Name = "createdTextLabel";
            this.createdTextLabel.Size = new System.Drawing.Size(77, 25);
            this.createdTextLabel.TabIndex = 2;
            this.createdTextLabel.Text = "Created:";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(103, 53);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(80, 25);
            this.createdDateLabel.TabIndex = 3;
            this.createdDateLabel.Text = "01.01.22";
            // 
            // modifiedTextLAbel
            // 
            this.modifiedTextLAbel.AutoSize = true;
            this.modifiedTextLAbel.Location = new System.Drawing.Point(231, 53);
            this.modifiedTextLAbel.Name = "modifiedTextLAbel";
            this.modifiedTextLAbel.Size = new System.Drawing.Size(88, 25);
            this.modifiedTextLAbel.TabIndex = 4;
            this.modifiedTextLAbel.Text = "Modified:";
            // 
            // modifiedDateLabel
            // 
            this.modifiedDateLabel.AutoSize = true;
            this.modifiedDateLabel.Location = new System.Drawing.Point(325, 53);
            this.modifiedDateLabel.Name = "modifiedDateLabel";
            this.modifiedDateLabel.Size = new System.Drawing.Size(80, 25);
            this.modifiedDateLabel.TabIndex = 5;
            this.modifiedDateLabel.Text = "02.01.22";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 545);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer splitContainer1;
        private ComboBox categoryTypeComboBox;
        private Label categoryTypeLabel;
        private ListBox noteListBox;
        private TextBox noteTextBox;
        private Button addNewNoteButton;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addNoteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Label modifiedDateLabel;
        private Label modifiedTextLAbel;
        private Label createdDateLabel;
        private Label createdTextLabel;
        private Label noteNameLabel;
    }
}