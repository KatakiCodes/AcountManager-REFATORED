using System;
using System.Windows.Forms;
using Domain.ObjectValue;
using Domain.Model;
using logScreen._modal._modal_behavior;

namespace logScreen
{
    public partial class DashBoard : Form
    {
        Modal modal = new Modal();
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            guna2TileButton4.PerformClick();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TileButton1_Click(object sender, EventArgs e)
        {
            modal.AllAccount(this);
        }

        private void Guna2TileButton2_Click(object sender, EventArgs e)
        {
            modal.registerAccount(this);
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This operation shuts down the application, are you sure about it?",
                "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TileButton4_Click(object sender, EventArgs e)
        {
            lbl_totalAccounts.Text = Cache.account.Count.ToString();

            //Filter shorts password
            var shortcounter = 0;
            foreach (AccountModel account in Cache.account)
            {
                if (Cache.account.Find(x => x.Password.Length <= 6) != null)
                {

                    shortcounter += 1;
                }
            }
            lbl_TotalShortsPasswords.Text = shortcounter.ToString();
        }
    }
}
