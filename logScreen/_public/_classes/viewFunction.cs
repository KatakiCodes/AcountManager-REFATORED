using System;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using logScreen._userControls;
using System.Drawing;


namespace logScreen._public._classes
{
    public class viewFunction
    {
       public void toggleUserControls(Panel panel, UserControl control)
        {
            if(panel.Controls.Count >= 0)
            {
                panel.Controls.Clear();
                panel.Controls.Add(control);
                control.Width = panel.Width;
                control.Height = panel.Height;
            }
            else
            {
                return;
            }
        }

        public void toggle_log_cad_control(Panel panel, LinkLabel label)
        {
            if (label.Text == "Create user")
            {
                this.toggleUserControls(panel, new Uc_cad());
                label.Text = "Login";
            }
            else if(label.Text == "Login")
            {
                this.toggleUserControls(panel, new uc_log());
                label.Text = "Create user";
            }
        }
        public void Toggle_loginImage(PictureBox loginUser, PictureBox newUser , string cond)
        {
            if(cond == "Create user")
            {
                loginUser.Visible = false;
                newUser.Visible = true;
            }
            else if (cond == "Login")
            {
                loginUser.Visible = true;
                newUser.Visible = false;

            }
        }

        //
        public bool RestrictEmptysPassword(Guna2TextBox txt_Password, Guna2TextBox txt_Confirm_Password, Guna2TextBox txt_Other_Password, Guna2TextBox txt_Comfirm_Other_Password)
        {
            if (String.IsNullOrWhiteSpace(txt_Password.Text))
            {
                txt_Password.BorderColor = Color.Crimson;
                txt_Confirm_Password.BorderColor = Color.LightGray;
                txt_Other_Password.BorderColor = Color.LightGray;
                txt_Comfirm_Other_Password.BorderColor = Color.LightGray;

                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_Confirm_Password.Text))
            {
                txt_Password.BorderColor = Color.LightGray;
                txt_Confirm_Password.BorderColor = Color.Crimson;
                txt_Other_Password.BorderColor = Color.LightGray;
                txt_Comfirm_Other_Password.BorderColor = Color.LightGray;

                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_Other_Password.Text))
            {
                txt_Password.BorderColor = Color.LightGray;
                txt_Confirm_Password.BorderColor = Color.LightGray;
                txt_Other_Password.BorderColor = Color.Crimson;
                txt_Comfirm_Other_Password.BorderColor = Color.LightGray;

                return false;
            }

            else if (String.IsNullOrWhiteSpace(txt_Comfirm_Other_Password.Text))
            {
                txt_Password.BorderColor = Color.LightGray;
                txt_Confirm_Password.BorderColor = Color.LightGray;
                txt_Other_Password.BorderColor = Color.LightGray;
                txt_Comfirm_Other_Password.BorderColor = Color.Crimson;

                return false;
            }
            else
            {
                return true;
            }
        }
        public bool getPasswordStrenght(string password, string otherPassword)
        {
            //TODO check the password strenght
            //passsword
           if(password.Length < 6 || otherPassword.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
