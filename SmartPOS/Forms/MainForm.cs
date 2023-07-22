using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SmartPOS.Forms;
using SmartPOS.Classes;

namespace SmartPOS
{
    public partial class MainForm : Form
    {

        private Button currentButton;
        private Form activeForm;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            this.Text = string.Empty;
            this.ControlBox = true;
            this.lblUserFullName.Text = declerations.userFullName;
            Helper.loadPermissions(this.Controls, "Main");
        }


        private void OpenChiledForm(Form cForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = cForm;
            ActiveButton(btnSender);
            cForm.TopLevel = false;
            cForm.FormBorderStyle = FormBorderStyle.None;
            cForm.Dock = DockStyle.Fill;
            pnlMainForm.Controls.Add(cForm);
            pnlMainForm.Tag = cForm;
            cForm.BringToFront();
            cForm.Show();
        }


        private Color SelectTheme()
        {
            if (currentButton.Text == "Point Of Sale")
            {
                return Color.Gray;
            }
            else if (currentButton.Text == "Setup")
            {
                return Color.Red;
            }
            else if (currentButton.Text == "Reporting")
            {
                return Color.Blue;
            }
            else if (currentButton.Text == "Options")
            {
                return Color.Green;
            }
            else
            {
                return Color.Gray;
            }
        }
        

        private void ActiveButton(object sender)
        { 
            if (sender != null)
            {
                if (currentButton != (Button) sender)
                {
                    unSelectButton();
                    currentButton = (Button)sender;
                    Color color = SelectTheme();                    
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Tahoma", 11F, FontStyle.Bold);
                    pnlTitle.BackColor = color;
                }
            }
        }

        private void unSelectButton()
        {
            foreach (Control ctr in pnlMenu.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                    ctr.Font = new Font("Tahoma", 8F, FontStyle.Regular);
                }
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new MainPointOfSale(), sender);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new MainSetup(), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new MainReports(), sender);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new MainOptions(), sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/mostafa.sokar.14");
        }

        private void pnlMainForm_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
