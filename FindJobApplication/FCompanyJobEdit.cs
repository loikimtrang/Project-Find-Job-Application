using FindJobApplication.Daos;
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FCompanyJobEdit : Form
    {
        private string formAction;
        private Dictionary<string, string> controlToField = new Dictionary<string, string>()
        {
            { "txtNameJob", "Title" },
            { "cbExperience", "YearExperienceId" },
            { "cbLocation", "LocationId" },
            { "txtSalary", "Salary" },
            { "rTxtJobDescription", "Description" },
            { "rTxtCandidateRequirements", "Requirement" },
            { "rTxtPrioritize", "Prioritize" },
            { "rTxtBenefits", "Benefit" },
            { "txtNumberOfRecruitment", "RecruitmentNumber" },
            { "txtWorkAddress", "Address" },
            { "dtpExpireDate", "ExpireDate" }
        };

        public FCompanyJobEdit()
        {
            InitializeComponent();
            this.formAction = "Create";
        }

        public FCompanyJobEdit(int jobPostId) : this()
        {
            this.Tag = jobPostId;
            this.formAction = "Update";
        }

        private void FCompanyJobEdit_Load(object sender, EventArgs e)
        {
            LocationDao locationDao = new LocationDao();
            YearExperienceDao yearExperienceDao = new YearExperienceDao();

            this.cbLocation.ValueMember = "id";
            this.cbLocation.DisplayMember = "name";
            this.cbLocation.DataSource = locationDao.FindAllLocationList();

            this.cbExperience.ValueMember = "id";
            this.cbExperience.DisplayMember = "name";
            this.cbExperience.DataSource = yearExperienceDao.FindAllExperience();

            if (this.Tag != null)
            {
                int jobPostId = (int)this.Tag;
                JobPostDao jobPostDao = new JobPostDao();
                JobPost jobPost = jobPostDao.FindJobPostById(jobPostId);

                this.txtNameJob.Text = jobPost.Title;
                this.txtSalary.Text = jobPost.Salary.ToString();
                this.rTxtBenefits.Text = jobPost.Benefit;
                this.rTxtCandidateRequirements.Text = jobPost.Requirement;
                this.rTxtJobDescription.Text = jobPost.Description;
                this.rTxtPrioritize.Text = jobPost.Prioritize;
                this.txtNumberOfRecruitment.Text = jobPost.RecruitmentNumber.ToString();
                this.txtWorkAddress.Text = jobPost.Address;
                this.cbExperience.SelectedIndex = jobPost.YearExperienceId;
                this.cbLocation.SelectedIndex = jobPost.LocationId;
                this.dtpExpireDate.Text = jobPost.ExpireDate.ToString();

                if (this.formAction == "Update")
                {
                    this.btnPostJob.Text = "Update";
                }
            }
        }

        private JobPost getJobPostInfo()
        {
            JobPost jobPost = new JobPost();
            foreach (Control control in this.guna2Panel1.Controls) {
                string propertyName = "";
                if(controlToField.TryGetValue(control.Name, out propertyName))
                {
                    object value = null;
                    if (control is ListControl listControl)
                    {
                        value = listControl.SelectedValue;
                    }
                    else
                    {
                        value = control.Text;
                    }
                    typeof(JobPost).GetProperty(propertyName)?.SetValue(jobPost, Convert.ChangeType(value, typeof(JobPost).GetProperty(propertyName).PropertyType));
                }

            }
            return jobPost;
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            JobPost jobPost = getJobPostInfo();
            jobPost.CompanyId = Session.account.Id;
            JobPostDao jobPostDao = new JobPostDao();
            if (this.formAction == "Create")
            {
                jobPost.PostDate = DateTime.Now;
                int results = jobPostDao.SaveNewJobPost(jobPost);
                if (results == 0)
                {
                    MessageDialog.Show(this, "Failed to save the job post", "Failed", MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(this, "Job post saved successfully", MessageDialogStyle.Light);
                    this.Close();
                }
            }
            else if (this.formAction == "Update")
            {
                int results = jobPostDao.UpdateJobPostById(jobPost);
                if (results == 0)
                {
                    MessageDialog.Show(this, "Failed to update the job post", "Error", MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(this, "Job post updated successfully", MessageDialogStyle.Light);
                    this.Close();
                }
            }
        }

        private void FCompanyJobEdit_Shown(object sender, EventArgs e)
        {

        }
    }
}
