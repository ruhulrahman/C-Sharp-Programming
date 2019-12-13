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
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public AddUserForm()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=LAB_612_17;Initial Catalog=Storemanagement;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            foreach (var item in Enum.GetValues(typeof(UserType)))
            {
                //cbUserType.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            com.Connection = con;
            //com.CommandText = "Select * from user_info";
            //SqlDataReader dr = com.ExecuteReader();

            if(tbName.Text == "" || tbUsername.Text == "" || tbemail.Text == "" || tbPhone.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Please fill the filds");
            }
            else
            {
                com.CommandText = "@INSERT INTO users (userId, name, userName, email, phone, password) VALUES ('"+ tbName.Text + "','" + tbUsername.Text + "','" + tbemail.Text + "','" + tbPhone.Text + "','" + tbPass.Text + "')";
                con.Close();
                MessageBox.Show("User created successfully");
            }
        }
    }
}
