using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SmartPOS.Classes;

namespace SmartPOS.Forms
{
    public partial class MainOptions : Form
    {
        public MainOptions()
        {
            InitializeComponent();
        }

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow Row;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainOptions_Load(object sender, EventArgs e)
        {
            Helper.fillComboBox(comboBox1, "SELECT Id, DES FROM Categorise");
            adapter = new SqlDataAdapter("Select Top 1 * From Options", adoClass.sqlCn);
            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    Row = dataTable.Rows[0];
                    for (int i =0; i <= dataTable.Rows.Count -1; i ++)
                    {
                        txtRestName.Text = dataTable.Rows[i]["RestName"].ToString();
                        txtRestAddress1.Text = dataTable.Rows[i]["RestAddress1"].ToString();
                        txtRestAddress2.Text = dataTable.Rows[i]["RestAddress2"].ToString();
                        txtTelephone.Text = dataTable.Rows[i]["Telephone"].ToString();
                        txtPrinterName.Text = dataTable.Rows[i]["PrinterName"].ToString();
                        txtreceiptline1.Text = dataTable.Rows[i]["receiptline1"].ToString();
                        txtreceiptline2.Text = dataTable.Rows[i]["receiptline2"].ToString();
                        if (dataTable.Rows[i]["logo"] != DBNull.Value)
                        {                                                   
                            pictureBox1.BackgroundImage = Helper.ByteToImage(dataTable.Rows[i]["logo"]);
                        }
                        comboBox1.Text = Helper.getComboItemVal(comboBox1, dataTable.Rows[i]["defultCategoryId"].ToString());
                    }
                }
                else
                {
                    Row = null;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save New Data", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            if (txtRestName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the Restaurant Name");
                txtRestName.Focus();
                return;
            }
            if (txtTelephone.Text == string.Empty)
            {
                MessageBox.Show("plese Enter the Telephone Number");
                txtTelephone.Focus();
                return;
            }
            if (Row == null)
            {
                Row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(Row);
            }
            else
            {
                Row.BeginEdit();
                dataFillRow();
                Row.EndEdit();
            }
            try
            {
                adoClass.builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Data has been updated :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataFillRow()
        {
            Row["RestName"] = txtRestName.Text;
            Row["RestAddress1"] = txtRestAddress1.Text;
            Row["RestAddress2"] = txtRestAddress2.Text;
            Row["Telephone"] = txtTelephone.Text;
            Row["PrinterName"] = txtPrinterName.Text;
            Row["receiptline1"] = txtreceiptline1.Text;
            Row["receiptline2"] = txtreceiptline2.Text;
            if (pictureBox1.BackgroundImage != null)
            {
                Row["logo"] = Helper.ImageToByte(pictureBox1.BackgroundImage);
            }
            if (comboBox1.Text != "")
                Row["defultCategoryId"] = ((comboItem)comboBox1.SelectedItem).Id;
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images |*.png";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtPic.Text);
            }
        }
    }
}
