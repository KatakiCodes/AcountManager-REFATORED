using System;
using System.Windows.Forms;
using logScreen._public._classes;
using Domain.Model;
using logScreen.Help;

namespace logScreen._userControls
{
    public partial class Uc_cad : UserControl
    {
        viewFunction vf = new viewFunction();

        public Uc_cad()
        {
            InitializeComponent();
        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            ValidationObject validationObject;

            user.Password = txt_Password.Text;
            user.Alt_password = txt_Other_Password.Text;
            
            if(txt_Confirm_Password.Text != txt_Password.Text || txt_Comfirm_Other_Password.Text != txt_Other_Password.Text)
            {
                MessageBox.Show("Error to confirm passwords");
            }
            else
            {
                validationObject = new ValidationObject(user);
                if (validationObject.Validate() == true)
                {

                }
                else
                {
                    return;
                }
                

            }
        }

    private void Uc_cad_Load(object sender, EventArgs e)
    {
         
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        if (linkLabel1.Text == "Show passwords")
        {
            txt_Password.UseSystemPasswordChar = false;
            txt_Confirm_Password.UseSystemPasswordChar = false;
            txt_Other_Password.UseSystemPasswordChar = false;
            txt_Comfirm_Other_Password.UseSystemPasswordChar = false;
            linkLabel1.Text = "Hide passwords";
        }
        else if (linkLabel1.Text == "Hide passwords")
        {
            txt_Password.UseSystemPasswordChar = true;
            txt_Confirm_Password.UseSystemPasswordChar = true;
            txt_Other_Password.UseSystemPasswordChar = true;
            txt_Comfirm_Other_Password.UseSystemPasswordChar = true;

            linkLabel1.Text = "Show passwords";
        }
    }
}
}
