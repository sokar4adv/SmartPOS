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
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        public DateTime _from { get => dtpFrom.Value; }
        public DateTime _to { get => dtpTo.Value; }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
