using FindJobApplication.Daos;
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
    public partial class UCCompanyJobRecruitment : UserControl
    {
        int companyId;
        public UCCompanyJobRecruitment()
        {
            InitializeComponent();
        }
        public UCCompanyJobRecruitment(int companyId) :  this() 
        {
            this.companyId = companyId;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                this.Dispose();
            }
        }

        public void fillDataToPanel(List<JobPost> dataControlList)
        {
            //int cnt = 0;
            //pnlListJob.Controls.Clear(); 
            //foreach (JobPost obj in dataControlList)
            //{
            //    cnt++;
            //    UCJob uCJob = new UCJob((JobPost)obj);
            //    this.pnlListJob.Controls.Add(uCJob);
            //}
            //lblCountJob.Text = cnt.ToString();
        }

        private void UCCompanyJobRecruitment_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            //fillDataToPanel(jobPostDao.FindAllJobPostByCompanyId(companyId));
        }
    }
}
