using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string filePath = OpenExplorerAndGetPath();
            if(filePath != string.Empty)
            {
                string documentText = File.ReadAllText(filePath);
                documentTextBox.Text = documentText;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

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
