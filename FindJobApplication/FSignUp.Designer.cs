using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace FindJobApplication
{
    partial class FSignUp
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
            this.btnSignup = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAskCreate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.llblPolicy = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.llblCreateBussiness = new Guna.UI.WinForms.GunaLinkLabel();
            this.llblSignIn = new Guna.UI.WinForms.GunaLinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.llblTerm = new Guna.UI.WinForms.GunaLinkLabel();
            this.llblSignInUser = new Guna.UI.WinForms.GunaLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BorderRadius = 4;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnSignup.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(864, 611);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(432, 45);
            this.btnSignup.TabIndex = 4;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(841, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 58);
            this.label1.TabIndex = 49;
            this.label1.Text = "Create your account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(864, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(864, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Email";
            // 
            // lblAskCreate
            // 
            this.lblAskCreate.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAskCreate.Location = new System.Drawing.Point(864, 687);
            this.lblAskCreate.Margin = new System.Windows.Forms.Padding(0);
            this.lblAskCreate.Name = "lblAskCreate";
            this.lblAskCreate.Size = new System.Drawing.Size(432, 19);
            this.lblAskCreate.TabIndex = 62;
            this.lblAskCreate.Text = "By creating an account you agree to our";
            this.lblAskCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1070, 707);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "and";
            // 
            // llblPolicy
            // 
            this.llblPolicy.AutoSize = true;
            this.llblPolicy.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.llblPolicy.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblPolicy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.llblPolicy.Location = new System.Drawing.Point(1105, 707);
            this.llblPolicy.Margin = new System.Windows.Forms.Padding(0);
            this.llblPolicy.Name = "llblPolicy";
            this.llblPolicy.Size = new System.Drawing.Size(115, 19);
            this.llblPolicy.TabIndex = 64;
            this.llblPolicy.TabStop = true;
            this.llblPolicy.Text = "Privacy policy";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(864, 761);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(431, 10);
            this.gunaSeparator1.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(893, 796);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "If you are bussiness. ";
            // 
            // llblCreateBussiness
            // 
            this.llblCreateBussiness.AutoSize = true;
            this.llblCreateBussiness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblCreateBussiness.Font = new System.Drawing.Font("Inter SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.llblCreateBussiness.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblCreateBussiness.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.llblCreateBussiness.Location = new System.Drawing.Point(1056, 796);
            this.llblCreateBussiness.Margin = new System.Windows.Forms.Padding(0);
            this.llblCreateBussiness.Name = "llblCreateBussiness";
            this.llblCreateBussiness.Size = new System.Drawing.Size(223, 19);
            this.llblCreateBussiness.TabIndex = 67;
            this.llblCreateBussiness.TabStop = true;
            this.llblCreateBussiness.Text = "Create a bussiness account\r\n";
            this.llblCreateBussiness.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCreateBussiness_LinkClicked);
            // 
            // llblSignIn
            // 
            this.llblSignIn.AutoSize = true;
            this.llblSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblSignIn.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.llblSignIn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.llblSignIn.Location = new System.Drawing.Point(1106, 831);
            this.llblSignIn.Name = "llblSignIn";
            this.llblSignIn.Size = new System.Drawing.Size(114, 19);
            this.llblSignIn.TabIndex = 69;
            this.llblSignIn.TabStop = true;
            this.llblSignIn.Text = "Please sign in";
            this.llblSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignInUser_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(893, 841);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 19);
            this.label6.TabIndex = 68;
            this.label6.Text = "You already have an account.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::FindJobApplication.Properties.Resources.signup;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 1024);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 4;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(864, 299);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(12, 8, 50, 8);
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(432, 50);
            this.txtName.TabIndex = 69;
            this.txtName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 4;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(864, 412);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(12, 8, 50, 8);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(432, 50);
            this.txtEmail.TabIndex = 70;
            this.txtEmail.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.Color.White;
            this.lblShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShow.Font = new System.Drawing.Font("Inter Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(1238, 530);
            this.lblShow.Margin = new System.Windows.Forms.Padding(0);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(50, 40);
            this.lblShow.TabIndex = 72;
            this.lblShow.Text = "Show";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 4;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(864, 525);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(12, 8, 50, 8);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(432, 50);
            this.txtPassword.TabIndex = 71;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // llblTerm
            // 
            this.llblTerm.AutoSize = true;
            this.llblTerm.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.llblTerm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblTerm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.llblTerm.Location = new System.Drawing.Point(937, 707);
            this.llblTerm.Margin = new System.Windows.Forms.Padding(0);
            this.llblTerm.Name = "llblTerm";
            this.llblTerm.Size = new System.Drawing.Size(136, 19);
            this.llblTerm.TabIndex = 61;
            this.llblTerm.TabStop = true;
            this.llblTerm.Text = "Terms of service";
            // 
            // llblSignInUser
            // 
            this.llblSignInUser.AutoSize = true;
            this.llblSignInUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblSignInUser.Font = new System.Drawing.Font("Inter SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.llblSignInUser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblSignInUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.llblSignInUser.Location = new System.Drawing.Point(1122, 841);
            this.llblSignInUser.Margin = new System.Windows.Forms.Padding(0);
            this.llblSignInUser.Name = "llblSignInUser";
            this.llblSignInUser.Size = new System.Drawing.Size(114, 19);
            this.llblSignInUser.TabIndex = 73;
            this.llblSignInUser.TabStop = true;
            this.llblSignInUser.Text = "Please sign in";
            this.llblSignInUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignInUser_LinkClicked);
            // 
            // FSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.llblSignInUser);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llblCreateBussiness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.llblPolicy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAskCreate);
            this.Controls.Add(this.llblTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DishplaySignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAskCreate;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLinkLabel llblPolicy;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLinkLabel llblCreateBussiness;
        private Guna.UI.WinForms.GunaLinkLabel llblSignIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna2TextBox txtName;
        private Guna2TextBox txtEmail;
        private Label lblShow;
        private Guna2TextBox txtPassword;
        private Guna.UI.WinForms.GunaLinkLabel llblTerm;
        private Guna.UI.WinForms.GunaLinkLabel llblSignInUser;
    }
}