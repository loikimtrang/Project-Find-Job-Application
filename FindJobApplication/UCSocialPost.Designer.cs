namespace FindJobApplication
{
    partial class UCSocialPost
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
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.llblName = new Guna.UI.WinForms.GunaLinkLabel();
            this.pnlSkill = new System.Windows.Forms.FlowLayoutPanel();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDatePost = new Guna.UI.WinForms.GunaLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSendMail = new Guna.UI2.WinForms.Guna2Button();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Inter SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 122);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 25);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Find job java";
            // 
            // llblName
            // 
            this.llblName.AutoSize = true;
            this.llblName.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.llblName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblName.LinkColor = System.Drawing.Color.Black;
            this.llblName.Location = new System.Drawing.Point(144, 29);
            this.llblName.Name = "llblName";
            this.llblName.Size = new System.Drawing.Size(111, 25);
            this.llblName.TabIndex = 6;
            this.llblName.TabStop = true;
            this.llblName.Text = "David Lee";
            // 
            // pnlSkill
            // 
            this.pnlSkill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSkill.Location = new System.Drawing.Point(38, 291);
            this.pnlSkill.Name = "pnlSkill";
            this.pnlSkill.Size = new System.Drawing.Size(1152, 54);
            this.pnlSkill.TabIndex = 5;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.Color.White;
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Font = new System.Drawing.Font("Inter", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(36, 165);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(1558, 102);
            this.rtxtDescription.TabIndex = 4;
            this.rtxtDescription.Text = "Hello HR. I am looking for a job at Java backend positions. Below is my CV.";
            // 
            // lblDatePost
            // 
            this.lblDatePost.AutoSize = true;
            this.lblDatePost.Font = new System.Drawing.Font("Inter Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDatePost.Location = new System.Drawing.Point(146, 77);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(103, 19);
            this.lblDatePost.TabIndex = 3;
            this.lblDatePost.Text = "2024-04-04";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.pbAvatar);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSendMail);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTitle);
            this.guna2CustomGradientPanel1.Controls.Add(this.pnlSkill);
            this.guna2CustomGradientPanel1.Controls.Add(this.rtxtDescription);
            this.guna2CustomGradientPanel1.Controls.Add(this.llblName);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblDatePost);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1776, 366);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.btnSendMail.BorderRadius = 30;
            this.btnSendMail.BorderThickness = 1;
            this.btnSendMail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendMail.FillColor = System.Drawing.Color.White;
            this.btnSendMail.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.btnSendMail.HoverState.FillColor = System.Drawing.Color.Chocolate;
            this.btnSendMail.Image = global::FindJobApplication.Properties.Resources.Social_Mail;
            this.btnSendMail.ImageSize = new System.Drawing.Size(36, 41);
            this.btnSendMail.Location = new System.Drawing.Point(1442, 252);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(300, 92);
            this.btnSendMail.TabIndex = 38;
            this.btnSendMail.Text = "Mail";
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.ImageRotate = 0F;
            this.pbAvatar.Location = new System.Drawing.Point(35, 21);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAvatar.Size = new System.Drawing.Size(75, 75);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 40;
            this.pbAvatar.TabStop = false;
            // 
            // UCSocialPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UCSocialPost";
            this.Size = new System.Drawing.Size(1776, 366);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblDatePost;
        private System.Windows.Forms.FlowLayoutPanel pnlSkill;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private Guna.UI.WinForms.GunaLinkLabel llblName;
        private Guna.UI2.WinForms.Guna2Button btnSendMail;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbAvatar;
    }
}
