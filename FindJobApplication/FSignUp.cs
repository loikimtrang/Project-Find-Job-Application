using FindJobApplication.Daos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Entities;
using FindJobApplication.Utils;

namespace FindJobApplication
{
    public partial class FSignUp : Form
    {
        public FSignUp()
        {
            InitializeComponent();
            this.ActiveControl = this.txtName;
            this.lblShow.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void llblSignInUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.Close();
        }
        private void lblShow_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "Show")
            {
                this.txtPassword.PasswordChar = '\0';
                this.lblShow.Text = "Hide";
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
                this.lblShow.Text = "Show";
            }
        }
        private void llblCreateBussiness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSignUpCompany fCompanySignUp = new FSignUpCompany();
            this.Hide();
            fCompanySignUp.ShowDialog();
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                string email = this.txtEmail.Text;
                string password = this.txtPassword.Text;
                string name = this.txtName.Text;
                Account account = new Account()
                {
                    Email = email,
                    Password = password,
                    Name = name,
                    Role = AccountRole.User
                };
                AccountDao accountDao = new AccountDao();
                int results = accountDao.SaveNewAccount(account.Email, account.Name, account.Password, account.Role);

                if (results > 0)
                {
                    MessageDialog.Show(this, "Sign up successful", "Success", MessageDialogStyle.Default);
                }
                else
                {
                    MessageDialog.Show(this, "Sign up failed", "Error", MessageDialogStyle.Default);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
