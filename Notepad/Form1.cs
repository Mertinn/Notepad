using System;
using System.Drawing;
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
            label1.Text = $"Wielkość czcionki - {trackBar1.Value}";
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

            try
            {
                if (File.Exists(editingFilePath))
                {
                    File.WriteAllText(editingFilePath, documentText);
                }
                else if (!File.Exists(editingFilePath))
                {
                    string filePath = CreateNewFile();
                    editingFilePath = filePath;

                    File.WriteAllText(editingFilePath, documentText);
                }
            }
            catch (Exception) { }
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

        private string CreateNewFile()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            string filePath = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    filePath = saveFileDialog1.FileName;
                    myStream.Close();
                }
            }
            return filePath;
        }

        private void newFileBtn_Click(object sender, EventArgs e)
        {
            string filePath = CreateNewFile();
            editingFilePath = filePath;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            settingsPanel.Enabled = !settingsPanel.Enabled;
            settingsPanel.Visible = !settingsPanel.Visible;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            documentTextBox.Font = new Font(documentTextBox.Font.FontFamily, trackBar1.Value);
            label1.Text = $"Wielkość czcionki - {trackBar1.Value}";
        }
    }
}