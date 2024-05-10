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
    public partial class UCCompanyListPeopleApply : UserControl
    {
        JobPostDao jobPostDao = new JobPostDao();
        public UCCompanyListPeopleApply()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        public UCCompanyListPeopleApply(int jobPostId) : this()
        {
            Tag = jobPostId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }
        }

        private void UCCompanyListPeopleApply_Load(object sender, EventArgs e)
        {
            var appliedUsers = jobPostDao.FindAllUserIdAppliedForOneJob((int)Tag);
            pnlMain.Controls.Clear();
            pnlMain.RowCount = 0;
            pnlMain.SuspendLayout();
            for (int i = 0; i < appliedUsers.Count; i++)
            {
                pnlMain.Controls.Add(new UCCompanyPeopleApplied(i+1, appliedUsers.ElementAt(i)));
            }
            pnlMain.RowCount += 1;
            pnlMain.ResumeLayout();
        }
    }
}
