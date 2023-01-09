using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Model;
using Domain.ObjectValue;
using logScreen.Help;

namespace logScreen._modal
{
    public partial class Modal : Form
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void Guna2TileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_EmailOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (check_EmailOnly.Checked == true)
            {
                txt_contact.Enabled = false;
                cmb_plataform.SelectedIndex = 0;
                cmb_plataform.Enabled = false;
                txt_Plataform_name.Text = "Email";
            }
            else
            {
                txt_UserName.Enabled = true;
                txt_contact.Enabled = true;
                cmb_plataform.Enabled = true;
            }
        }

        private void Cmb_plataform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_plataform.SelectedItem.ToString() == "Other")
            {
                txt_Plataform_name.Enabled = true;
                txt_Plataform_name.Focus();
            }
            else
            {
                txt_Plataform_name.Text = cmb_plataform.SelectedItem.ToString();
                txt_Plataform_name.Enabled = false;
            }
        }

        private void Guna2TileButton2_Click(object sender, EventArgs e)
        {
            AccountModel accountModel = new AccountModel();
            UserModel userModel = new UserModel();
            ValidationObject validationObject;

            //Embocando os dados para validação
            accountModel.Email = (String.IsNullOrWhiteSpace(txt_Email.Text))? "No set" : txt_Email.Text;
            accountModel.Contact = (String.IsNullOrWhiteSpace(txt_contact.Text)) ? 0 : int.Parse(txt_contact.Text);
            accountModel.Password = txt_confirm_Password.Text;
            accountModel.Plataform = txt_Plataform_name.Text;
            accountModel.User = (String.IsNullOrWhiteSpace(txt_UserName.Text)) ? "No set" : txt_UserName.Text;
            accountModel.Password_creator = (String.IsNullOrEmpty(Cache.user.Password))? Cache.user.Alt_password : Cache.user.Password;
            

            //Validando os campos
            validationObject = new ValidationObject(accountModel);
            if (validationObject.Validate() == true)
            {
                if (txt_Password.Text == txt_confirm_Password.Text)
                {
                    accountModel.state = EntityState.Added;
                    userModel.FilterAccount();
                    MessageBox.Show(accountModel.saveChanges());
                }
                else
                    MessageBox.Show("Check the confirmation of the password");

            }

        }

        private void Modal_Load(object sender, EventArgs e)
        {

        }

        private void Txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
