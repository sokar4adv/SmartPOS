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
    public partial class MainReports : Form
    {
        public MainReports()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainReports_Load(object sender, EventArgs e)
        {

        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            FilterForm filter = new FilterForm();
            if (filter.ShowDialog() == DialogResult.OK)
            {
                printChecks checks = new printChecks();
                checks.runSaleReports(filter._from, filter._to);
            }
        }

        private void btnSaleDetailsReport_Click(object sender, EventArgs e)
        {
            FilterForm filter = new FilterForm();
            if (filter.ShowDialog() == DialogResult.OK)
            {
                printChecks checks = new printChecks();
                checks.runSaleDetailsReport(filter._from, filter._to);
            }
        }
    }
}
