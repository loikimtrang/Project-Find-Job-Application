using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
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
    public partial class FScheduleAddNewEvent : Form
    {
        int idCompany;
        JobPostDao jobPostDao = new JobPostDao();

        public FScheduleAddNewEvent()
        {
            InitializeComponent();
        }
        public FScheduleAddNewEvent(int idCompany)
        {
            InitializeComponent();

            this.idCompany = idCompany;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FScheduleAddNewEvent_Load(object sender, EventArgs e)
        {
            ICollection<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(idCompany);
            foreach (JobPost jobPost in jobPosts)
            {
                ccbNameJob.Items.Add(jobPost.Title);
            }
        }
    }
}
