using System;
using System.Windows.Forms;
using logScreen._public._classes;

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

            //Restringir campos de cadastro de user
            if (vf.RestrictEmptysPassword
                (txt_Password, txt_Confirm_Password
                , txt_Other_Password
                , txt_Comfirm_Other_Password) == false)
            {
                return;
            }
            else
            {
                //Verificar a compatibilidade das senhas
                if (txt_Password.Text != txt_Confirm_Password.Text || txt_Other_Password.Text != txt_Comfirm_Other_Password.Text)
                {
                    MessageBox.Show("The password confirmatio must be the same!", "Create user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (vf.getPasswordStrenght(txt_Confirm_Password.Text, txt_Other_Password.Text) == true)
                    {
                        try
                        {

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The password or alternative password you are using is a short password", "Create User",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            try
                            {

                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
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
