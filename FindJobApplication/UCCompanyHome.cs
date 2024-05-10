using FindJobApplication.Daos;
using FindJobApplication.Utils;
using Guna.UI.WinForms;
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
    public partial class UCCompanyHome : UserControl
    {
        JobPostDao jobPostDao = new JobPostDao();
        public UCCompanyHome()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void UCCompanyHome_Load(object sender, EventArgs e)
        {
            ICollection<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Session.account.Id);
            fillDataToPanel(jobPosts);
        }
        public void fillDataToPanel(ICollection<JobPost> jobPosts)
        {
            pnlJobPostedList.Controls.Clear();
            int cnt = 1;
            foreach (JobPost jobPost in jobPosts)
            {
                int nApplicants = jobPostDao.CountUserAppliedForOneJob(jobPost.Id);
                UCCompanyJob uCCompanyJob = new UCCompanyJob(jobPost, cnt++, nApplicants);
                pnlJobPostedList.Controls.Add(uCCompanyJob);
            }
        }
        private void btnRecruitment_Click(object sender, EventArgs e)
        {
            FCompanyJobEdit fCompanyJobEdit = new FCompanyJobEdit();
            fCompanyJobEdit.Show();
        }

        private void btnStillRecruitment_Click(object sender, EventArgs e)  
        {
            ICollection<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Session.account.Id);
            List<JobPost> filtered = jobPosts.Where(row => row.ExpireDate >= DateTime.Today).ToList();
            fillDataToPanel(filtered);
        }

        private void btnExpiration_Click(object sender, EventArgs e)
        {
            ICollection<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Session.account.Id);
            List<JobPost> filtered = jobPosts.Where(row => row.ExpireDate < DateTime.Today).ToList();
            fillDataToPanel(filtered);
        }
    }
}
