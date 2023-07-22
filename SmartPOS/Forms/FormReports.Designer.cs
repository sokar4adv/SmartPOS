
namespace SmartPOS.Forms
{
    partial class FormReports
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
            this.mainReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // mainReport
            // 
            this.mainReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainReport.Location = new System.Drawing.Point(0, 0);
            this.mainReport.Name = "mainReport";
            this.mainReport.ServerReport.BearerToken = null;
            this.mainReport.Size = new System.Drawing.Size(908, 545);
            this.mainReport.TabIndex = 0;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 545);
            this.Controls.Add(this.mainReport);
            this.MinimizeBox = false;
            this.Name = "FormReports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer mainReport;
    }
}