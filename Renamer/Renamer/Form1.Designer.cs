namespace Renamer
{
    partial class Form1
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
            this.MovieRadioButton = new System.Windows.Forms.RadioButton();
            this.TVShowRadioButton = new System.Windows.Forms.RadioButton();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileLocationLabel = new System.Windows.Forms.Label();
            this.FileLocationTextBox = new System.Windows.Forms.TextBox();
            this.RenaemButton = new System.Windows.Forms.Button();
            this.FilesRenamedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieRadioButton
            // 
            this.MovieRadioButton.AutoSize = true;
            this.MovieRadioButton.Location = new System.Drawing.Point(110, 29);
            this.MovieRadioButton.Name = "MovieRadioButton";
            this.MovieRadioButton.Size = new System.Drawing.Size(54, 17);
            this.MovieRadioButton.TabIndex = 0;
            this.MovieRadioButton.TabStop = true;
            this.MovieRadioButton.Text = "Movie";
            this.MovieRadioButton.UseVisualStyleBackColor = true;
            this.MovieRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TVShowRadioButton
            // 
            this.TVShowRadioButton.AutoSize = true;
            this.TVShowRadioButton.Location = new System.Drawing.Point(187, 29);
            this.TVShowRadioButton.Name = "TVShowRadioButton";
            this.TVShowRadioButton.Size = new System.Drawing.Size(69, 17);
            this.TVShowRadioButton.TabIndex = 1;
            this.TVShowRadioButton.TabStop = true;
            this.TVShowRadioButton.Text = "TV Show";
            this.TVShowRadioButton.UseVisualStyleBackColor = true;
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Location = new System.Drawing.Point(22, 31);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.FileTypeLabel.TabIndex = 2;
            this.FileTypeLabel.Text = "Type of File:";
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.AutoSize = true;
            this.FileLocationLabel.Location = new System.Drawing.Point(25, 76);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(70, 13);
            this.FileLocationLabel.TabIndex = 3;
            this.FileLocationLabel.Text = "File Location:";
            // 
            // FileLocationTextBox
            // 
            this.FileLocationTextBox.Location = new System.Drawing.Point(110, 76);
            this.FileLocationTextBox.Name = "FileLocationTextBox";
            this.FileLocationTextBox.Size = new System.Drawing.Size(146, 20);
            this.FileLocationTextBox.TabIndex = 4;
            // 
            // RenaemButton
            // 
            this.RenaemButton.Location = new System.Drawing.Point(28, 121);
            this.RenaemButton.Name = "RenaemButton";
            this.RenaemButton.Size = new System.Drawing.Size(75, 23);
            this.RenaemButton.TabIndex = 5;
            this.RenaemButton.Text = "Rename";
            this.RenaemButton.UseVisualStyleBackColor = true;
            // 
            // FilesRenamedLabel
            // 
            this.FilesRenamedLabel.AutoSize = true;
            this.FilesRenamedLabel.Location = new System.Drawing.Point(22, 176);
            this.FilesRenamedLabel.Name = "FilesRenamedLabel";
            this.FilesRenamedLabel.Size = new System.Drawing.Size(81, 13);
            this.FilesRenamedLabel.TabIndex = 6;
            this.FilesRenamedLabel.Text = "Files renamed...";
            this.FilesRenamedLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 270);
            this.Controls.Add(this.FilesRenamedLabel);
            this.Controls.Add(this.RenaemButton);
            this.Controls.Add(this.FileLocationTextBox);
            this.Controls.Add(this.FileLocationLabel);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.TVShowRadioButton);
            this.Controls.Add(this.MovieRadioButton);
            this.Name = "Form1";
            this.Text = "Media Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MovieRadioButton;
        private System.Windows.Forms.RadioButton TVShowRadioButton;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.Label FileLocationLabel;
        private System.Windows.Forms.TextBox FileLocationTextBox;
        private System.Windows.Forms.Button RenaemButton;
        private System.Windows.Forms.Label FilesRenamedLabel;
    }
}

