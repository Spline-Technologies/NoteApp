using NoteApp;

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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addNewNoteButton = new System.Windows.Forms.Button();
            this.categoryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryTypeLabel = new System.Windows.Forms.Label();
            this.noteListBox = new System.Windows.Forms.ListBox();
            this.modifiedDateLabel = new System.Windows.Forms.Label();
            this.modifiedTextLAbel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.createdTextLabel = new System.Windows.Forms.Label();
            this.noteTitleLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1124, 33);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
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
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 33);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.addNewNoteButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.categoryTypeComboBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.categoryTypeLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.noteListBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.modifiedDateLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.modifiedTextLAbel);
            this.mainSplitContainer.Panel2.Controls.Add(this.createdDateLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.createdTextLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.noteTitleLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.noteTextBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(1124, 512);
            this.mainSplitContainer.SplitterDistance = 370;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // addNewNoteButton
            // 
            this.addNewNoteButton.Location = new System.Drawing.Point(12, 466);
            this.addNewNoteButton.Name = "addNewNoteButton";
            this.addNewNoteButton.Size = new System.Drawing.Size(181, 34);
            this.addNewNoteButton.TabIndex = 3;
            this.addNewNoteButton.Text = "Add new note";
            this.addNewNoteButton.UseVisualStyleBackColor = true;
            this.addNewNoteButton.Click += new System.EventHandler(this.addNewNoteButton_Click);
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
            this.noteListBox.SelectedIndexChanged += new System.EventHandler(this.noteListBox_SelectedIndexChanged);
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
            // modifiedTextLAbel
            // 
            this.modifiedTextLAbel.AutoSize = true;
            this.modifiedTextLAbel.Location = new System.Drawing.Point(231, 53);
            this.modifiedTextLAbel.Name = "modifiedTextLAbel";
            this.modifiedTextLAbel.Size = new System.Drawing.Size(88, 25);
            this.modifiedTextLAbel.TabIndex = 4;
            this.modifiedTextLAbel.Text = "Modified:";
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
            // createdTextLabel
            // 
            this.createdTextLabel.AutoSize = true;
            this.createdTextLabel.Location = new System.Drawing.Point(20, 53);
            this.createdTextLabel.Name = "createdTextLabel";
            this.createdTextLabel.Size = new System.Drawing.Size(77, 25);
            this.createdTextLabel.TabIndex = 2;
            this.createdTextLabel.Text = "Created:";
            // 
            // noteTitleLabel
            // 
            this.noteTitleLabel.AutoSize = true;
            this.noteTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteTitleLabel.Location = new System.Drawing.Point(20, 16);
            this.noteTitleLabel.Name = "noteTitleLabel";
            this.noteTitleLabel.Size = new System.Drawing.Size(107, 30);
            this.noteTitleLabel.TabIndex = 1;
            this.noteTitleLabel.Text = "NoteTitle";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(20, 96);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(715, 404);
            this.noteTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 545);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer mainSplitContainer;
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
        private Label noteTitleLabel;
    }
}