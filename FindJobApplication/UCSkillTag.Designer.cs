namespace FindJobApplication
{
    partial class UCSkillTag
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
            this.btnSkill = new Guna.UI2.WinForms.Guna2Button();
            this.pBDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkill
            // 
            this.btnSkill.BackColor = System.Drawing.Color.Transparent;
            this.btnSkill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnSkill.BorderRadius = 15;
            this.btnSkill.BorderThickness = 1;
            this.btnSkill.DefaultAutoSize = true;
            this.btnSkill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnSkill.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSkill.ForeColor = System.Drawing.Color.Black;
            this.btnSkill.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSkill.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSkill.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSkill.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSkill.Location = new System.Drawing.Point(0, 0);
            this.btnSkill.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnSkill.Name = "btnSkill";
            this.btnSkill.Size = new System.Drawing.Size(96, 28);
            this.btnSkill.TabIndex = 0;
            this.btnSkill.Text = "Back-end";
            // 
            // pBDelete
            // 
            this.pBDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pBDelete.Enabled = false;
            this.pBDelete.Image = global::FindJobApplication.Properties.Resources.Xoa;
            this.pBDelete.Location = new System.Drawing.Point(102, 0);
            this.pBDelete.Margin = new System.Windows.Forms.Padding(0);
            this.pBDelete.Name = "pBDelete";
            this.pBDelete.Size = new System.Drawing.Size(23, 28);
            this.pBDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDelete.TabIndex = 1;
            this.pBDelete.TabStop = false;
            this.pBDelete.Visible = false;
            this.pBDelete.Click += new System.EventHandler(this.pBDelete_Click);
            // 
            // UCSkillTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pBDelete);
            this.Controls.Add(this.btnSkill);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCSkillTag";
            this.Size = new System.Drawing.Size(125, 28);
            ((System.ComponentModel.ISupportInitialize)(this.pBDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSkill;
        private System.Windows.Forms.PictureBox pBDelete;
    }
}
