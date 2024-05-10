using FindJobApplication.Entities;
using FindJobApplication.Utils;
using Guna.UI.WinForms;
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
    public partial class UCJobApply : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public UCJobApply()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        
        public UCJobApply(int ucId) : this()
        {
            lblID.Text = ucId.ToString();
        }

        public UCJobApply(int ucId, JobPost jobPost) : this(ucId)
        {
            llblNameJob.Text = jobPost.Title;
            llblNameJob.Tag = jobPost;
            llblNameCompany.Text = jobPost.CompanyProfile.Account.Name;
            llblNameCompany.Tag = jobPost.CompanyProfile.Id;
            lblDayApply.Text = jobPost.ExpireDate.ToString("dd-MM-yyyy");
        }

        public UCJobApply (int ucId, UserApplyJob userApplyJob, JobPost jobPost) : this(ucId, jobPost)
        {
            lblDayApply.Text = userApplyJob.AppliedAt.ToString("dd-MM-yyyy");
            lblStatus.Visible = true;
            lblStatus.Text = userApplyJob.Status;
        }

        private void llblNameJob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JobPost jobPostClicked = llblNameJob.Tag as JobPost;
            FillToMainPanelClicked?.Invoke(sender, new UCJobInformation(
                jobPostClicked,
                true
            ));
        }

        private void llblNameCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FillToMainPanelClicked?.Invoke(sender, new UCCompanyProfile(
                (int)llblNameCompany.Tag
            ));
        }
    }
}
