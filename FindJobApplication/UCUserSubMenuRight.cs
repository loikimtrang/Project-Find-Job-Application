using FindJobApplication.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public delegate void FillToMainPanelHandler (object sender, UserControl uc);
    
    public partial class UCUserSubMenuRight : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;
        public UCUserSubMenuRight()
        {
            InitializeComponent();
        }

        public void HideAndShowSubMenu(object sender)
        {
            (sender as UserControl).AutoSize ^= true;
        }

        public void btnProfile_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCProfile(Session.account.Id));
        }

        private void btnMyJob_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCMyJob(Session.account.Id));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCSetting());
        }

        private void btnFavouriteCompany_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCUserListCompanyFollowing());
        }

        private void btnSocialPost_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCSocialHistory());
        }
    }

}
