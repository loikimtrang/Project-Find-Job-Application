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
    public partial class UCCompanyPeopleApplied : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;
        public UCCompanyPeopleApplied()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCCompanyPeopleApplied(int rowId) : this()
        {
            lblId.Text = rowId.ToString();
        }

        public UCCompanyPeopleApplied(int rowId, UserApplyJob user) : this(rowId)
        {
            lblNamePeople.Text = user.UserProfile.Account.Name;
            lblDayApply.Text = user.AppliedAt.ToString("dd-MM-yyy");
            lblStatus.Text = user.Status;
            pbSeeDetail.Tag = user;
        }

        private void pbSeeDetail_Click(object sender, EventArgs e)
        {
            UCCompanySeeProfilePeople uCCompanySeeProfilePeople = new UCCompanySeeProfilePeople(pbSeeDetail.Tag as UserApplyJob);
            FillToMainPanelClicked?.Invoke(this, uCCompanySeeProfilePeople);
        }
    }
}
