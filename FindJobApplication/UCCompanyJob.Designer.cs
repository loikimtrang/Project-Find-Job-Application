namespace FindJobApplication
{
    partial class UCCompanyJob
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
            this.lblCountApplied = new Guna.UI.WinForms.GunaLinkLabel();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pBDelete = new System.Windows.Forms.PictureBox();
            this.pnTupleTableJob = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblPostDate = new System.Windows.Forms.Label();
            this.lblNameJob = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDelete)).BeginInit();
            this.pnTupleTableJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountApplied
            // 
            this.lblCountApplied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountApplied.AutoSize = true;
            this.lblCountApplied.BackColor = System.Drawing.Color.White;
            this.lblCountApplied.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCountApplied.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCountApplied.Location = new System.Drawing.Point(955, 13);
            this.lblCountApplied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountApplied.Name = "lblCountApplied";
            this.lblCountApplied.Size = new System.Drawing.Size(69, 25);
            this.lblCountApplied.TabIndex = 18;
            this.lblCountApplied.TabStop = true;
            this.lblCountApplied.Text = "count";
            this.lblCountApplied.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCountApplied_LinkClicked);
            // 
            // pbEdit
            // 
            this.pbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEdit.BackColor = System.Drawing.Color.White;
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::FindJobApplication.Properties.Resources.edit1;
            this.pbEdit.Location = new System.Drawing.Point(1096, 10);
            this.pbEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(30, 30);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 5;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // pBDelete
            // 
            this.pBDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBDelete.BackColor = System.Drawing.Color.White;
            this.pBDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBDelete.Image = global::FindJobApplication.Properties.Resources.delete;
            this.pBDelete.Location = new System.Drawing.Point(1042, 10);
            this.pBDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pBDelete.Name = "pBDelete";
            this.pBDelete.Size = new System.Drawing.Size(30, 30);
            this.pBDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDelete.TabIndex = 4;
            this.pBDelete.TabStop = false;
            this.pBDelete.Click += new System.EventHandler(this.pBDelete_Click);
            // 
            // pnTupleTableJob
            // 
            this.pnTupleTableJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTupleTableJob.BackColor = System.Drawing.Color.Transparent;
            this.pnTupleTableJob.BorderRadius = 10;
            this.pnTupleTableJob.Controls.Add(this.pbEdit);
            this.pnTupleTableJob.Controls.Add(this.lblCountApplied);
            this.pnTupleTableJob.Controls.Add(this.pBDelete);
            this.pnTupleTableJob.Controls.Add(this.lblSalary);
            this.pnTupleTableJob.Controls.Add(this.lblExpirationDate);
            this.pnTupleTableJob.Controls.Add(this.lblPostDate);
            this.pnTupleTableJob.Controls.Add(this.lblNameJob);
            this.pnTupleTableJob.Controls.Add(this.lblId);
            this.pnTupleTableJob.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.pnTupleTableJob.Location = new System.Drawing.Point(3, 7);
            this.pnTupleTableJob.Name = "pnTupleTableJob";
            this.pnTupleTableJob.Size = new System.Drawing.Size(1140, 50);
            this.pnTupleTableJob.TabIndex = 2;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(830, 13);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(74, 25);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Salary";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(605, 13);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(140, 25);
            this.lblExpirationDate.TabIndex = 6;
            this.lblExpirationDate.Text = "Expired Date";
            // 
            // lblPostDate
            // 
            this.lblPostDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostDate.AutoSize = true;
            this.lblPostDate.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPostDate.Location = new System.Drawing.Point(385, 13);
            this.lblPostDate.Name = "lblPostDate";
            this.lblPostDate.Size = new System.Drawing.Size(110, 25);
            this.lblPostDate.TabIndex = 4;
            this.lblPostDate.Text = "Post Date";
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoSize = true;
            this.lblNameJob.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNameJob.Location = new System.Drawing.Point(65, 13);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(55, 25);
            this.lblNameJob.TabIndex = 2;
            this.lblNameJob.Text = "Title";
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
            // UCCompanyJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnTupleTableJob);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "UCCompanyJob";
            this.Size = new System.Drawing.Size(1147, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDelete)).EndInit();
            this.pnTupleTableJob.ResumeLayout(false);
            this.pnTupleTableJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pBDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private Guna.UI.WinForms.GunaLinkLabel lblCountApplied;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnTupleTableJob;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblPostDate;
        private System.Windows.Forms.Label lblNameJob;
        private System.Windows.Forms.Label lblId;
    }
}
