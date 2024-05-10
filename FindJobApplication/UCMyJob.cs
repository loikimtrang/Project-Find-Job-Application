using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
    public partial class UCMyJob : UserControl
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        public UCMyJob()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCMyJob(int userId) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(userId);
        }

        private void btnListJobSave_Click(object sender, EventArgs e)
        {
            icoStatusHeader.Visible = false;
            lblStatusHeader.Visible = false;

            var savedJobs = userProfile.JobPosts.ToList();
            pnlMain.Controls.Clear();
            pnlMain.RowCount = 0;
            for (int i = 0; i < savedJobs.Count; ++i)
            {
                pnlMain.Controls.Add(new UCJobApply(i+1, savedJobs[i]));
            }
            pnlMain.RowCount += 1;
        }
        private void btnListJobApply_Click(object sender, EventArgs e)
        {
            icoStatusHeader.Visible = true;
            lblStatusHeader.Visible = true;
            lblTimeHeader.Text = "Applied at";

            var appliedJobs = userProfile.UserApplyJobs.ToList();
            pnlMain.Controls.Clear();
            pnlMain.RowCount = 0;
            for (int i = 0; i < appliedJobs.Count; ++i)
            {
                pnlMain.RowCount += 1;
                pnlMain.Controls.Add(new UCJobApply(i + 1, appliedJobs[i], appliedJobs[i].JobPost));
            }
            pnlMain.RowCount += 1;
                }
        private void UCMyJob_Load(object sender, EventArgs e)
        {
            btnListJobSave.PerformClick();
        }
    }
}
