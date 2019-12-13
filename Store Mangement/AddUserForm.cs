using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Store_Mangement
{
    public partial class AddUserForm : Form
    {
        enum UserType
        {
            Admin=1,
            User=2,
        }
        public AddUserForm()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(UserType)))
            {
                cbUserType.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            string connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into UserTable values (@ID, @Name, @UserName, @)Phone, @Pass, @UserType");
            cmd.Parameters.AddWithValue("@ID", i++);
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@UserName", tbUsername.Text);
            cmd.Parameters.AddWithValue("@Phone", tbPhone.Text);
            cmd.Parameters.AddWithValue("@Pass", tbPass.Text);
            cmd.Parameters.AddWithValue("@UserType", cbUserType.SelectedItem);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User created successfully");

        }
    }
}
