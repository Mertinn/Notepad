using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private string editingFilePath;

        public Form1()
        {
            InitializeComponent();
            Text = "Notepad";
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            editingFilePath = OpenExplorerAndGetPath();
            if(editingFilePath != string.Empty)
            {
                string documentText = File.ReadAllText(editingFilePath);
                documentTextBox.Text = documentText;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string documentText = documentTextBox.Text;

            if (File.Exists(editingFilePath))
            {
                File.WriteAllText(editingFilePath, documentText);
            }
            else if(!File.Exists(editingFilePath))
            {
                using (FileStream fs = File.Create(editingFilePath))
                {
                    fs.Close();
                }
                
                File.WriteAllText(editingFilePath, documentText);
            }
        }

        private string OpenExplorerAndGetPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Desktop";
                openFileDialog.Filter = "txt (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                string filePath = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   filePath = openFileDialog.FileName;
                }
                return filePath;
            }
        }
    }
}
