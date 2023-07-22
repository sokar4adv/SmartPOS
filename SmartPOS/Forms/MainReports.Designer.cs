
namespace SmartPOS.Forms
{
    partial class MainReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReports));
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaleDetailsReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.AccessibleName = "SaleReport";
            this.btnSaleReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleReport.Image")));
            this.btnSaleReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaleReport.Location = new System.Drawing.Point(12, 12);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(110, 90);
            this.btnSaleReport.TabIndex = 1;
            this.btnSaleReport.Text = "Sale Report";
            this.btnSaleReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaleReport.UseVisualStyleBackColor = true;
            this.btnSaleReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(436, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 90);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaleDetailsReport
            // 
            this.btnSaleDetailsReport.AccessibleName = "SaleReport";
            this.btnSaleDetailsReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleDetailsReport.Image")));
            this.btnSaleDetailsReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaleDetailsReport.Location = new System.Drawing.Point(128, 12);
            this.btnSaleDetailsReport.Name = "btnSaleDetailsReport";
            this.btnSaleDetailsReport.Size = new System.Drawing.Size(110, 90);
            this.btnSaleDetailsReport.TabIndex = 3;
            this.btnSaleDetailsReport.Text = "Details Report";
            this.btnSaleDetailsReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaleDetailsReport.UseVisualStyleBackColor = true;
            this.btnSaleDetailsReport.Click += new System.EventHandler(this.btnSaleDetailsReport_Click);
            // 
            // MainReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 397);
            this.Controls.Add(this.btnSaleDetailsReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaleReport);
            this.Name = "MainReports";
            this.Text = "MainReports";
            this.Load += new System.EventHandler(this.MainReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaleReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaleDetailsReport;
    }
}