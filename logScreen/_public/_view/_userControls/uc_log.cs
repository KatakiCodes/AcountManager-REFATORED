using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Domain.Model;
using logScreen.Help;
using Domain.ObjectValue;
using logScreen._public._classes;


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
            //Login user
            UserModel userModel = new UserModel();

            string passwordUserd = txtPassword.Text;
            var ListUSer = userModel.GetAll();


            if (ListUSer.Find(x => x.Password == passwordUserd) != null)
            {
                Cache.user.Password = txtPassword.Text;
                userModel.FilterAccount();
                Holding.Holding_logScreen = true;
                
            }
            else if (ListUSer.Find(x => x.Alt_password == passwordUserd) != null)
            {
                Cache.user.Alt_password = txtPassword.Text;
                Holding.Holding_logScreen = true;
                userModel.FilterAccount();
            }
            else
            {
                txtPassword.BorderColor = Color.Crimson;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
    }
}
