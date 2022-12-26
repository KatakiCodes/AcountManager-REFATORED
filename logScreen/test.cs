using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Model;
using Domain.ObjectValue;

namespace logScreen
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();
            dataGridView1.DataSource = userModel.getAll();
        }
    }
}
