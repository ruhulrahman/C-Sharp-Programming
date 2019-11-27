using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        SaveFileDialog sfd = new SaveFileDialog();
        OpenFileDialog ofd = new OpenFileDialog();
        public string contents = string.Empty;
        private String mainText; 
        public Form1()
        {
            InitializeComponent();
            this.Text = "Untitled";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {

            Close();
        }

        private void ViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText = mainTextBox.SelectedText;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += mainText;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectedText = "";
        }

        private void AddInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != contents)
            {
                DialogResult dr = MessageBox.Show("Do You want to save the changes made to " + this.Text, "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    sfd.Title = "Save";
                    if (SaveFile() == 0)
                        return;
                    else
                    {
                        mainTextBox.Text = "";
                        this.Text = "Untitled";
                    }
                    contents = "";
                }
                else if (dr == DialogResult.No)
                {
                    mainTextBox.Text = "";
                    this.Text = "Untitled";
                    contents = "";
                }
                else
                {
                    mainTextBox.Focus();
                }
            }
            else
            {
                this.Text = "Untitled";
                mainTextBox.Text = "";
                contents = "";
            }
        }


        private int SaveFile()
        {
            sfd.Filter = "Text Documents|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                mainTextBox.Focus();
                return 0;
            }
            else
            {
                contents = mainTextBox.Text;
                if (this.Text == "Untitled")
                    mainTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                else
                {
                    sfd.FileName = this.Text;
                    mainTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = sfd.FileName;
                return 1;
            }


        }
        private void OpenFile()
        {
            ofd.Filter = "Text Documents|*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                mainTextBox.Focus();
            else
            {
                mainTextBox.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                this.Text = ofd.FileName;
                contents = mainTextBox.Text;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != contents)
            {
                DialogResult dr = MessageBox.Show("Do You want to save the changes made to " + this.Text, "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    SaveFile();
                    OpenFile();
                }
                else if (dr == DialogResult.No)
                {
                    OpenFile();
                }
                else
                {
                    mainTextBox.Focus();
                }
            }
            else
                OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Text Documents|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                mainTextBox.Focus();
            }
            else
            {
                contents = mainTextBox.Text;
                mainTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);

                this.Text = sfd.FileName;
            }
        }


    }
}
