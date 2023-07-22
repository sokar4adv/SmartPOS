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
    public partial class FormStartUp : Form
    {
        public FormStartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "Loading.......";

            if (progressBar1.Value == 10)
            {
                lblInfo.Text = "Loading System Options";
                ClassLoading loading = new ClassLoading();
                loading.loadSystemOptions();
            }
            if (progressBar1.Value == 20)
            {
                Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                progressBar1.Value++;
                progressBar1.Refresh();
            }
        }

        private void FormStartUp_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
