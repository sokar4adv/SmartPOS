
namespace SmartPOS.Forms
{
    partial class MainOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainOptions));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRestName = new System.Windows.Forms.Label();
            this.txtRestName = new System.Windows.Forms.TextBox();
            this.txtRestAddress1 = new System.Windows.Forms.TextBox();
            this.lblRestAddress1 = new System.Windows.Forms.Label();
            this.txtRestAddress2 = new System.Windows.Forms.TextBox();
            this.lblRestAddress2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.lblPrinterName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtreceiptline1 = new System.Windows.Forms.TextBox();
            this.lblReceiptline1 = new System.Windows.Forms.Label();
            this.txtreceiptline2 = new System.Windows.Forms.TextBox();
            this.lblReceiptline2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(468, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 90);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRestName
            // 
            this.lblRestName.AutoSize = true;
            this.lblRestName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestName.Location = new System.Drawing.Point(12, 13);
            this.lblRestName.Name = "lblRestName";
            this.lblRestName.Size = new System.Drawing.Size(77, 16);
            this.lblRestName.TabIndex = 3;
            this.lblRestName.Text = "Rest Name";
            // 
            // txtRestName
            // 
            this.txtRestName.Location = new System.Drawing.Point(139, 13);
            this.txtRestName.Name = "txtRestName";
            this.txtRestName.Size = new System.Drawing.Size(173, 20);
            this.txtRestName.TabIndex = 4;
            this.txtRestName.TextChanged += new System.EventHandler(this.txtRestName_TextChanged);
            // 
            // txtRestAddress1
            // 
            this.txtRestAddress1.Location = new System.Drawing.Point(139, 39);
            this.txtRestAddress1.Name = "txtRestAddress1";
            this.txtRestAddress1.Size = new System.Drawing.Size(173, 20);
            this.txtRestAddress1.TabIndex = 6;
            this.txtRestAddress1.TextChanged += new System.EventHandler(this.txtRestAddress1_TextChanged);
            // 
            // lblRestAddress1
            // 
            this.lblRestAddress1.AutoSize = true;
            this.lblRestAddress1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestAddress1.Location = new System.Drawing.Point(12, 39);
            this.lblRestAddress1.Name = "lblRestAddress1";
            this.lblRestAddress1.Size = new System.Drawing.Size(108, 16);
            this.lblRestAddress1.TabIndex = 5;
            this.lblRestAddress1.Text = "Rest Address 1";
            // 
            // txtRestAddress2
            // 
            this.txtRestAddress2.Location = new System.Drawing.Point(139, 65);
            this.txtRestAddress2.Name = "txtRestAddress2";
            this.txtRestAddress2.Size = new System.Drawing.Size(173, 20);
            this.txtRestAddress2.TabIndex = 8;
            this.txtRestAddress2.TextChanged += new System.EventHandler(this.txtRestAddress2_TextChanged);
            // 
            // lblRestAddress2
            // 
            this.lblRestAddress2.AutoSize = true;
            this.lblRestAddress2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestAddress2.Location = new System.Drawing.Point(12, 65);
            this.lblRestAddress2.Name = "lblRestAddress2";
            this.lblRestAddress2.Size = new System.Drawing.Size(108, 16);
            this.lblRestAddress2.TabIndex = 7;
            this.lblRestAddress2.Text = "Rest Address 2";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(139, 91);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(173, 20);
            this.txtTelephone.TabIndex = 10;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtTelephone_TextChanged);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(12, 91);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(48, 16);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "Phone";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(139, 117);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(173, 20);
            this.txtPrinterName.TabIndex = 12;
            this.txtPrinterName.TextChanged += new System.EventHandler(this.txtPrinterName_TextChanged);
            // 
            // lblPrinterName
            // 
            this.lblPrinterName.AutoSize = true;
            this.lblPrinterName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinterName.Location = new System.Drawing.Point(12, 117);
            this.lblPrinterName.Name = "lblPrinterName";
            this.lblPrinterName.Size = new System.Drawing.Size(53, 16);
            this.lblPrinterName.TabIndex = 11;
            this.lblPrinterName.Text = "Printer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(139, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 121);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(139, 359);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(173, 20);
            this.txtPic.TabIndex = 17;
            this.txtPic.TextChanged += new System.EventHandler(this.txtlogo_TextChanged);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPic.Location = new System.Drawing.Point(12, 232);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(43, 16);
            this.lblPic.TabIndex = 16;
            this.lblPic.Text = "Logo";
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPic.Location = new System.Drawing.Point(83, 360);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(50, 19);
            this.btnSelectPic.TabIndex = 18;
            this.btnSelectPic.Text = "****";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(352, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 90);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtreceiptline1
            // 
            this.txtreceiptline1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreceiptline1.Location = new System.Drawing.Point(139, 143);
            this.txtreceiptline1.Name = "txtreceiptline1";
            this.txtreceiptline1.Size = new System.Drawing.Size(173, 22);
            this.txtreceiptline1.TabIndex = 21;
            this.txtreceiptline1.TextChanged += new System.EventHandler(this.txtReceiptline1_TextChanged);
            // 
            // lblReceiptline1
            // 
            this.lblReceiptline1.AutoSize = true;
            this.lblReceiptline1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptline1.Location = new System.Drawing.Point(12, 143);
            this.lblReceiptline1.Name = "lblReceiptline1";
            this.lblReceiptline1.Size = new System.Drawing.Size(95, 16);
            this.lblReceiptline1.TabIndex = 20;
            this.lblReceiptline1.Text = "Receipt line 1";
            // 
            // txtreceiptline2
            // 
            this.txtreceiptline2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreceiptline2.Location = new System.Drawing.Point(139, 169);
            this.txtreceiptline2.Name = "txtreceiptline2";
            this.txtreceiptline2.Size = new System.Drawing.Size(173, 22);
            this.txtreceiptline2.TabIndex = 23;
            this.txtreceiptline2.TextChanged += new System.EventHandler(this.txtReceiptline2_TextChanged);
            // 
            // lblReceiptline2
            // 
            this.lblReceiptline2.AutoSize = true;
            this.lblReceiptline2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptline2.Location = new System.Drawing.Point(12, 169);
            this.lblReceiptline2.Name = "lblReceiptline2";
            this.lblReceiptline2.Size = new System.Drawing.Size(95, 16);
            this.lblReceiptline2.TabIndex = 22;
            this.lblReceiptline2.Text = "Receipt line 2";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Category";
            // 
            // MainOptions
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 391);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtreceiptline2);
            this.Controls.Add(this.lblReceiptline2);
            this.Controls.Add(this.txtreceiptline1);
            this.Controls.Add(this.lblReceiptline1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectPic);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.lblPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrinterName);
            this.Controls.Add(this.lblPrinterName);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtRestAddress2);
            this.Controls.Add(this.lblRestAddress2);
            this.Controls.Add(this.txtRestAddress1);
            this.Controls.Add(this.lblRestAddress1);
            this.Controls.Add(this.txtRestName);
            this.Controls.Add(this.lblRestName);
            this.Controls.Add(this.btnExit);
            this.Name = "MainOptions";
            this.Text = "MainOptions";
            this.Load += new System.EventHandler(this.MainOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRestName;
        private System.Windows.Forms.TextBox txtRestName;
        private System.Windows.Forms.TextBox txtRestAddress1;
        private System.Windows.Forms.Label lblRestAddress1;
        private System.Windows.Forms.TextBox txtRestAddress2;
        private System.Windows.Forms.Label lblRestAddress2;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label lblPrinterName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtreceiptline1;
        private System.Windows.Forms.Label lblReceiptline1;
        private System.Windows.Forms.TextBox txtreceiptline2;
        private System.Windows.Forms.Label lblReceiptline2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}