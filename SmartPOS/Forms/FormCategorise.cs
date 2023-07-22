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
    public partial class FormCategorise : Form
    {
        public FormCategorise()
        {
            InitializeComponent();
        }

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;
        private int index;


        private void FormCategorise_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From Categorise", adoClass.sqlCn);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            index = 0;
            loadData(0);
        }

        private void loadDatawithIndex(int _index)
        {
            index = _index;
            if (dataTable.Rows.Count > 0 && _index >= 0 && _index <= dataTable.Rows.Count - 1)
            {
                txtDEs.Text = dataTable.Rows[_index]["DES"].ToString();
                row = dataTable.Rows[_index];
            }
        }

        private void loadData(int Id)
        {
            DataRow[] dataRows = null;
            if (Id == 0)
            {
                dataRows = dataTable.Select();
            }
            else
            {
                dataRows = dataTable.Select("Id = '" + Id + "'");
            }
            if (dataRows.Length > 0)
            {
                row = dataRows[0];
                txtDEs.Text = row["DES"].ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            row = null;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = string.Empty;
                }
            }
            txtDEs.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDEs.Text == string.Empty)
            {
                MessageBox.Show("Enter the DES");
                txtDEs.Focus();
                return;
            }
            saveData();
        }

        private void saveData()
        {
            if (row == null)
            {
                row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(row);
            }
            else
            {
                row.BeginEdit();
                dataFillRow();
                row.EndEdit();
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
            row["DES"] = txtDEs.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            loadDatawithIndex(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                loadDatawithIndex(index);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < dataTable.Rows.Count - 1)
            {
                index++;
                loadDatawithIndex(index);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            loadDatawithIndex(dataTable.Rows.Count - 1);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("Select id, DES From Categorise");
            select.des = "DES";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }
        }
    }
}
