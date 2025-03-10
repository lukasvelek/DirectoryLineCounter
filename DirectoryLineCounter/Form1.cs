using System.IO;
using System.Collections;
using System.Collections.Generic;
using static System.Windows.Forms.LinkLabel;

namespace DirectoryLineCounter
{
    public partial class Form1 : Form
    {
        List<string> filesOpened = new List<string>();

        int totalLines = 0;

        public Form1()
        {
            InitializeComponent();

            lblTotalLines.Text = totalLines.ToString();
            lblVersion.Text = "v" + ProductVersion;
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbDirectory.Text = folderBrowserDialog1.SelectedPath;
            }

            if (Directory.Exists(tbDirectory.Text))
            {
                btnOpenDir.Enabled = false;
                cbSuffix.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnOpenDir.Enabled = true;
            btnReset.Enabled = false;
            btnExport.Enabled = false;
            cbSuffix.Enabled = true;

            lblTotalLines.Text = "0";

            totalLines = 0;
            filesOpened.Clear();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            cbSuffix.Enabled = false;

            List<string> files = new List<string>();

            files = GetDirectories(tbDirectory.Text, cbSuffix.Text);

            if (files != null)
            {
                foreach (string file in files)
                {
                    filesOpened.Add(file);
                }

                foreach (string file in filesOpened)
                {
                    int lines = 0;

                    try
                    {
                        lines = File.ReadLines(file).Count();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    totalLines += lines;

                    lblTotalLines.Text = totalLines.ToString();
                }
            }

            btnReset.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Export " + DateTime.Now.ToString();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> data = new List<string>();

                data.Add("Lines total: " + totalLines);
                data.Add("Files opened: ");

                foreach (string line in filesOpened)
                {
                    int lines = File.ReadLines(line).Count();

                    data.Add(line + " - Lines: " + lines.ToString());
                }

                File.WriteAllLines(saveFileDialog1.FileName, data.ToArray());
            }
        }

        private List<string> GetDirectories(string directory, string fileSuffix)
        {
            List<string> files = new List<string>();

            try
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    foreach (string file in Directory.GetFiles(dir, "*." + fileSuffix))
                    {
                        files.Add(file);
                    }

                    files.AddRange(GetDirectories(dir, fileSuffix));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return files;
        }

        private void cbSuffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRun.Enabled = true;
        }
    }
}