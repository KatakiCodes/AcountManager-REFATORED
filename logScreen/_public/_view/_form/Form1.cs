using System;
using System.Windows.Forms;
using logScreen._public._classes;
using logScreen._userControls;
using Domain.Model;


namespace logScreen
{
    public partial class Form1 : Form
    {
        viewFunction vf = new viewFunction();
        UserModel userModel = new UserModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Check user into database
            if(userModel.GetAll() == null)
            {
                link_ToggleControl.Text = "Create user";
                vf.toggle_log_cad_control(log_Container, link_ToggleControl);
                vf.Toggle_loginImage(pictureBox1, pictureBox2, link_ToggleControl.Text);
            }
            else
            {
                link_ToggleControl.Text = "Login";
                vf.toggle_log_cad_control(log_Container, link_ToggleControl);
            }
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
                logScreen.DashBoard dashboard = new DashBoard();
                dashboard.Show();
                timer1.Dispose();
            }
        }
    }
}
