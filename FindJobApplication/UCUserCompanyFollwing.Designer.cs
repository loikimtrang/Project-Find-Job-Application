namespace FindJobApplication
{
    partial class UCUserCompanyFollwing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.llblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblNameCompany
            // 
            this.llblNameCompany.AutoSize = true;
            this.llblNameCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblNameCompany.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.llblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNameCompany.Location = new System.Drawing.Point(65, 13);
            this.llblNameCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblNameCompany.Name = "llblNameCompany";
            this.llblNameCompany.Size = new System.Drawing.Size(107, 25);
            this.llblNameCompany.TabIndex = 18;
            this.llblNameCompany.TabStop = true;
            this.llblNameCompany.Text = "Company";
            this.llblNameCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNameCompany_LinkClicked);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.llblNameCompany);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblID);
            this.guna2CustomGradientPanel2.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 6);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1140, 50);
            this.guna2CustomGradientPanel2.TabIndex = 47;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // UCUserCompanyFollwing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCUserCompanyFollwing";
            this.Size = new System.Drawing.Size(1147, 64);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLinkLabel llblNameCompany;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label lblID;
    }
}
