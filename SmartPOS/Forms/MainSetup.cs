using SmartPOS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS.Forms
{
    public partial class MainSetup : Form
    {
        public MainSetup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPayments form = new FormPayments();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUsers form = new FormUsers();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategorise form = new FormCategorise();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormItems form = new FormItems();
            form.ShowDialog();
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            FormPermissions form = new FormPermissions();
            form.ShowDialog();
        }

        private void MainSetup_Load(object sender, EventArgs e)
        {
            Helper.loadPermissions(this.Controls, "Setup");
        }
    }
}
