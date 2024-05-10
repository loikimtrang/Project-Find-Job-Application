namespace FindJobApplication
{
    partial class UCCompanyPeopleApplied
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
            this.pbSeeDetail = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDayApply = new System.Windows.Forms.Label();
            this.lblNamePeople = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSeeDetail
            // 
            this.pbSeeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSeeDetail.BackColor = System.Drawing.Color.White;
            this.pbSeeDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSeeDetail.Image = global::FindJobApplication.Properties.Resources.eyeDetail;
            this.pbSeeDetail.Location = new System.Drawing.Point(1075, 10);
            this.pbSeeDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pbSeeDetail.Name = "pbSeeDetail";
            this.pbSeeDetail.Size = new System.Drawing.Size(30, 30);
            this.pbSeeDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeeDetail.TabIndex = 18;
            this.pbSeeDetail.TabStop = false;
            this.pbSeeDetail.Click += new System.EventHandler(this.pbSeeDetail_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.pbSeeDetail);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblStatus);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblDayApply);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblNamePeople);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblId);
            this.guna2CustomGradientPanel2.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 5);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1140, 50);
            this.guna2CustomGradientPanel2.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(745, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblDayApply
            // 
            this.lblDayApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayApply.AutoSize = true;
            this.lblDayApply.BackColor = System.Drawing.Color.Transparent;
            this.lblDayApply.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDayApply.Location = new System.Drawing.Point(385, 13);
            this.lblDayApply.Name = "lblDayApply";
            this.lblDayApply.Size = new System.Drawing.Size(110, 25);
            this.lblDayApply.TabIndex = 4;
            this.lblDayApply.Text = "Post Date";
            // 
            // lblNamePeople
            // 
            this.lblNamePeople.AutoSize = true;
            this.lblNamePeople.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNamePeople.Location = new System.Drawing.Point(65, 13);
            this.lblNamePeople.Name = "lblNamePeople";
            this.lblNamePeople.Size = new System.Drawing.Size(70, 25);
            this.lblNamePeople.TabIndex = 2;
            this.lblNamePeople.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(21, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // UCCompanyPeopleApplied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCCompanyPeopleApplied";
            this.Size = new System.Drawing.Size(1145, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSeeDetail;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDayApply;
        private System.Windows.Forms.Label lblNamePeople;
        private System.Windows.Forms.Label lblId;
    }
}
