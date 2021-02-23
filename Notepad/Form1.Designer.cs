
namespace Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newFileBtn = new System.Windows.Forms.ToolStripButton();
            this.loadBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.settingBtn = new System.Windows.Forms.ToolStripButton();
            this.documentTextBox = new System.Windows.Forms.TextBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStrip1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileBtn,
            this.loadBtn,
            this.saveBtn,
            this.settingBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newFileBtn
            // 
            this.newFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("newFileBtn.Image")));
            this.newFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileBtn.Name = "newFileBtn";
            this.newFileBtn.Size = new System.Drawing.Size(42, 22);
            this.newFileBtn.Text = "Nowy";
            this.newFileBtn.Click += new System.EventHandler(this.newFileBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(52, 22);
            this.loadBtn.Text = "Wczytaj";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(44, 22);
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingBtn.Image")));
            this.settingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(68, 22);
            this.settingBtn.Text = "Ustawienia";
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // documentTextBox
            // 
            this.documentTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.documentTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.documentTextBox.Location = new System.Drawing.Point(13, 29);
            this.documentTextBox.Multiline = true;
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.documentTextBox.Size = new System.Drawing.Size(758, 454);
            this.documentTextBox.TabIndex = 1;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.trackBar1);
            this.settingsPanel.Enabled = false;
            this.settingsPanel.Location = new System.Drawing.Point(127, 21);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(117, 63);
            this.settingsPanel.TabIndex = 2;
            this.settingsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wielkość czcionki - ";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 1);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(111, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 11;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 495);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.documentTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton loadBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.TextBox documentTextBox;
        private System.Windows.Forms.ToolStripButton newFileBtn;
        private System.Windows.Forms.ToolStripButton settingBtn;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

