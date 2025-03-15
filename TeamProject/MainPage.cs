using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TeamProject
{ 
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        bool menuExpand = false;


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage(); 
            loginPage.Show(); 
            this.Close(); 
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            logoutbutton.ForeColor = Color.Red; // Change color when mouse enters
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            logoutbutton.ForeColor = Color.White; // Change back when mouse leaves
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 20;
                if (menuContainer.Height >= 145)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }else
            {
                menuContainer.Height -= 20;
                if (menuContainer.Height <= 45)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
