using FindJobApplication.Daos;
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
    public partial class UCCompanyJob : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;
        public UCCompanyJob()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCCompanyJob(JobPost jobPost, int id, int nApplicants) : this()
        {
            lblId.Text = id.ToString();
            lblNameJob.Text = jobPost.Title;
            lblPostDate.Text = jobPost.PostDate.ToString("dd-MM-yyyy");
            lblExpirationDate.Text = jobPost.ExpireDate.ToString("dd-MM-yyyy");
            lblSalary.Text = jobPost.Salary.ToString();
            lblCountApplied.Text = nApplicants.ToString();
            Tag = jobPost.Id;
        }

        private void lblCountApplied_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyListPeopleApply uCCompanyListPeopleApply = new UCCompanyListPeopleApply((int)this.Tag);
            FillToMainPanelClicked?.Invoke(this, uCCompanyListPeopleApply);
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            FCompanyJobEdit fCompanyJobEdit = new FCompanyJobEdit((int)this.Tag);
            fCompanyJobEdit.ShowDialog();
        }

        private void pBDelete_Click(object sender, EventArgs e)
        {
            int jobPostId = (int)this.Tag;
            JobPostDao jobPostDao = new JobPostDao();
            int result = jobPostDao.DeleteJobPostById(jobPostId);
            if (result  > 0)
            {
                MessageDialog.Show(this.ParentForm, "Delete recruitment post successfull", "Succes", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Default);
            }
            else
            {
                MessageDialog.Show(this.ParentForm, "Delete recruitment post failed", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);
            }
        }
    }
}
