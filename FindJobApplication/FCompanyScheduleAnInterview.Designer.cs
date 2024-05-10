namespace FindJobApplication
{
    partial class FCompanyScheduleAnInterview
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
            this.lblFrom = new Guna.UI.WinForms.GunaLabel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.rtxtCoverLeter = new System.Windows.Forms.RichTextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblSendMail = new Guna.UI.WinForms.GunaLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(20, 133);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 19);
            this.lblFrom.TabIndex = 40;
            this.lblFrom.Text = "Date: ";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(10, 417);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(665, 7);
            this.guna2Separator2.TabIndex = 38;
            // 
            // rtxtCoverLeter
            // 
            this.rtxtCoverLeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtCoverLeter.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtxtCoverLeter.Location = new System.Drawing.Point(27, 216);
            this.rtxtCoverLeter.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtCoverLeter.Name = "rtxtCoverLeter";
            this.rtxtCoverLeter.Size = new System.Drawing.Size(626, 164);
            this.rtxtCoverLeter.TabIndex = 37;
            this.rtxtCoverLeter.Text = "";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(8, 84);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(665, 7);
            this.guna2Separator1.TabIndex = 35;
            // 
            // lblSendMail
            // 
            this.lblSendMail.AutoSize = true;
            this.lblSendMail.Font = new System.Drawing.Font("Inter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSendMail.Location = new System.Drawing.Point(11, 30);
            this.lblSendMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSendMail.Name = "lblSendMail";
            this.lblSendMail.Size = new System.Drawing.Size(319, 34);
            this.lblSendMail.TabIndex = 34;
            this.lblSendMail.Text = "Schedule an interview";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 6;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(92, 119);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(270, 42);
            this.guna2DateTimePicker1.TabIndex = 44;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 4, 18, 21, 33, 33, 535);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(20, 175);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(76, 19);
            this.gunaLabel1.TabIndex = 45;
            this.gunaLabel1.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 6;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.OrangeRed;
            this.btnSend.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverState.FillColor = System.Drawing.Color.Chocolate;
            this.btnSend.Location = new System.Drawing.Point(529, 461);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(126, 45);
            this.btnSend.TabIndex = 46;
            this.btnSend.Text = "Send";
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
            this.btnCancel.Location = new System.Drawing.Point(381, 461);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 45);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FCompanyScheduleAnInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 546);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.rtxtCoverLeter);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblSendMail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCompanyScheduleAnInterview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCompanyScheduleAnInterview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblFrom;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.RichTextBox rtxtCoverLeter;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI.WinForms.GunaLabel lblSendMail;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}