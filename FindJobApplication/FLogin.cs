using FindJobApplication.Daos;
using FindJobApplication.Entities;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Utils;

namespace FindJobApplication
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            this.ActiveControl = this.txtEmail;
            this.AcceptButton = btnLogin;
        }
        private void llblSignUpUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSignUp fSignUp = new FSignUp();
            this.Hide();
            fSignUp.ShowDialog();
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;

            AccountDao accountDao = new AccountDao();
            Account account = accountDao.FindAccountByEmail(email);

            if (account is null || account.Password != password)
            {
                MessageDialog.Show(this, "Your email or password is incorrect", "Login failed", MessageDialogStyle.Default);
            }
            else
            {
                Form redirectForm = null;
                switch (account.Role)
                {
                    case "company":    
                        redirectForm = new FCompanyHome();
                        break;

                    case "user":
                        redirectForm = new FHome();
                        break;
                    default:
                        break;
                }

                Session.account = account;
                
                this.Hide();
                redirectForm.ShowDialog();
                this.Close();
            }
        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
