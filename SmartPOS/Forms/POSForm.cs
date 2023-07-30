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
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
            CheckId = "0";
        }

        private SqlDataAdapter adapter;
        private DataTable _itemsDt;
        private string CheckId;


        private void POSForm_Load(object sender, EventArgs e)
        {
            Helper.fillComboBox(cmbxPayment, "SELECT Id, DES FROM Payments");
            cmbxPayment.Text = Helper.getComboItemVal(cmbxPayment, "1");
            //fillCategories();
            string catId = declerations.systemOptions["defultCategoryId"].ToString();
            fillItems(catId);
            btn0.Click += num_Click;
            btn1.Click += num_Click;
            btn2.Click += num_Click;
            btn3.Click += num_Click;
            btn4.Click += num_Click;
            btn5.Click += num_Click;
            btn6.Click += num_Click;
            btn7.Click += num_Click;
            btn8.Click += num_Click;
            btn9.Click += num_Click;
            btnCancel.Click += num_Click;
            btnDot.Click += num_Click;
        }

        private void fillCategories()
        {
            adapter = new SqlDataAdapter("Select Id,DES From Categorise", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                DataRow[] drs = _itemsDt.Select();
                int x = 3, y = 3, count = 1;
                pnlItems.Controls.Clear();
                for (int i =0; i <= drs.Length - 1; i ++)
                {
                    Button catBtn = new Button();
                    catBtn.BackColor = Color.LightCyan;
                    catBtn.AccessibleName = "CAT";
                    catBtn.AccessibleDescription = drs[i]["Id"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["Id"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Size = new Size(85, 85);
                    catBtn.Location = new Point(x, y);
                    catBtn.Click += cBtn_Click;
                    pnlItems.Controls.Add(catBtn);
                    x += 87;
                    if (count == 6)
                    {
                        y += 87;
                        x = 3;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.AccessibleName == "CAT")
            {
                string CatId = button.AccessibleDescription;
                fillItems(CatId);
            }
            else if (button.AccessibleName == "IT")
            {
                double Qty = 0;
                double.TryParse(txtItemQTY.Text, out Qty);
                if (Qty == 0)
                {
                    Qty = 1;
                }
                double toalPrice = 0;
                double itemPrice = 0;
                double.TryParse(button.Tag.ToString(), out itemPrice);
                toalPrice = Qty * itemPrice;
                dgvItems.Rows.Add(new object[] {
                    button.AccessibleDescription,
                    button.Text,
                    Qty,
                    toalPrice,
                    itemPrice
                });
                txtItemQTY.Text = "0";
            }
            else
            {
                fillCategories();
            }
            calCheck();
        }


        private void fillItems(string catId)
        {
            adapter = new SqlDataAdapter("Select * From Items WHERE CategoryId = '" + catId + "'", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                DataRow[] drs = _itemsDt.Select();
                int x = 3, y = 3, count = 1;
                pnlItems.Controls.Clear();
                Button catBtn;
                for (int i = 0; i <= drs.Length - 1; i++)
                {
                    catBtn = new Button();
                    catBtn.BackColor = Color.LightCyan;
                    catBtn.AccessibleName = "IT";
                    catBtn.AccessibleDescription = drs[i]["Id"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["Id"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Tag = drs[i]["price"].ToString();
                    catBtn.TextAlign = ContentAlignment.BottomRight;
                    catBtn.Image = Helper.ByteToImage(drs[i]["itemImg"]);
                    catBtn.Size = new Size(85, 85);
                    catBtn.Location = new Point(x, y);
                    catBtn.Click += cBtn_Click;
                    pnlItems.Controls.Add(catBtn);
                    x += 87;
                    if (count == 6)
                    {
                        y += 87;
                        x = 3;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                catBtn = new Button();
                catBtn.Size = new Size(85, 85);
                catBtn.AccessibleName = "C";
                catBtn.Name = "btnEnd" + catId;
                catBtn.Text = "Cancel";
                catBtn.Location = new Point(x, y);
                catBtn.Click += cBtn_Click;
                pnlItems.Controls.Add(catBtn);

            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            dgvItems.Rows.Clear();
            txtPayed.Clear();
            txtChange.Clear();
            txtItemQTY.Text = "0";
            txtPayed.Text = "0";
            txtChange.Text = "0";
            calCheck();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count >0)
            {
                dgvItems.Rows.Remove(dgvItems.CurrentRow);
                calCheck();
            }
        }


        private void calCheck()
        {
            double x = 0;
            double result = 0;
            for (int i = 0; i <= dgvItems.Rows.Count - 1; i++)
            {
                double.TryParse(dgvItems[ColPrice.Index, i].Value.ToString(), out x);
                result += x;
            }
            txtTotal.Text = result.ToString();
        }

        private void num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ( button.Text == "C")
            {
                txtItemQTY.Text = "0";
            }
            else if (button.Text == ".")
            {
                if (!txtItemQTY.Text.Contains("."))
                {
                    if (double.Parse(txtItemQTY.Text) == 0)
                    {
                        button.Text = "0.";
                    }
                    else
                    {
                        txtItemQTY.Text += button.Text;
                    }
                }
            }
            else
            {
                if (double.Parse(txtItemQTY.Text) == 0)
                {
                    txtItemQTY.Text = button.Text;
                }
                else
                {
                    txtItemQTY.Text += button.Text;
                }
            }
        }


        private void saveCheck()
        {
            string insertSql = " Insert InTo Checks(checkDate, userId, totalCheck, status) values (@checkDate, @userId, @totalCheck, @status); ";
            insertSql += " Select @CheckId = SCOPE_IDENTITY(); ";
            SqlCommand sqlCm = new SqlCommand(insertSql, adoClass.sqlCn);
            sqlCm.Parameters.Add("@checkDate", SqlDbType.DateTime);
            sqlCm.Parameters.Add("@userId", SqlDbType.Int);
            sqlCm.Parameters.Add("@totalCheck", SqlDbType.Decimal);
            sqlCm.Parameters.Add("@status", SqlDbType.VarChar);
            sqlCm.Parameters.Add("@CheckId", SqlDbType.Int);
            try
            {
                sqlCm.Parameters["@CheckId"].Direction = ParameterDirection.Output;
                sqlCm.Parameters["@checkDate"].Value = DateTime.Now;
                sqlCm.Parameters["@userId"].Value = declerations.userId;
                sqlCm.Parameters["@totalCheck"].Value = double.Parse(txtTotal.Text);
                sqlCm.Parameters["@status"].Value = "Close";
                if (adoClass.sqlCn.State != ConnectionState.Open)
                {
                    adoClass.sqlCn.Open();

                }
                sqlCm.ExecuteNonQuery();
                CheckId = sqlCm.Parameters["@CheckId"].Value.ToString();
                this.Text += " : ID :" + CheckId + " : ";
                SaveDateItems(CheckId);
                SaveDataPayments(CheckId);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                adoClass.sqlCn.Close();
            }
        }

        private void SaveDateItems(string checkId)
        {
            adapter = new SqlDataAdapter("Select TOP 1 * FROM ChecksItems", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                for (int i = 0; i <= dgvItems.Rows.Count - 1; i ++)
                {
                    DataRow row = _itemsDt.NewRow();
                    row["CheckId"] = checkId;
                    row["ItemId"] = dgvItems[ColItemId.Index, i].Value;
                    row["QTY"] = dgvItems[ColQTY.Index, i].Value;
                    row["price"] = dgvItems[ColItemPrice.Index, i].Value;
                    row["totalPrice"] = dgvItems[ColPrice.Index, i].Value;
                    _itemsDt.Rows.Add(row);
                }
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveDataPayments(string checkId)
        {
            adapter = new SqlDataAdapter("Select TOP 1 * FROM ChecksPay", adoClass.sqlCn);
            _itemsDt = new DataTable();
            try
            {
                adapter.Fill(_itemsDt);
                DataRow row = _itemsDt.NewRow();
                row["CheckId"] = checkId;
                row["PaymentId"] = ((comboItem)cmbxPayment.SelectedItem).Id;
                row["PayVal"] = double.Parse(txtPayed.Text);
                _itemsDt.Rows.Add(row);
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveData()
        {
            adoClass.builder = new SqlCommandBuilder(adapter);
            adapter.Update(_itemsDt);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double totalCheck = 0;
            double totalPay = 0;
            double.TryParse(txtTotal.Text, out totalCheck);
            double.TryParse(txtItemQTY.Text, out totalPay);
            if (totalCheck == 0)
            {
                MessageBox.Show("Can't Save Empty Check");
                return;
            }
            if (totalPay == 0)
            {
                MessageBox.Show("Can't Pay Without Money");
                return;
            }
            if (totalPay < totalCheck)
            {
                MessageBox.Show("The Payment not enough");
                return;
            }
            if (cmbxPayment.Text == string.Empty)
            {
                MessageBox.Show("Select Pay Method");
                return;
            }
            txtPayed.Text = totalCheck.ToString();
            txtChange.Text = (totalPay - totalCheck).ToString();
            saveCheck();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (CheckId != "0")
            {
                printChecks checks = new printChecks();
                checks.runprintCheck(int.Parse(CheckId));
            }
            else
            {
                MessageBox.Show("Can't Print non paid check");
            }
        }
    }
}
