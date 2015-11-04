using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace Renamer
{
    public partial class Form1 : Form
    {
        public List<string> TargetFiles = new List<string>();
        public string TargetDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFilesButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog getFiles = new OpenFileDialog();
            getFiles.Multiselect = true;

            if (getFiles.ShowDialog() == DialogResult.OK)
            {
                TargetDirectory = getFiles.FileName;
                foreach (string file in getFiles.SafeFileNames)
                {
                    TargetFiles.Add(file);
                }
            }
        }

        private void renameFilesButton_Click(object sender, System.EventArgs e)
        {
             List<string> filesBeforeTrim = new List<string>();
            filesBeforeTrim = TargetFiles;

            string directoryPath = Path.GetDirectoryName(TargetDirectory);
            string fileExtension = Path.GetExtension(filesBeforeTrim[0]); //assumes all files have same extension
            string renamingSchemeTrimmed = string.Empty;
            List<string> newFilesName = new List<string>();
            int episodes = 1;

            if (renameSchemeTextBox.Text.Length < 2)
            {
                MessageBox.Show("Please enter a valid scheme, i.e. Walking Dead s01e01");
                Application.Restart();
            }
            else
            {
                renamingSchemeTrimmed = renameSchemeTextBox.Text.Remove(renameSchemeTextBox.Text.Length - 2);
            }

            foreach (string file in filesBeforeTrim)
            {
                string episodesPadded = episodes.ToString().PadLeft(2, '0');
                newFilesName.Add(directoryPath + "\\" + renamingSchemeTrimmed + episodesPadded + fileExtension);
                episodes++;               
            }

            //add directory to original files
            //foreach (string ogFile in filesBeforeTrim)
            //{
            //    ogFilesWithDirectory.Add(directoryPath + '\\' + ogFile);
            //}
            //LINQ Version:
            List<string> ogFilesWithDirectory = filesBeforeTrim.Select(ogFile => directoryPath + '\\' + ogFile).ToList();

            using (var e1 = ogFilesWithDirectory.GetEnumerator())
            using (var e2 = newFilesName.GetEnumerator())
            try
            {
              while(e1.MoveNext() && e2.MoveNext())
              {
                if (e1.Current == e2.Current)
                {
                    MessageBox.Show("Files are already named as the designated scheme");
                    Application.Restart();
                }
                    File.Move(e1.Current,e2.Current);
              }
                    MessageBox.Show("All files have been renamed succesfully!");

                }
                catch (Exception ex)
            {
                MessageBox.Show("There was an issue with renaming the file(s)");

                File.AppendAllText(directoryPath, "There was an error because of: " + ex);
            }
        }
    }
}
