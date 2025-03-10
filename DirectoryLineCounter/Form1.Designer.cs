namespace DirectoryLineCounter
{
    partial class Form1
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
            label1 = new Label();
            btnReset = new Button();
            label2 = new Label();
            btnRun = new Button();
            label3 = new Label();
            lblTotalLines = new Label();
            btnExport = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tbDirectory = new TextBox();
            btnOpenDir = new Button();
            cbSuffix = new ComboBox();
            lblVersion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Directory:";
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Location = new Point(686, 35);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "File suffix:";
            // 
            // btnRun
            // 
            btnRun.Enabled = false;
            btnRun.Location = new Point(206, 34);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 6;
            btnRun.Text = "Count";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 38);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Total lines:";
            // 
            // lblTotalLines
            // 
            lblTotalLines.AutoSize = true;
            lblTotalLines.Location = new Point(356, 38);
            lblTotalLines.Name = "lblTotalLines";
            lblTotalLines.Size = new Size(13, 15);
            lblTotalLines.TabIndex = 8;
            lblTotalLines.Text = "0";
            // 
            // btnExport
            // 
            btnExport.Enabled = false;
            btnExport.Location = new Point(605, 35);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // tbDirectory
            // 
            tbDirectory.Location = new Point(78, 6);
            tbDirectory.Name = "tbDirectory";
            tbDirectory.ReadOnly = true;
            tbDirectory.Size = new Size(602, 23);
            tbDirectory.TabIndex = 0;
            // 
            // btnOpenDir
            // 
            btnOpenDir.Location = new Point(686, 6);
            btnOpenDir.Name = "btnOpenDir";
            btnOpenDir.Size = new Size(102, 23);
            btnOpenDir.TabIndex = 10;
            btnOpenDir.Text = "Select directory";
            btnOpenDir.UseVisualStyleBackColor = true;
            btnOpenDir.Click += btnOpenDir_Click;
            // 
            // cbSuffix
            // 
            cbSuffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuffix.Enabled = false;
            cbSuffix.FormattingEnabled = true;
            cbSuffix.Items.AddRange(new object[] { "cpp", "cs", "css", "html", "js", "php", "py" });
            cbSuffix.Location = new Point(77, 34);
            cbSuffix.Name = "cbSuffix";
            cbSuffix.Size = new Size(121, 23);
            cbSuffix.TabIndex = 11;
            cbSuffix.SelectedIndexChanged += cbSuffix_SelectedIndexChanged;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(13, 62);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(58, 15);
            lblVersion.TabIndex = 12;
            lblVersion.Text = "lblVersion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 86);
            Controls.Add(lblVersion);
            Controls.Add(cbSuffix);
            Controls.Add(btnOpenDir);
            Controls.Add(tbDirectory);
            Controls.Add(btnExport);
            Controls.Add(lblTotalLines);
            Controls.Add(label3);
            Controls.Add(btnRun);
            Controls.Add(label2);
            Controls.Add(btnReset);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Directory Line Counter";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnReset;
        private Label label2;
        private Button btnRun;
        private Label label3;
        private Label lblTotalLines;
        private Button btnExport;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox tbDirectory;
        private Button btnOpenDir;
        private ComboBox cbSuffix;
        private Label lblVersion;
    }
}