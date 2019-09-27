using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Data_Add_in_Array_List
{
    public partial class Form1 : Form
    {
        ArrayList itemName = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            itemName.Add(addItemBox.Text);
            ShowData();
            addItemBox.Clear();
        }

        private void ShowData()
        {
            listItemBox.Items.Clear();
            foreach (string item in itemName)
            {
                listItemBox.Items.Add(item);
            }
        }

        private void listItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            listItemBox.Items.Clear();

            foreach (string item in itemName)
            {
                listItemBox.Items.Remove(item);
            }
        }
    }
}
