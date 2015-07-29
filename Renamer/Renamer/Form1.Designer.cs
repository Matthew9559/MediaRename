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
            this.openFilesButton = new System.Windows.Forms.Button();
            this.selectFilesLabel = new System.Windows.Forms.Label();
            this.renameFilesButton = new System.Windows.Forms.Button();
            this.renameSchemeTextBox = new System.Windows.Forms.TextBox();
            this.renamingSchemeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFilesButton
            // 
            this.openFilesButton.Location = new System.Drawing.Point(178, 32);
            this.openFilesButton.Name = "openFilesButton";
            this.openFilesButton.Size = new System.Drawing.Size(116, 28);
            this.openFilesButton.TabIndex = 0;
            this.openFilesButton.Text = "Open";
            this.openFilesButton.UseVisualStyleBackColor = true;
            this.openFilesButton.Click += new System.EventHandler(this.OpenFilesButton_Click);
            // 
            // selectFilesLabel
            // 
            this.selectFilesLabel.AutoSize = true;
            this.selectFilesLabel.Location = new System.Drawing.Point(25, 32);
            this.selectFilesLabel.Name = "selectFilesLabel";
            this.selectFilesLabel.Size = new System.Drawing.Size(64, 13);
            this.selectFilesLabel.TabIndex = 1;
            this.selectFilesLabel.Text = "Select Files:";
            // 
            // renameFilesButton
            // 
            this.renameFilesButton.Location = new System.Drawing.Point(104, 164);
            this.renameFilesButton.Name = "renameFilesButton";
            this.renameFilesButton.Size = new System.Drawing.Size(136, 56);
            this.renameFilesButton.TabIndex = 2;
            this.renameFilesButton.Text = "Rename";
            this.renameFilesButton.UseVisualStyleBackColor = true;
            this.renameFilesButton.Click += new System.EventHandler(this.renameFilesButton_Click);
            // 
            // renameSchemeTextBox
            // 
            this.renameSchemeTextBox.Location = new System.Drawing.Point(141, 82);
            this.renameSchemeTextBox.Name = "renameSchemeTextBox";
            this.renameSchemeTextBox.Size = new System.Drawing.Size(203, 20);
            this.renameSchemeTextBox.TabIndex = 3;
            // 
            // renamingSchemeLabel
            // 
            this.renamingSchemeLabel.AutoSize = true;
            this.renamingSchemeLabel.Location = new System.Drawing.Point(25, 85);
            this.renamingSchemeLabel.Name = "renamingSchemeLabel";
            this.renamingSchemeLabel.Size = new System.Drawing.Size(97, 13);
            this.renamingSchemeLabel.TabIndex = 4;
            this.renamingSchemeLabel.Text = "Renaming Scheme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 244);
            this.Controls.Add(this.renamingSchemeLabel);
            this.Controls.Add(this.renameSchemeTextBox);
            this.Controls.Add(this.renameFilesButton);
            this.Controls.Add(this.selectFilesLabel);
            this.Controls.Add(this.openFilesButton);
            this.Name = "Form1";
            this.Text = "Media Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFilesButton;
        private System.Windows.Forms.Label selectFilesLabel;
        private System.Windows.Forms.Button renameFilesButton;
        private System.Windows.Forms.TextBox renameSchemeTextBox;
        private System.Windows.Forms.Label renamingSchemeLabel;
    }
}

