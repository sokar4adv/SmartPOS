﻿using SmartPOS.Classes;
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
    public partial class MainPointOfSale : Form
    {
        public MainPointOfSale()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POSForm pOSForm = new POSForm();
            pOSForm.ShowDialog();
        }

        private void MainPointOfSale_Load(object sender, EventArgs e)
        {
            Helper.loadPermissions(this.Controls, "PointPofSale");
        }
    }
}
