using FindJobApplication.Daos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Utils;

namespace FindJobApplication
{
    public partial class FSignUpCompany : Form
    {
        public FSignUpCompany()
        {
            InitializeComponent();
            this.ActiveControl = this.txtName;
        }

        private void llblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.Close();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            this.ofdBusinessLicense.Filter = "Image files (*.jpeg; *.jpg) | *.jpeg; *.jpg";
            if (this.ofdBusinessLicense.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;
            string name = this.txtName.Text;
            AccountDao accountDao = new AccountDao();
            int results = accountDao.SaveNewAccount(email, name, password, AccountRole.Company);

            if (results > 0)
            {
                MessageDialog.Show(this, "Sign up successful", "Success", MessageDialogStyle.Default);
            }
            else
            {
                MessageDialog.Show(this, "Sign up failed", "Error", MessageDialogStyle.Default);
            }
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "Show")
            {
                this.txtPassword.PasswordChar = '\0';
                lblShow.Text = "Hide";
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
                lblShow.Text = "Show";
            }
        }
    }
}
