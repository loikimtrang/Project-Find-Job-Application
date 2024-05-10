using FindJobApplication.Daos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FindJobApplication.Utils;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class UCJobInformation : UserControl
    {
        private readonly JobPost jobPost = null;
        private readonly bool isFavourite = false;
        public UCJobInformation()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            tableLayoutPanel1.HorizontalScroll.Maximum = 0;
            tableLayoutPanel1.AutoScroll = false;
            tableLayoutPanel1.VerticalScroll.Visible = false;
            tableLayoutPanel1.AutoScroll = true;
        }

        public UCJobInformation(JobPost jobPost, bool isFavourite) : this()
        {
            this.jobPost = jobPost;
            this.isFavourite = isFavourite;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }
        }

        private void UCJobInformation_Load(object sender, EventArgs e)
        {
            lblNameJob.Text = jobPost.Title;
            lblNameCompany.Text = jobPost.CompanyProfile.Account.Name;
            lblSalary.Text = jobPost.Salary.ToString();
            rtxtJobDescription.Text = jobPost.Description;
            rtxtRequired.Text = jobPost.Requirement;
            rtxtPrioritize.Text = jobPost.Prioritize;
            rtxtBenefit.Text = jobPost.Benefit;
            lblPostDate.Text = jobPost.PostDate.ToString("dd-MM-yyyy");
            lblWorkAddress.Text = jobPost.Address;
            btnSave.Checked = isFavourite;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FUserSubmitCV fUserSubmitCV = new FUserSubmitCV(jobPost);
            fUserSubmitCV.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserProfileDao userProfileDao = new UserProfileDao();
            if (btnSave.Checked == true)
            {
                userProfileDao.SaveUserFollowJob(Session.account.Id, jobPost.Id);
            }
            else
            {
                userProfileDao.DeleteUserFollowJob(Session.account.Id, jobPost.Id);
            }
        }
    }
}
