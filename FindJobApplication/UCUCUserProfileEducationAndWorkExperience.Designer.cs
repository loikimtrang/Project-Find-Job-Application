namespace FindJobApplication
{
    partial class UCUCUserProfileEducationAndWorkExperience
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
            this.lblMajor = new Guna.UI.WinForms.GunaLabel();
            this.lblSchool = new Guna.UI.WinForms.GunaLabel();
            this.lblStartDay = new Guna.UI.WinForms.GunaLabel();
            this.lblEndDay = new Guna.UI.WinForms.GunaLabel();
            this.pbDeleteEducationOrWork = new System.Windows.Forms.PictureBox();
            this.pbEditEducationOrWork = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteEducationOrWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditEducationOrWork)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.Location = new System.Drawing.Point(2, 6);
            this.lblMajor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(165, 17);
            this.lblMajor.TabIndex = 0;
            this.lblMajor.Text = "Information technology";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(2, 27);
            this.lblSchool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(400, 19);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "Ho Chi Minh City University of Technology and Education";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(2, 47);
            this.lblStartDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(54, 17);
            this.lblStartDay.TabIndex = 2;
            this.lblStartDay.Text = "9-2022";
            // 
            // lblEndDay
            // 
            this.lblEndDay.AutoSize = true;
            this.lblEndDay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDay.Location = new System.Drawing.Point(109, 47);
            this.lblEndDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(38, 17);
            this.lblEndDay.TabIndex = 3;
            this.lblEndDay.Text = "Now";
            // 
            // pbDeleteEducationOrWork
            // 
            this.pbDeleteEducationOrWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteEducationOrWork.Image = global::FindJobApplication.Properties.Resources.delete;
            this.pbDeleteEducationOrWork.Location = new System.Drawing.Point(519, 6);
            this.pbDeleteEducationOrWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbDeleteEducationOrWork.Name = "pbDeleteEducationOrWork";
            this.pbDeleteEducationOrWork.Size = new System.Drawing.Size(36, 23);
            this.pbDeleteEducationOrWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteEducationOrWork.TabIndex = 5;
            this.pbDeleteEducationOrWork.TabStop = false;
            // 
            // pbEditEducationOrWork
            // 
            this.pbEditEducationOrWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditEducationOrWork.Image = global::FindJobApplication.Properties.Resources.edit1;
            this.pbEditEducationOrWork.Location = new System.Drawing.Point(479, 6);
            this.pbEditEducationOrWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbEditEducationOrWork.Name = "pbEditEducationOrWork";
            this.pbEditEducationOrWork.Size = new System.Drawing.Size(36, 23);
            this.pbEditEducationOrWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditEducationOrWork.TabIndex = 4;
            this.pbEditEducationOrWork.TabStop = false;
            // 
            // UCUCUserProfileEducationAndWorkExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbDeleteEducationOrWork);
            this.Controls.Add(this.pbEditEducationOrWork);
            this.Controls.Add(this.lblEndDay);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblMajor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCUCUserProfileEducationAndWorkExperience";
            this.Size = new System.Drawing.Size(557, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteEducationOrWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditEducationOrWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblMajor;
        private Guna.UI.WinForms.GunaLabel lblSchool;
        private Guna.UI.WinForms.GunaLabel lblStartDay;
        private Guna.UI.WinForms.GunaLabel lblEndDay;
        public System.Windows.Forms.PictureBox pbEditEducationOrWork;
        public System.Windows.Forms.PictureBox pbDeleteEducationOrWork;
    }
}
