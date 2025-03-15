using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBoxUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_input.Focus(); 
                e.SuppressKeyPress = true; 
            }
        }

        private void guna2TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick(); 
                e.SuppressKeyPress = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;

            if (username == "moamen" && password == "1234")
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            password_input.UseSystemPasswordChar = !guna2ToggleSwitch1.Checked;
        }
    }
}

