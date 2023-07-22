﻿
namespace SmartPOS.Forms
{
    partial class MainSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSetup));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPermissions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "Categorise";
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "Categorise";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Items";
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(128, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 90);
            this.button2.TabIndex = 2;
            this.button2.Text = "Items";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "Payments";
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(12, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 90);
            this.button3.TabIndex = 3;
            this.button3.Text = "Payments";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUser
            // 
            this.btnUser.AccessibleName = "Users";
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUser.Location = new System.Drawing.Point(12, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(110, 90);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Users";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(436, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 90);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPermissions
            // 
            this.btnPermissions.AccessibleName = "Permissions";
            this.btnPermissions.Image = ((System.Drawing.Image)(resources.GetObject("btnPermissions.Image")));
            this.btnPermissions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPermissions.Location = new System.Drawing.Point(128, 12);
            this.btnPermissions.Name = "btnPermissions";
            this.btnPermissions.Size = new System.Drawing.Size(110, 90);
            this.btnPermissions.TabIndex = 6;
            this.btnPermissions.Text = "Permissions";
            this.btnPermissions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPermissions.UseVisualStyleBackColor = true;
            this.btnPermissions.Click += new System.EventHandler(this.btnPermissions_Click);
            // 
            // MainSetup
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 397);
            this.Controls.Add(this.btnPermissions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainSetup";
            this.Text = "MainSetup";
            this.Load += new System.EventHandler(this.MainSetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPermissions;
    }
}