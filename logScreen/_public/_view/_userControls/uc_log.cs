using System;
using System.Drawing;
using System.Windows.Forms;

namespace logScreen._userControls
{
    public partial class uc_log : UserControl
    {

        public uc_log()
        {
            InitializeComponent();
        }

        private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.BorderColor = Color.Crimson;
                logScreen._public._classes.Holding.Holding_logScreen = false;
            }
            else
            {
                var dashboard = new DashBoard();
                dashboard.Show();
                logScreen._public._classes.Holding.Holding_logScreen = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (togglePasswordKind.Text == "Try other password")
            {
                txtPassword.PlaceholderText = "Other password";
                txtPassword.Text = String.Empty;
                togglePasswordKind.Text = "Use password";
            }
            else
            {
                txtPassword.PlaceholderText = "Password";
                txtPassword.Text = String.Empty;
                togglePasswordKind.Text = "Try other password";
            }
        }
    }
}
