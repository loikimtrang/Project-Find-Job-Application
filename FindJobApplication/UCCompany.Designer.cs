namespace FindJobApplication
{
    partial class UCCompany
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
            this.pbCompany = new System.Windows.Forms.PictureBox();
            this.llblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCompany
            // 
            this.pbCompany.Image = global::FindJobApplication.Properties.Resources.Company;
            this.pbCompany.Location = new System.Drawing.Point(49, 32);
            this.pbCompany.Name = "pbCompany";
            this.pbCompany.Size = new System.Drawing.Size(147, 128);
            this.pbCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCompany.TabIndex = 0;
            this.pbCompany.TabStop = false;
            // 
            // llblNameCompany
            // 
            this.llblNameCompany.AutoSize = true;
            this.llblNameCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblNameCompany.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNameCompany.Location = new System.Drawing.Point(238, 32);
            this.llblNameCompany.Name = "llblNameCompany";
            this.llblNameCompany.Size = new System.Drawing.Size(98, 34);
            this.llblNameCompany.TabIndex = 1;
            this.llblNameCompany.TabStop = true;
            this.llblNameCompany.Text = "AXON";
            // 
            // UCCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llblNameCompany);
            this.Controls.Add(this.pbCompany);
            this.Name = "UCCompany";
            this.Size = new System.Drawing.Size(1251, 197);
            ((System.ComponentModel.ISupportInitialize)(this.pbCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCompany;
        private Guna.UI.WinForms.GunaLinkLabel llblNameCompany;
    }
}
