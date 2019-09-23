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
        private String mainText;
        public Form1()
        {
            InitializeComponent();
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
    }
}
