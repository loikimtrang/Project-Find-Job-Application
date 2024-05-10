using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Daos;
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FCompanyProfileInfomationEdit : Form
    {
        Image img = Properties.Resources.fpt_logo1;

        public FCompanyProfileInfomationEdit()
        {
            InitializeComponent();
        }

        private void pbCompany1_MouseLeave(object sender, EventArgs e)
        {
            pbCompany1.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany1_MouseEnter(object sender, EventArgs e)
        {
            pbCompany1.Image = Properties.Resources.camera_Edit1;

        }
        private void pbCompany2_MouseLeave(object sender, EventArgs e)
        {
            pbCompany2.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany2_MouseEnter(object sender, EventArgs e)
        {
            pbCompany2.Image = Properties.Resources.camera_Edit1;

        }
        private void pbCompany3_MouseLeave(object sender, EventArgs e)
        {
            pbCompany3.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany3_MouseEnter(object sender, EventArgs e)
        {
            pbCompany3.Image = Properties.Resources.camera_Edit1;

        }
        private void pbCompany4_MouseLeave(object sender, EventArgs e)
        {
            pbCompany4.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany4_MouseEnter(object sender, EventArgs e)
        {
            pbCompany4.Image = Properties.Resources.camera_Edit1;
        }
        private void pbUser_MouseEnter(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.camera_Edit1;
        }
        private void pbUser_MouseLeave(object sender, EventArgs e)
        {
            pbUser.Image = img;
        }
        private void FCompanyProfileInfomationEdit_Load(object sender, EventArgs e)
        {
            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            CompanyProfile companyProfile = companyProfileDao.FindCompanyProfileByAccountId(Session.account.Id);
            //this.txtNameCompany.Text = companyProfile.Name;
            //this.txtEmail.Text = companyProfile.Email;
            this.txtPhoneNumber.Text = companyProfile.PhoneNumber;
            this.dtpDateEstablish.Text = companyProfile.DateEstablish?.ToString("dd-MM-yyyy") ?? DateTime.Now.ToString("dd-MM-yyy");
            this.txtCompanySize.Text = companyProfile.CompanySize.ToString();
            this.txtAddress.Text = companyProfile.Address;
            this.txtLink.Text = companyProfile.CompanyLink;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CompanyProfile companyProfile = new CompanyProfile(
                    //Id = Session.account.Id,
                    //this.txtNameCompany.Text,
                    //this.txtEmail.Text,
                    //this.txtPhoneNumber.Text,
                    //this.txtAddress.Text,
                    //Convert.ToDateTime(this.dtpDateEstablish.Text),
                    //Convert.ToInt32(this.txtCompanySize.Text),
                    //this.txtLink.Text
                );

            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            int result = companyProfileDao.UpdateCompanyProfile(companyProfile);
            if (result > 0)
            {
                MessageDialog.Show(this, "Update success");
                this.btnCancel.PerformClick();
            }
            else
            {
                MessageDialog.Show(this, "Update failed");
            }
        }
    }
}
