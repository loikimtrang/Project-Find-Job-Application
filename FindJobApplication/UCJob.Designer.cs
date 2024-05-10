namespace FindJobApplication
{
    partial class UCJob
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
            this.pnlJob = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.pnlSkill = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.pnlPicture = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pBCompany = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lLblNameJob = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pnlJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlJob
            // 
            this.pnlJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlJob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlJob.BorderRadius = 24;
            this.pnlJob.BorderThickness = 1;
            this.pnlJob.Controls.Add(this.btnSave);
            this.pnlJob.Controls.Add(this.pnlSkill);
            this.pnlJob.Controls.Add(this.pictureBox1);
            this.pnlJob.Controls.Add(this.lblSalary);
            this.pnlJob.Controls.Add(this.pnlPicture);
            this.pnlJob.Controls.Add(this.lLblNameJob);
            this.pnlJob.Controls.Add(this.lblNameCompany);
            this.pnlJob.Controls.Add(this.lblLocation);
            this.pnlJob.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pnlJob.Location = new System.Drawing.Point(0, 0);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Padding = new System.Windows.Forms.Padding(12);
            this.pnlJob.Size = new System.Drawing.Size(521, 204);
            this.pnlJob.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.Image = global::FindJobApplication.Properties.Resources.heart21;
            this.btnSave.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnSave.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnSave.Image = global::FindJobApplication.Properties.Resources.like;
            this.btnSave.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.ImageRotate = 0F;
            this.btnSave.ImageSize = new System.Drawing.Size(36, 36);
            this.btnSave.Location = new System.Drawing.Point(461, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnSave.Size = new System.Drawing.Size(45, 41);
            this.btnSave.TabIndex = 42;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlSkill
            // 
            this.pnlSkill.Location = new System.Drawing.Point(208, 158);
            this.pnlSkill.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSkill.Name = "pnlSkill";
            this.pnlSkill.Size = new System.Drawing.Size(233, 36);
            this.pnlSkill.TabIndex = 41;
            this.pnlSkill.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindJobApplication.Properties.Resources.location_dot_solid;
            this.pictureBox1.Location = new System.Drawing.Point(208, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalary.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(181)))), ((int)(((byte)(27)))));
            this.lblSalary.Location = new System.Drawing.Point(441, 12);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSalary.Size = new System.Drawing.Size(78, 19);
            this.lblSalary.TabIndex = 31;
            this.lblSalary.Text = "$ 10000";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPicture
            // 
            this.pnlPicture.BackColor = System.Drawing.Color.White;
            this.pnlPicture.BorderRadius = 12;
            this.pnlPicture.BorderThickness = 1;
            this.pnlPicture.Controls.Add(this.pBCompany);
            this.pnlPicture.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlPicture.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.pnlPicture.Location = new System.Drawing.Point(15, 12);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(180, 180);
            this.pnlPicture.TabIndex = 29;
            // 
            // pBCompany
            // 
            this.pBCompany.BackColor = System.Drawing.Color.Transparent;
            this.pBCompany.BorderRadius = 12;
            this.pBCompany.Image = global::FindJobApplication.Properties.Resources.fpt_logo1;
            this.pBCompany.ImageRotate = 0F;
            this.pBCompany.Location = new System.Drawing.Point(0, 0);
            this.pBCompany.Margin = new System.Windows.Forms.Padding(0);
            this.pBCompany.Name = "pBCompany";
            this.pBCompany.Size = new System.Drawing.Size(180, 180);
            this.pBCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCompany.TabIndex = 2;
            this.pBCompany.TabStop = false;
            // 
            // lLblNameJob
            // 
            this.lLblNameJob.AutoSize = true;
            this.lLblNameJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLblNameJob.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lLblNameJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lLblNameJob.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lLblNameJob.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lLblNameJob.Location = new System.Drawing.Point(208, 12);
            this.lLblNameJob.Margin = new System.Windows.Forms.Padding(0);
            this.lLblNameJob.Name = "lLblNameJob";
            this.lLblNameJob.Size = new System.Drawing.Size(63, 29);
            this.lLblNameJob.TabIndex = 34;
            this.lLblNameJob.TabStop = true;
            this.lLblNameJob.Text = "Title";
            this.lLblNameJob.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblNameJob_LinkClicked);
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameCompany.Font = new System.Drawing.Font("Inter SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNameCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblNameCompany.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lblNameCompany.Location = new System.Drawing.Point(208, 70);
            this.lblNameCompany.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(136, 19);
            this.lblNameCompany.TabIndex = 37;
            this.lblNameCompany.TabStop = true;
            this.lblNameCompany.Text = "FPT Corporation";
            this.lblNameCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNameCompany_LinkClicked);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Black;
            this.lblLocation.Location = new System.Drawing.Point(225, 118);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(102, 19);
            this.lblLocation.TabIndex = 36;
            this.lblLocation.Text = "Ho Chi Minh";
            // 
            // UCJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlJob);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.Name = "UCJob";
            this.Size = new System.Drawing.Size(521, 204);
            this.pnlJob.ResumeLayout(false);
            this.pnlJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlJob;
        private System.Windows.Forms.Label lblSalary;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPicture;
        private Guna.UI2.WinForms.Guna2PictureBox pBCompany;
        private Guna.UI.WinForms.GunaLinkLabel lLblNameJob;
        private Guna.UI.WinForms.GunaLinkLabel lblNameCompany;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlSkill;
        private Guna.UI2.WinForms.Guna2ImageCheckBox btnSave;
    }
}
