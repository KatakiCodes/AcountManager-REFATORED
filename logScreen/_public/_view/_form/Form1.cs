using System;
using System.Windows.Forms;
using logScreen._public._classes;
using logScreen._public._classes;


namespace logScreen
{
    public partial class Form1 : Form
    {
        viewFunction vf = new viewFunction();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                ////Verificar utilizador
            //if (vm.checkUserInDatabase() == true)
            //{
            //link_ToggleControl.Text = "Login";
            //Link_ToggleControl_LinkClicked(null, null);
            //}
            //else
            //{
            //    link_ToggleControl.Text = "Create user";
            //    Link_ToggleControl_LinkClicked(null, null);
            //}


        }

        private void Link_ToggleControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vf.toggle_log_cad_control(log_Container, link_ToggleControl);
            vf.Toggle_loginImage(pictureBox1, pictureBox2, link_ToggleControl.Text);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Holding.Holding_logScreen == false)
            {
                return;
            }
            else
            {
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
