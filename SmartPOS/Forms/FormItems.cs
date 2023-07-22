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
    public partial class FormItems : Form
    {
        public FormItems()
        {
            InitializeComponent();
        }

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;
        private int index;


        private void FormItems_Load(object sender, EventArgs e)
        {
            Helper.fillComboBox(comboBox1, "SELECT Id, DES FROM Categorise");
            adapter = new SqlDataAdapter("Select * From Items", adoClass.sqlCn);
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
                comboBox1.Text = Helper.getComboItemVal(comboBox1, dataTable.Rows[_index]["CategoryId"].ToString());
                txtPrice.Text = dataTable.Rows[_index]["price"].ToString();
                txtNotes.Text = dataTable.Rows[_index]["notes"].ToString();
                if (dataTable.Rows[_index]["itemImg"] != DBNull.Value)
                {
                    pictureBox1.BackgroundImage = Helper.ByteToImage(dataTable.Rows[_index]["itemImg"]);
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                }
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
                comboBox1.Text = Helper.getComboItemVal(comboBox1, row["CategoryId"].ToString());
                txtPrice.Text = row["price"].ToString();
                txtNotes.Text = row["notes"].ToString();
                if (row["itemImg"] != DBNull.Value)
                {
                    pictureBox1.BackgroundImage = Helper.ByteToImage(row["itemImg"]);
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                }
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
                if (ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            pictureBox1.BackgroundImage = null;
            txtDEs.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDEs.Text == string.Empty)
            {
                MessageBox.Show("Enter The DES");
                txtDEs.Focus();
                return;
            }
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Select The Catigory");
                return;
            }
            if (double.Parse(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Enter The Price");
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
            row["CategoryId"] = ((comboItem) comboBox1.SelectedItem).Id;
            row["price"] = txtPrice.Text;
            row["notes"] = txtNotes.Text;
            if (pictureBox1.BackgroundImage != null)
            {
                row["itemImg"] = Helper.ImageToByte(pictureBox1.BackgroundImage);
            }
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
            FormSelect select = new FormSelect("Select id, DES From Items");
            select.des = "DES";
            if (select.ShowDialog() == DialogResult.OK)
            {
                loadData(int.Parse(select.result));
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images |*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtPic.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
