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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private SqlCommand cmd;
        private SqlDataReader dr;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ( txtUserName.Text == "" )
            {
                MessageBox.Show("Enter Your UserName");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Your Password");
                return;
            }
            logIn();
        }

        private void logIn()
        {
            string selectSql = " SELECT * From Users where userName = @userName and password = @password";
            cmd = new SqlCommand(selectSql, adoClass.sqlCn);
            dr = null;
            cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
            cmd.Parameters["@password"].Value = txtPassword.Text;
            cmd.Parameters["@userName"].Value = txtUserName.Text;
            try
            {
                if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        declerations.userId = int.Parse(dr["id"].ToString());
                        declerations.userFullName = dr["fullName"].ToString();
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Sorry LogIn Field");
                    return;
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { adoClass.sqlCn.Close();}
            if (declerations.userId > 0)
            {
                loadPermissions(declerations.userId.ToString());
            }
        }

        private void loadPermissions(string userCode)
        {
            declerations.permissions = new List<modelPermission>();
            string selectSql = "Select * From UserPermissions where UserId = '" + userCode + "'";
            cmd = new SqlCommand(selectSql, adoClass.sqlCn);
            dr = null;
            try
            {

                if (adoClass.sqlCn.State != ConnectionState.Open) adoClass.sqlCn.Open();
                dr = cmd.ExecuteReader();
                modelPermission model = null;
                while (dr.Read())
                {
                    model = new modelPermission();
                    model.mainScreen = dr["mainScreen"].ToString();
                    model.permission = dr["permission"].ToString();
                    model.theCase = bool.Parse(dr["theCase"].ToString());
                    declerations.permissions.Add(model);


                }


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { adoClass.sqlCn.Close(); }
        }
    }
}
