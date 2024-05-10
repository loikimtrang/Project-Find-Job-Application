using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
    public partial class UCCompanySeeProfilePeople : UserControl
    {
        public FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;
        private UserApplyJob user = null;

        public UCCompanySeeProfilePeople()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCCompanySeeProfilePeople(UserApplyJob user) : this()
        {
            this.user = user;
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

        private void btnSeeCV_Click(object sender, EventArgs e)
        {
            UCProfile uCProfile = new UCProfile(user.UserId);
            FillToMainPanelClicked?.Invoke(this, uCProfile);
            //FCompanySeeCV fCompanySeeCV = new FCompanySeeCV(this.userId);
            //fCompanySeeCV.Show();
        }

        private void UCCompanySeeProfilePeople_Load(object sender, EventArgs e)
        {
            lblNamePeople.Text = user.UserProfile.Account.Name;
            lblNameJob.Text = user.JobPost.Title;
            rtxtCoverLetter.Text = user.CoverLetter;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FCompanyScheduleAnInterview fCompanyScheduleAnInterview = new FCompanyScheduleAnInterview();    
            fCompanyScheduleAnInterview.Show();
        }
    }
}
