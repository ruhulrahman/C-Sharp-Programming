using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Mangement
{
    public partial class LoginForm : Form
    {
        private string username, password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text.Trim();   
            password = tbPass.Text.Trim();
            if(username == "")
            {
                MessageBox.Show("Please enter username or phone number");
            }

            if(password == "")
            {
                MessageBox.Show("Please enter password");
            }

        }
    }
}
