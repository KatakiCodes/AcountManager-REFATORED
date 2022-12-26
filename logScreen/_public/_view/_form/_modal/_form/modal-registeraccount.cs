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
                txt_UserName.Enabled = false;
                txt_contact.Enabled = false;
                cmb_plataform.SelectedIndex = 0;
                cmb_plataform.Enabled = false;
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
                txt_Plataform_name.Enabled = false;
        }
    }
}
