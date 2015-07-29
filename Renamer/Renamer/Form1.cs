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
            string renamingSchemeTrimmed = renameSchemeTextBox.Text.Remove(renameSchemeTextBox.Text.Length - 2);
            List<string> newFilesName = new List<string>();
            int episodes = 1;

            //rename each file to be moved
            foreach(string file in filesBeforeTrim)
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
                    MessageBox.Show("Files are already named as designated scheme");
                    Application.Restart();                    
                }

                System.IO.File.Move(e1.Current,e2.Current);
                MessageBox.Show("Files renamed succesfully");
              }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("There was an issue with renmaing the file due to the following exception: " + ex.ToString());
            }
        }
    }
}
