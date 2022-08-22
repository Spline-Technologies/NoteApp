namespace NoteAppUI
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProgramName = new System.Windows.Forms.Label();
            this.labelProgramVersion = new System.Windows.Forms.Label();
            this.linkLabelFeedbackEmail = new System.Windows.Forms.LinkLabel();
            this.labelProgramAuthors = new System.Windows.Forms.Label();
            this.labelFeedbackEmail = new System.Windows.Forms.Label();
            this.labelGithub = new System.Windows.Forms.Label();
            this.labelCopyrights = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProgramName.Location = new System.Drawing.Point(27, 29);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(157, 45);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = "Note app";
            // 
            // labelProgramVersion
            // 
            this.labelProgramVersion.AutoSize = true;
            this.labelProgramVersion.Location = new System.Drawing.Point(34, 74);
            this.labelProgramVersion.Name = "labelProgramVersion";
            this.labelProgramVersion.Size = new System.Drawing.Size(68, 25);
            this.labelProgramVersion.TabIndex = 1;
            this.labelProgramVersion.Text = "v. 1.0.0";
            // 
            // linkLabelFeedbackEmail
            // 
            this.linkLabelFeedbackEmail.AutoSize = true;
            this.linkLabelFeedbackEmail.Location = new System.Drawing.Point(210, 208);
            this.linkLabelFeedbackEmail.Name = "linkLabelFeedbackEmail";
            this.linkLabelFeedbackEmail.Size = new System.Drawing.Size(161, 25);
            this.linkLabelFeedbackEmail.TabIndex = 2;
            this.linkLabelFeedbackEmail.TabStop = true;
            this.linkLabelFeedbackEmail.Text = "glubov@yandex.ru";
            // 
            // labelProgramAuthors
            // 
            this.labelProgramAuthors.AutoSize = true;
            this.labelProgramAuthors.Location = new System.Drawing.Point(34, 140);
            this.labelProgramAuthors.Name = "labelProgramAuthors";
            this.labelProgramAuthors.Size = new System.Drawing.Size(318, 25);
            this.labelProgramAuthors.TabIndex = 3;
            this.labelProgramAuthors.Text = "Authors: Gregory Lubov, Artem Ivanov";
            // 
            // labelFeedbackEmail
            // 
            this.labelFeedbackEmail.AutoSize = true;
            this.labelFeedbackEmail.Location = new System.Drawing.Point(34, 208);
            this.labelFeedbackEmail.Name = "labelFeedbackEmail";
            this.labelFeedbackEmail.Size = new System.Drawing.Size(170, 25);
            this.labelFeedbackEmail.TabIndex = 4;
            this.labelFeedbackEmail.Text = "E-mail for feedback:";
            // 
            // labelGithub
            // 
            this.labelGithub.AutoSize = true;
            this.labelGithub.Location = new System.Drawing.Point(34, 247);
            this.labelGithub.Name = "labelGithub";
            this.labelGithub.Size = new System.Drawing.Size(69, 25);
            this.labelGithub.TabIndex = 5;
            this.labelGithub.Text = "Github:";
            // 
            // labelCopyrights
            // 
            this.labelCopyrights.AutoSize = true;
            this.labelCopyrights.Location = new System.Drawing.Point(35, 401);
            this.labelCopyrights.Name = "labelCopyrights";
            this.labelCopyrights.Size = new System.Drawing.Size(233, 25);
            this.labelCopyrights.TabIndex = 6;
            this.labelCopyrights.Text = "2022 Spline Technologies ©";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(109, 247);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(406, 25);
            this.linkLabelGithub.TabIndex = 7;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "https://github.com/Spline-Technologies/NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.labelCopyrights);
            this.Controls.Add(this.labelGithub);
            this.Controls.Add(this.labelFeedbackEmail);
            this.Controls.Add(this.labelProgramAuthors);
            this.Controls.Add(this.linkLabelFeedbackEmail);
            this.Controls.Add(this.labelProgramVersion);
            this.Controls.Add(this.labelProgramName);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelProgramName;
        private Label labelProgramVersion;
        private LinkLabel linkLabelFeedbackEmail;
        private Label labelProgramAuthors;
        private Label labelFeedbackEmail;
        private Label labelGithub;
        private Label labelCopyrights;
        private LinkLabel linkLabelGithub;
    }
}