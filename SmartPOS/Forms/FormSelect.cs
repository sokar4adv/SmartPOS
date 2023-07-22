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
    public partial class FormSelect : Form
    {
        public FormSelect(string _selectTxt)
        {
            InitializeComponent();
            selectTxt = _selectTxt;
        }

        private DataTable dataTable;
        private SqlDataAdapter adapter;
        public string selectTxt { get; set; }
        public string des { get; set; }
        public string result { get; set; }


        private void txtDES_KeyUp(object sender, KeyEventArgs e)
        {
            loadselect();

        }


        private void loadselect()
        {
            dataTable.DefaultView.Sort = "Id";
            DataRow[] rows = dataTable.Select(des + " LIKE '%'+'" + txtDEs.Text + "'+'%' ");
            dgvItems.Rows.Clear();
            for (int i = 0; i <= rows.Length -1; i ++)
            {
                dgvItems.Rows.Add(new object[] {
                    rows[i][0],
                    rows[i][des]
                });
            }
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(selectTxt, adoClass.sqlCn);
            dataTable = new DataTable();
            try {
                adapter.Fill(dataTable);
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if  (dgvItems.Rows.Count >0)
            {
                result = dgvItems[ColId.Index, dgvItems.CurrentRow.Index].Value.ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
