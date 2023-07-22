
namespace SmartPOS.Forms
{
    partial class FormSelect
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDEs = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColDes});
            this.dgvItems.Location = new System.Drawing.Point(12, 73);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(343, 383);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColDes
            // 
            this.ColDes.HeaderText = "Des";
            this.ColDes.Name = "ColDes";
            this.ColDes.ReadOnly = true;
            this.ColDes.Width = 200;
            // 
            // txtDEs
            // 
            this.txtDEs.Location = new System.Drawing.Point(102, 31);
            this.txtDEs.Name = "txtDEs";
            this.txtDEs.Size = new System.Drawing.Size(253, 20);
            this.txtDEs.TabIndex = 1;
            this.txtDEs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDES_KeyUp);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(30, 34);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(29, 13);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "DES";
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 468);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtDEs);
            this.Controls.Add(this.dgvItems);
            this.MinimizeBox = false;
            this.Name = "FormSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Select";
            this.Load += new System.EventHandler(this.FormSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtDEs;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDes;
    }
}