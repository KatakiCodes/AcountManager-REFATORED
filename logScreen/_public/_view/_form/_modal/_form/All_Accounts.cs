using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.ObjectValue;

namespace logScreen._modal
{
    public partial class All_Accounts : Form
    {
        public All_Accounts()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2CircleButton1_Click(object sender, EventArgs e)
        {
            txt_Email.Enabled = true;
            txt_Email.Visible = true;

            txt_Contact.Enabled = true;
            txt_Contact.Visible = true;

            txt_password.Enabled = true;
            txt_password.Visible = true;

            txt_ConfirmPassword.Enabled = true;
            txt_ConfirmPassword.Visible = true;

            txt_OldPassword.Enabled = true;
            txt_OldPassword.Visible = true;

            btn_Cancel.Enabled = true;
            btn_Cancel.Visible = true;

            btn_Update.Enabled = true;
            btn_Update.Visible = true;

            btn_Done.Visible = false;
            btn_Done.Enabled = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Email.Enabled = false;
            txt_Email.Visible = false;

            txt_Contact.Enabled = false;
            txt_Contact.Visible = false;

            txt_password.Enabled = false;
            txt_password.Visible = false;

            txt_ConfirmPassword.Enabled = false;
            txt_ConfirmPassword.Visible = false;

            txt_OldPassword.Enabled = false;
            txt_OldPassword.Visible = false;

            btn_Update.Enabled = false;
            btn_Update.Visible = false;

            btn_Cancel.Enabled = false;
            btn_Cancel.Visible = false;

            btn_Done.Visible = true;
            btn_Done.Enabled = true;
        }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void All_Accounts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Cache.account;
        }
    }
}
