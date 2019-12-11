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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            customizeDesign();

            
        }

        private void customizeDesign()
        {
            panelProductSubMenu.Visible = false;
            panelCategorySubMenu.Visible = false;
            panelBuySubMenu.Visible = false;
            panelSellSubMenu.Visible = false;
            panelDiscountSubMenu.Visible = false;
            panelUserManagementSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelProductSubMenu.Visible == true)
            {
                panelProductSubMenu.Visible = false;
            }
            if(panelCategorySubMenu.Visible == true)
            {
                panelCategorySubMenu.Visible = false;
            }
            if(panelBuySubMenu.Visible == true)
            {
                panelBuySubMenu.Visible = false;
            }
            if(panelSellSubMenu.Visible == true)
            {
                panelSellSubMenu.Visible = false;
            }
            if(panelDiscountSubMenu.Visible == true)
            {
                panelDiscountSubMenu.Visible = false;
            }
            if(panelUserManagementSubMenu.Visible == true)
            {
                panelUserManagementSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void panelSlideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

   

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductSubMenu);
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCategorySubMenu);
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBuySubMenu);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSellSubMenu);
        }

        private void buttonUserManage_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserManagementSubMenu);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new AddProductForm());
            //hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductListForm());
            //hideSubMenu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDiscountSubMenu);
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            openChildForm(new AddUserForm());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panelSellSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panelBuySubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panelCategorySubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelProductSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMainBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panelAddProductHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerProdExipire_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quantityBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProductPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProductModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProductCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelUserManagementSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
