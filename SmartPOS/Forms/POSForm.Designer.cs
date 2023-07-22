
namespace SmartPOS.Forms
{
    partial class POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemQTY = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ColItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblToal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.lblPaied = new System.Windows.Forms.Label();
            this.cmbxPayment = new System.Windows.Forms.ComboBox();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtItemQTY);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Location = new System.Drawing.Point(824, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 440);
            this.panel1.TabIndex = 0;
            // 
            // txtItemQTY
            // 
            this.txtItemQTY.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemQTY.Location = new System.Drawing.Point(3, 4);
            this.txtItemQTY.Name = "txtItemQTY";
            this.txtItemQTY.Size = new System.Drawing.Size(162, 33);
            this.txtItemQTY.TabIndex = 12;
            this.txtItemQTY.Text = "0";
            this.txtItemQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(115, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(59, 212);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(50, 50);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(3, 211);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(115, 155);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(59, 155);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 155);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(115, 99);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(59, 99);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 99);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(115, 43);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(59, 43);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 43);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColItemId,
            this.ColItemName,
            this.ColQTY,
            this.ColPrice,
            this.ColItemPrice});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItems.Location = new System.Drawing.Point(12, 63);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(270, 440);
            this.dgvItems.TabIndex = 1;
            // 
            // ColItemId
            // 
            this.ColItemId.HeaderText = "Id";
            this.ColItemId.MinimumWidth = 100;
            this.ColItemId.Name = "ColItemId";
            this.ColItemId.ReadOnly = true;
            this.ColItemId.Visible = false;
            // 
            // ColItemName
            // 
            this.ColItemName.HeaderText = "Item";
            this.ColItemName.Name = "ColItemName";
            this.ColItemName.ReadOnly = true;
            // 
            // ColQTY
            // 
            this.ColQTY.FillWeight = 50F;
            this.ColQTY.HeaderText = "QTY";
            this.ColQTY.Name = "ColQTY";
            this.ColQTY.ReadOnly = true;
            this.ColQTY.Width = 50;
            // 
            // ColPrice
            // 
            this.ColPrice.FillWeight = 75F;
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 75;
            // 
            // ColItemPrice
            // 
            this.ColItemPrice.HeaderText = "ItemPrice";
            this.ColItemPrice.Name = "ColItemPrice";
            this.ColItemPrice.ReadOnly = true;
            this.ColItemPrice.Visible = false;
            // 
            // pnlItems
            // 
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlItems.Location = new System.Drawing.Point(288, 63);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(530, 440);
            this.pnlItems.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.lblToal);
            this.panel3.Location = new System.Drawing.Point(12, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 160);
            this.panel3.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(75, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(188, 78);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblToal
            // 
            this.lblToal.AutoSize = true;
            this.lblToal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToal.Location = new System.Drawing.Point(3, 32);
            this.lblToal.Name = "lblToal";
            this.lblToal.Size = new System.Drawing.Size(66, 25);
            this.lblToal.TabIndex = 0;
            this.lblToal.Text = "Total";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnCancelOrder);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.txtChange);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtPayed);
            this.panel4.Controls.Add(this.lblPaied);
            this.panel4.Controls.Add(this.cmbxPayment);
            this.panel4.Controls.Add(this.lblPayMethod);
            this.panel4.Location = new System.Drawing.Point(288, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(708, 160);
            this.panel4.TabIndex = 3;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOrder.Image")));
            this.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelOrder.Location = new System.Drawing.Point(574, 21);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(120, 50);
            this.btnCancelOrder.TabIndex = 14;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(574, 76);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 50);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(448, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 50);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(448, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 50);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.Location = new System.Drawing.Point(322, 21);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(120, 50);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(322, 76);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 50);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(141, 96);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(156, 33);
            this.txtChange.TabIndex = 6;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Change";
            // 
            // txtPayed
            // 
            this.txtPayed.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayed.Location = new System.Drawing.Point(141, 57);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.Size = new System.Drawing.Size(156, 33);
            this.txtPayed.TabIndex = 4;
            this.txtPayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPaied
            // 
            this.lblPaied.AutoSize = true;
            this.lblPaied.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaied.Location = new System.Drawing.Point(19, 60);
            this.lblPaied.Name = "lblPaied";
            this.lblPaied.Size = new System.Drawing.Size(70, 25);
            this.lblPaied.TabIndex = 3;
            this.lblPaied.Text = "Paied";
            // 
            // cmbxPayment
            // 
            this.cmbxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPayment.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPayment.FormattingEnabled = true;
            this.cmbxPayment.Location = new System.Drawing.Point(141, 18);
            this.cmbxPayment.Name = "cmbxPayment";
            this.cmbxPayment.Size = new System.Drawing.Size(156, 33);
            this.cmbxPayment.TabIndex = 2;
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.Location = new System.Drawing.Point(19, 15);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(105, 25);
            this.lblPayMethod.TabIndex = 1;
            this.lblPayMethod.Text = "Payment";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POSForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSForm";
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtItemQTY;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblToal;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayed;
        private System.Windows.Forms.Label lblPaied;
        private System.Windows.Forms.ComboBox cmbxPayment;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemPrice;
    }
}