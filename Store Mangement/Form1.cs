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

        private void button5_Click(object sender, EventArgs e)
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

        private void button13_Click(object sender, EventArgs e)
        {
            //code here 
            //hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code here 
            //hideSubMenu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDiscountSubMenu);
        }
    }
}
