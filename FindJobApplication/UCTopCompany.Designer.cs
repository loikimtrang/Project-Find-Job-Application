namespace FindJobApplication
{
    partial class UCTopCompany
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
            this.pnlListCompany = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlListCompany
            // 
            this.pnlListCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListCompany.AutoScroll = true;
            this.pnlListCompany.Location = new System.Drawing.Point(3, 114);
            this.pnlListCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlListCompany.Name = "pnlListCompany";
            this.pnlListCompany.Size = new System.Drawing.Size(1541, 725);
            this.pnlListCompany.TabIndex = 44;
            // 
            // UCTopCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlListCompany);
            this.Name = "UCTopCompany";
            this.Size = new System.Drawing.Size(1547, 830);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlListCompany;
    }
}
