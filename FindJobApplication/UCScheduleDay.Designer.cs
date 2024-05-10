namespace FindJobApplication
{
    partial class UCScheduleDay
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
            this.pnlDay = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblDay = new System.Windows.Forms.Label();
            this.pnlDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDay
            // 
            this.pnlDay.BorderRadius = 10;
            this.pnlDay.Controls.Add(this.lblDay);
            this.pnlDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDay.Location = new System.Drawing.Point(4, 4);
            this.pnlDay.Name = "pnlDay";
            this.pnlDay.Size = new System.Drawing.Size(142, 142);
            this.pnlDay.TabIndex = 0;
            this.pnlDay.Click += new System.EventHandler(this.pnlDay_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(44, 13);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(57, 39);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "00";
            // 
            // UCScheduleDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.pnlDay);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCScheduleDay";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.pnlDay.ResumeLayout(false);
            this.pnlDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlDay;
        private System.Windows.Forms.Label lblDay;
    }
}
