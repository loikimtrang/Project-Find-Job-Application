using FindJobApplication.Daos;
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
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FUserSubmitCV : Form
    {
        private int jobId;
        public FUserSubmitCV(JobPost jobPost)
        {
            InitializeComponent();
            this.lblNameJob.Text = jobPost.Title;
            this.jobId = jobPost.Id;
            jobId = jobPost.Id;
        }

        private void btnSendCv_Click(object sender, EventArgs e)
        {
            JobApplyDao jobapplydao = new JobApplyDao();
            string coverletter = this.rtxtCoverLeter.Text;
            string status = "pending";
            DateTime appliedat = DateTime.Now;
            UserApplyJob userApplyJob = new UserApplyJob();
            userApplyJob.AppliedAt = appliedat;
            userApplyJob.Status = status;
            userApplyJob.CoverLetter = coverletter;
            userApplyJob.CvAttachment = " ";
            userApplyJob.JobPostId = jobId;
            userApplyJob.UserId = Session.account.Id;
            jobapplydao.SaveUserApplyJob(userApplyJob);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
