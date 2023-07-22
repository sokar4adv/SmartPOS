
namespace SmartPOS.Forms
{
    partial class FormPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPermissions));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.cmbxUsers = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlPermissions = new System.Windows.Forms.Panel();
            this.chbxOptions = new System.Windows.Forms.CheckBox();
            this.chbxReports = new System.Windows.Forms.CheckBox();
            this.chbxSetUp = new System.Windows.Forms.CheckBox();
            this.chbxPointPofSale = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chbxTablesView = new System.Windows.Forms.CheckBox();
            this.chbxOpenChecks = new System.Windows.Forms.CheckBox();
            this.chbxPOSChecks = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chbxTaxs = new System.Windows.Forms.CheckBox();
            this.chbxItems = new System.Windows.Forms.CheckBox();
            this.chbxPermissions = new System.Windows.Forms.CheckBox();
            this.chbxTables = new System.Windows.Forms.CheckBox();
            this.chbxPayments = new System.Windows.Forms.CheckBox();
            this.chbxCategorise = new System.Windows.Forms.CheckBox();
            this.chbxUsers = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chbxSaleReport = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chbxOptionsSave = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.pnlPermissions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripSeparator2,
            this.btnCheckAll,
            this.btnRemoveAll,
            this.toolStripSeparator3,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(601, 68);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 65);
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Image")));
            this.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(61, 65);
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAll.Image")));
            this.btnRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(71, 65);
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 68);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 65);
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbxUsers
            // 
            this.cmbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUsers.FormattingEnabled = true;
            this.cmbxUsers.Location = new System.Drawing.Point(64, 85);
            this.cmbxUsers.Name = "cmbxUsers";
            this.cmbxUsers.Size = new System.Drawing.Size(171, 21);
            this.cmbxUsers.TabIndex = 2;
            this.cmbxUsers.SelectedIndexChanged += new System.EventHandler(this.cmbxUsers_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 88);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPermissions.Controls.Add(this.chbxOptions);
            this.pnlPermissions.Controls.Add(this.chbxReports);
            this.pnlPermissions.Controls.Add(this.chbxSetUp);
            this.pnlPermissions.Controls.Add(this.chbxPointPofSale);
            this.pnlPermissions.Controls.Add(this.tabControl1);
            this.pnlPermissions.Location = new System.Drawing.Point(12, 121);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(577, 302);
            this.pnlPermissions.TabIndex = 4;
            // 
            // chbxOptions
            // 
            this.chbxOptions.AccessibleDescription = "Main";
            this.chbxOptions.AccessibleName = "Options";
            this.chbxOptions.AutoSize = true;
            this.chbxOptions.Location = new System.Drawing.Point(271, 17);
            this.chbxOptions.Name = "chbxOptions";
            this.chbxOptions.Size = new System.Drawing.Size(63, 17);
            this.chbxOptions.TabIndex = 4;
            this.chbxOptions.Text = "Options";
            this.chbxOptions.UseVisualStyleBackColor = true;
            // 
            // chbxReports
            // 
            this.chbxReports.AccessibleDescription = "Main";
            this.chbxReports.AccessibleName = "Reports";
            this.chbxReports.AutoSize = true;
            this.chbxReports.Location = new System.Drawing.Point(183, 17);
            this.chbxReports.Name = "chbxReports";
            this.chbxReports.Size = new System.Drawing.Size(64, 17);
            this.chbxReports.TabIndex = 3;
            this.chbxReports.Text = "Reports";
            this.chbxReports.UseVisualStyleBackColor = true;
            // 
            // chbxSetUp
            // 
            this.chbxSetUp.AccessibleDescription = "Main";
            this.chbxSetUp.AccessibleName = "Setup";
            this.chbxSetUp.AutoSize = true;
            this.chbxSetUp.Location = new System.Drawing.Point(95, 17);
            this.chbxSetUp.Name = "chbxSetUp";
            this.chbxSetUp.Size = new System.Drawing.Size(54, 17);
            this.chbxSetUp.TabIndex = 2;
            this.chbxSetUp.Text = "Setup";
            this.chbxSetUp.UseVisualStyleBackColor = true;
            // 
            // chbxPointPofSale
            // 
            this.chbxPointPofSale.AccessibleDescription = "Main";
            this.chbxPointPofSale.AccessibleName = "PointPofSale";
            this.chbxPointPofSale.AutoSize = true;
            this.chbxPointPofSale.Location = new System.Drawing.Point(7, 17);
            this.chbxPointPofSale.Name = "chbxPointPofSale";
            this.chbxPointPofSale.Size = new System.Drawing.Size(82, 17);
            this.chbxPointPofSale.TabIndex = 0;
            this.chbxPointPofSale.Text = "PointOfSale";
            this.chbxPointPofSale.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 245);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbxTablesView);
            this.tabPage1.Controls.Add(this.chbxOpenChecks);
            this.tabPage1.Controls.Add(this.chbxPOSChecks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Point Of Sale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chbxTablesView
            // 
            this.chbxTablesView.AccessibleDescription = "PointPofSale";
            this.chbxTablesView.AccessibleName = "TablesView";
            this.chbxTablesView.AutoSize = true;
            this.chbxTablesView.Location = new System.Drawing.Point(39, 97);
            this.chbxTablesView.Name = "chbxTablesView";
            this.chbxTablesView.Size = new System.Drawing.Size(82, 17);
            this.chbxTablesView.TabIndex = 3;
            this.chbxTablesView.Text = "Tables View";
            this.chbxTablesView.UseVisualStyleBackColor = true;
            // 
            // chbxOpenChecks
            // 
            this.chbxOpenChecks.AccessibleDescription = "PointPofSale";
            this.chbxOpenChecks.AccessibleName = "OpenChecks";
            this.chbxOpenChecks.AutoSize = true;
            this.chbxOpenChecks.Location = new System.Drawing.Point(39, 63);
            this.chbxOpenChecks.Name = "chbxOpenChecks";
            this.chbxOpenChecks.Size = new System.Drawing.Size(89, 17);
            this.chbxOpenChecks.TabIndex = 2;
            this.chbxOpenChecks.Text = "Open Checks";
            this.chbxOpenChecks.UseVisualStyleBackColor = true;
            // 
            // chbxPOSChecks
            // 
            this.chbxPOSChecks.AccessibleDescription = "PointPofSale";
            this.chbxPOSChecks.AccessibleName = "POSChecks";
            this.chbxPOSChecks.AutoSize = true;
            this.chbxPOSChecks.Location = new System.Drawing.Point(39, 28);
            this.chbxPOSChecks.Name = "chbxPOSChecks";
            this.chbxPOSChecks.Size = new System.Drawing.Size(125, 17);
            this.chbxPOSChecks.TabIndex = 1;
            this.chbxPOSChecks.Text = "Point Of Sale Checks";
            this.chbxPOSChecks.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chbxTaxs);
            this.tabPage2.Controls.Add(this.chbxItems);
            this.tabPage2.Controls.Add(this.chbxPermissions);
            this.tabPage2.Controls.Add(this.chbxTables);
            this.tabPage2.Controls.Add(this.chbxPayments);
            this.tabPage2.Controls.Add(this.chbxCategorise);
            this.tabPage2.Controls.Add(this.chbxUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chbxTaxs
            // 
            this.chbxTaxs.AccessibleDescription = "Setup";
            this.chbxTaxs.AccessibleName = "Taxs";
            this.chbxTaxs.AutoSize = true;
            this.chbxTaxs.Location = new System.Drawing.Point(238, 98);
            this.chbxTaxs.Name = "chbxTaxs";
            this.chbxTaxs.Size = new System.Drawing.Size(49, 17);
            this.chbxTaxs.TabIndex = 10;
            this.chbxTaxs.Text = "Taxs";
            this.chbxTaxs.UseVisualStyleBackColor = true;
            // 
            // chbxItems
            // 
            this.chbxItems.AccessibleDescription = "Setup";
            this.chbxItems.AccessibleName = "Items";
            this.chbxItems.AutoSize = true;
            this.chbxItems.Location = new System.Drawing.Point(238, 63);
            this.chbxItems.Name = "chbxItems";
            this.chbxItems.Size = new System.Drawing.Size(53, 17);
            this.chbxItems.TabIndex = 9;
            this.chbxItems.Text = "Items";
            this.chbxItems.UseVisualStyleBackColor = true;
            // 
            // chbxPermissions
            // 
            this.chbxPermissions.AccessibleDescription = "Setup";
            this.chbxPermissions.AccessibleName = "Permissions";
            this.chbxPermissions.AutoSize = true;
            this.chbxPermissions.Location = new System.Drawing.Point(238, 29);
            this.chbxPermissions.Name = "chbxPermissions";
            this.chbxPermissions.Size = new System.Drawing.Size(106, 17);
            this.chbxPermissions.TabIndex = 8;
            this.chbxPermissions.Text = "User Permissions";
            this.chbxPermissions.UseVisualStyleBackColor = true;
            // 
            // chbxTables
            // 
            this.chbxTables.AccessibleDescription = "Setup";
            this.chbxTables.AccessibleName = "Tables";
            this.chbxTables.AutoSize = true;
            this.chbxTables.Location = new System.Drawing.Point(39, 133);
            this.chbxTables.Name = "chbxTables";
            this.chbxTables.Size = new System.Drawing.Size(57, 17);
            this.chbxTables.TabIndex = 7;
            this.chbxTables.Text = "Tables";
            this.chbxTables.UseVisualStyleBackColor = true;
            // 
            // chbxPayments
            // 
            this.chbxPayments.AccessibleDescription = "Setup";
            this.chbxPayments.AccessibleName = "Payments";
            this.chbxPayments.AutoSize = true;
            this.chbxPayments.Location = new System.Drawing.Point(39, 97);
            this.chbxPayments.Name = "chbxPayments";
            this.chbxPayments.Size = new System.Drawing.Size(73, 17);
            this.chbxPayments.TabIndex = 6;
            this.chbxPayments.Text = "Payments";
            this.chbxPayments.UseVisualStyleBackColor = true;
            // 
            // chbxCategorise
            // 
            this.chbxCategorise.AccessibleDescription = "Setup";
            this.chbxCategorise.AccessibleName = "Categorise";
            this.chbxCategorise.AutoSize = true;
            this.chbxCategorise.Location = new System.Drawing.Point(39, 63);
            this.chbxCategorise.Name = "chbxCategorise";
            this.chbxCategorise.Size = new System.Drawing.Size(78, 17);
            this.chbxCategorise.TabIndex = 5;
            this.chbxCategorise.Text = "Categorise";
            this.chbxCategorise.UseVisualStyleBackColor = true;
            // 
            // chbxUsers
            // 
            this.chbxUsers.AccessibleDescription = "Setup";
            this.chbxUsers.AccessibleName = "Users";
            this.chbxUsers.AutoSize = true;
            this.chbxUsers.Location = new System.Drawing.Point(39, 28);
            this.chbxUsers.Name = "chbxUsers";
            this.chbxUsers.Size = new System.Drawing.Size(53, 17);
            this.chbxUsers.TabIndex = 4;
            this.chbxUsers.Text = "Users";
            this.chbxUsers.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chbxSaleReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(559, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chbxSaleReport
            // 
            this.chbxSaleReport.AccessibleDescription = "Reports";
            this.chbxSaleReport.AccessibleName = "SaleReport";
            this.chbxSaleReport.AutoSize = true;
            this.chbxSaleReport.Location = new System.Drawing.Point(39, 28);
            this.chbxSaleReport.Name = "chbxSaleReport";
            this.chbxSaleReport.Size = new System.Drawing.Size(82, 17);
            this.chbxSaleReport.TabIndex = 11;
            this.chbxSaleReport.Text = "Sale Report";
            this.chbxSaleReport.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chbxOptionsSave);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(559, 219);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chbxOptionsSave
            // 
            this.chbxOptionsSave.AccessibleDescription = "Options";
            this.chbxOptionsSave.AccessibleName = "OptionsSave";
            this.chbxOptionsSave.AutoSize = true;
            this.chbxOptionsSave.Location = new System.Drawing.Point(39, 28);
            this.chbxOptionsSave.Name = "chbxOptionsSave";
            this.chbxOptionsSave.Size = new System.Drawing.Size(50, 17);
            this.chbxOptionsSave.TabIndex = 12;
            this.chbxOptionsSave.Text = "Save";
            this.chbxOptionsSave.UseVisualStyleBackColor = true;
            // 
            // FormPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 435);
            this.Controls.Add(this.pnlPermissions);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbxUsers);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "FormPermissions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPermissions";
            this.Load += new System.EventHandler(this.FormPermissions_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCheckAll;
        private System.Windows.Forms.ToolStripButton btnRemoveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ComboBox cmbxUsers;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlPermissions;
        private System.Windows.Forms.CheckBox chbxOptions;
        private System.Windows.Forms.CheckBox chbxReports;
        private System.Windows.Forms.CheckBox chbxSetUp;
        private System.Windows.Forms.CheckBox chbxPointPofSale;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chbxOpenChecks;
        private System.Windows.Forms.CheckBox chbxPOSChecks;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox chbxTablesView;
        private System.Windows.Forms.CheckBox chbxTaxs;
        private System.Windows.Forms.CheckBox chbxItems;
        private System.Windows.Forms.CheckBox chbxPermissions;
        private System.Windows.Forms.CheckBox chbxTables;
        private System.Windows.Forms.CheckBox chbxPayments;
        private System.Windows.Forms.CheckBox chbxCategorise;
        private System.Windows.Forms.CheckBox chbxUsers;
        private System.Windows.Forms.CheckBox chbxSaleReport;
        private System.Windows.Forms.CheckBox chbxOptionsSave;
    }
}