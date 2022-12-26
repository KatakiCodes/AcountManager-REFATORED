using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            for(int i = 0; i < 10; i++)
            {
                guna2DataGridView1.Rows.Add("Nelson Dos Santos");
            }
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
    }
}
