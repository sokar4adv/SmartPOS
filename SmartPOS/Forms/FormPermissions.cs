using SmartPOS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS.Forms
{
    public partial class FormPermissions : Form
    {
        public FormPermissions()
        {
            InitializeComponent();
        }

        private int counter;
        private SqlCommand cmd;
        private SqlDataReader dr;


        private void FormPermissions_Load(object sender, EventArgs e)
        {
            Helper.fillComboBox(cmbxUsers, "SELECT Id,fullName from Users");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void checkAll(Control.ControlCollection controls, bool status)
        {
            foreach(Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = status;
                }
                if (control.Controls.Count > 0)
                {
                    checkAll(control.Controls, status);

                }
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            checkAll(this.Controls, true);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            checkAll(this.Controls, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbxUsers.Text == "")
            {
                MessageBox.Show("Select User First");
                return;
            }
            string userCode = ((comboItem)cmbxUsers.SelectedItem).Id;
            saveData(userCode);
        }

        private void saveCmd(string Txt)
        {
            cmd = new SqlCommand(Txt, adoClass.sqlCn);
            try
            {
                if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { adoClass.sqlCn.Close(); }
        }

        private void saveData(string userCode)
        {
            string delTxt = "Delete From UserPermissions Where UserId = '" + userCode + "'";
            saveCmd(delTxt);
            counter = 1;
            string insertTxt = getDataChbx(this.Controls, userCode);
            saveCmd(insertTxt);
            MessageBox.Show("Success");
        }


        private string getDataChbx(Control.ControlCollection controls, string userCode)
        {
            string xResult = string.Empty;
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    xResult += " Insert InTo UserPermissions(pIndex, mainScreen, permission, UserId, theCase) ";
                    xResult += " Values ( " + counter;
                    xResult += " , '" + checkBox.AccessibleDescription + "' ";
                    xResult += " , '" + checkBox.AccessibleName + "' ";
                    xResult += " , " + userCode;
                    xResult += " , " + (checkBox.Checked? 1 : 0) + " ) ";
                    xResult += " \n ";
                    counter++;
                }
                if (control.Controls.Count > 0)
                {
                    xResult += getDataChbx(control.Controls, userCode);
                }
            }
            return xResult;
        }

        private void cmbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAll(this.Controls, false);
            if (cmbxUsers.Text == "")
            {
                return;
            }
            string userCode = ((comboItem)cmbxUsers.SelectedItem).Id;
            fillDataPermissions(userCode);
        }

        private void fillDataPermissions(string userCode)
        {
            cmd = new SqlCommand("Select * From UserPermissions where UserId = '" + userCode + "'", adoClass.sqlCn);
            dr = null;
            try
            {
                if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    checkChbx(this.Controls,
                        bool.Parse(dr["theCase"].ToString()),
                        dr["mainScreen"].ToString(),
                        dr["permission"].ToString());
                }

            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { adoClass.sqlCn.Close(); }
        }


        private void checkChbx(Control.ControlCollection controls, bool status,string mainScreen, string permisson)
        {
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if ( checkBox.AccessibleDescription == mainScreen && checkBox.AccessibleName == permisson)
                    {
                        checkBox.Checked = status;

                    }
                }
                if (control.Controls.Count > 0)
                {
                    checkChbx(control.Controls, status, mainScreen, permisson);

                }
            }
        }


    }
}
