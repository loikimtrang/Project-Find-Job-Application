using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
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

namespace FindJobApplication
{
    public partial class UCSetting : UserControl
    {
        AccountDao accountDao = new AccountDao();
        public UCSetting()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            lblEmail.Text = Session.account.Email;
            lblName.Text = Session.account.Name;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string reenterPassword = txtReenterPassword.Text;

            if (currentPassword != Session.account.Password)
            {
                MessageDialog.Show(this.ParentForm, "Your current password is incorrect");
                txtCurrentPassword.Focus();
                return;
            }

            if (newPassword != reenterPassword)
            {
                MessageDialog.Show(this.ParentForm, "Your re-enter password is incorrect");
                txtReenterPassword.Focus();
                return;
            }

            int result = accountDao.UpdateAccountPassword(new Account()
            {
                Id = Session.account.Id,
                Password = newPassword,
            });

            if (result > 0)
            {
                MessageDialog.Show(this.ParentForm, "Your password has changed");
                txtCurrentPassword.Text = "";
                txtNewPassword.Text = "";
                txtReenterPassword.Text = "";
            }
            else
            {
                MessageDialog.Show(this.ParentForm, "Your password changed failed");
            }
        }
    }
}
