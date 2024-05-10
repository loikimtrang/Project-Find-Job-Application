namespace FindJobApplication
{
    partial class FUserSubmitCV
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
            this.pnlLinkCv = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChooseFile = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnNewCv = new System.Windows.Forms.RadioButton();
            this.rBtnCurrentCv = new System.Windows.Forms.RadioButton();
            this.lblTip1 = new Guna.UI.WinForms.GunaLabel();
            this.lblTip = new Guna.UI.WinForms.GunaLabel();
            this.rtxtCoverLeter = new System.Windows.Forms.RichTextBox();
            this.lblCoverLetter = new Guna.UI.WinForms.GunaLabel();
            this.lblYourCv = new Guna.UI.WinForms.GunaLabel();
            this.lblNameJob = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlLinkCv.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLinkCv
            // 
            this.pnlLinkCv.Controls.Add(this.btnChooseFile);
            this.pnlLinkCv.Controls.Add(this.rbtnNewCv);
            this.pnlLinkCv.Controls.Add(this.rBtnCurrentCv);
            this.pnlLinkCv.Location = new System.Drawing.Point(35, 214);
            this.pnlLinkCv.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLinkCv.Name = "pnlLinkCv";
            this.pnlLinkCv.Size = new System.Drawing.Size(618, 104);
            this.pnlLinkCv.TabIndex = 61;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BorderRadius = 6;
            this.btnChooseFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseFile.FillColor = System.Drawing.Color.LightGray;
            this.btnChooseFile.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.Black;
            this.btnChooseFile.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnChooseFile.Location = new System.Drawing.Point(176, 62);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(94, 24);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Choose file";
            // 
            // rbtnNewCv
            // 
            this.rbtnNewCv.AutoSize = true;
            this.rbtnNewCv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rbtnNewCv.Location = new System.Drawing.Point(11, 62);
            this.rbtnNewCv.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnNewCv.Name = "rbtnNewCv";
            this.rbtnNewCv.Size = new System.Drawing.Size(145, 24);
            this.rbtnNewCv.TabIndex = 1;
            this.rbtnNewCv.TabStop = true;
            this.rbtnNewCv.Text = "Upload new CV";
            this.rbtnNewCv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnNewCv.UseVisualStyleBackColor = true;
            // 
            // rBtnCurrentCv
            // 
            this.rBtnCurrentCv.AutoSize = true;
            this.rBtnCurrentCv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rBtnCurrentCv.Location = new System.Drawing.Point(11, 22);
            this.rBtnCurrentCv.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnCurrentCv.Name = "rBtnCurrentCv";
            this.rBtnCurrentCv.Size = new System.Drawing.Size(174, 24);
            this.rBtnCurrentCv.TabIndex = 0;
            this.rBtnCurrentCv.TabStop = true;
            this.rBtnCurrentCv.Text = "Use your current CV";
            this.rBtnCurrentCv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnCurrentCv.UseVisualStyleBackColor = true;
            // 
            // lblTip1
            // 
            this.lblTip1.AutoSize = true;
            this.lblTip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip1.ForeColor = System.Drawing.Color.Red;
            this.lblTip1.Location = new System.Drawing.Point(30, 290);
            this.lblTip1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip1.Name = "lblTip1";
            this.lblTip1.Size = new System.Drawing.Size(45, 19);
            this.lblTip1.TabIndex = 60;
            this.lblTip1.Text = "Tips: ";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Inter Italic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(81, 369);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(527, 19);
            this.lblTip.TabIndex = 59;
            this.lblTip.Text = "What skills, work projects or achievements make you a strong candidate?";
            // 
            // rtxtCoverLeter
            // 
            this.rtxtCoverLeter.BackColor = System.Drawing.Color.White;
            this.rtxtCoverLeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtCoverLeter.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCoverLeter.Location = new System.Drawing.Point(34, 407);
            this.rtxtCoverLeter.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtCoverLeter.Name = "rtxtCoverLeter";
            this.rtxtCoverLeter.Size = new System.Drawing.Size(619, 177);
            this.rtxtCoverLeter.TabIndex = 58;
            this.rtxtCoverLeter.Text = "";
            // 
            // lblCoverLetter
            // 
            this.lblCoverLetter.AutoSize = true;
            this.lblCoverLetter.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCoverLetter.Location = new System.Drawing.Point(30, 340);
            this.lblCoverLetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoverLetter.Name = "lblCoverLetter";
            this.lblCoverLetter.Size = new System.Drawing.Size(156, 29);
            this.lblCoverLetter.TabIndex = 57;
            this.lblCoverLetter.Text = "Cover Letter";
            // 
            // lblYourCv
            // 
            this.lblYourCv.AutoSize = true;
            this.lblYourCv.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblYourCv.Location = new System.Drawing.Point(30, 167);
            this.lblYourCv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourCv.Name = "lblYourCv";
            this.lblYourCv.Size = new System.Drawing.Size(104, 29);
            this.lblYourCv.TabIndex = 56;
            this.lblYourCv.Text = "Your CV";
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoSize = true;
            this.lblNameJob.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNameJob.Location = new System.Drawing.Point(30, 123);
            this.lblNameJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(447, 29);
            this.lblNameJob.TabIndex = 55;
            this.lblNameJob.Text = "Lead Software Engineers (Java, AWS)";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Inter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(14, 34);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(162, 34);
            this.gunaLabel1.TabIndex = 66;
            this.gunaLabel1.Text = "Submit CV";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(8, 95);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(665, 7);
            this.guna2Separator1.TabIndex = 65;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnCancel.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(379, 638);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 45);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 6;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.OrangeRed;
            this.btnSubmit.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.Chocolate;
            this.btnSubmit.Location = new System.Drawing.Point(527, 638);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 45);
            this.btnSubmit.TabIndex = 63;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSendCv_Click);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(7, 607);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(665, 7);
            this.guna2Separator3.TabIndex = 62;
            // 
            // FUserSubmitCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 717);
            this.Controls.Add(this.pnlLinkCv);
            this.Controls.Add(this.lblTip1);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.rtxtCoverLeter);
            this.Controls.Add(this.lblCoverLetter);
            this.Controls.Add(this.lblYourCv);
            this.Controls.Add(this.lblNameJob);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.guna2Separator3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FUserSubmitCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit CV";
            this.pnlLinkCv.ResumeLayout(false);
            this.pnlLinkCv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLinkCv;
        private Guna.UI2.WinForms.Guna2Button btnChooseFile;
        private System.Windows.Forms.RadioButton rbtnNewCv;
        private System.Windows.Forms.RadioButton rBtnCurrentCv;
        private Guna.UI.WinForms.GunaLabel lblTip1;
        private Guna.UI.WinForms.GunaLabel lblTip;
        private System.Windows.Forms.RichTextBox rtxtCoverLeter;
        private Guna.UI.WinForms.GunaLabel lblCoverLetter;
        private Guna.UI.WinForms.GunaLabel lblYourCv;
        private Guna.UI.WinForms.GunaLabel lblNameJob;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
    }
}