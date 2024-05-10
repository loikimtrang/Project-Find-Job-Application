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
using FindJobApplication.Utils;

namespace FindJobApplication
{
    public partial class UCCompanySubMenuRight : UserControl
    {
        public UCCompanySubMenuRight()
        {
            InitializeComponent();
        }
        public void hideMenu()
        {
            this.Visible = false;
        }
        public void hideAndShowSubMenu(object sender)
        {
            (sender as UserControl).AutoSize ^= true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UCCompanyProfile uCCompanyProfile = new UCCompanyProfile(Session.account.Id);
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyProfile);
            hideMenu();
           // UCMain.Instance.updateStatus(btnProfile);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UCSetting uCSetting = new UCSetting();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCSetting);
            hideMenu();
           // UCMain.Instance.updateStatus(btnSetting);
        }

        private void btnFollowCV_Click(object sender, EventArgs e)
        {
            UCCompanyListCVFollowing uCCompanyListCVFollowing = new UCCompanyListCVFollowing();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyListCVFollowing);
            hideMenu();
           // UCMain.Instance.updateStatus(btnFollowCV);
        }

        private void btnSocialPost_Click(object sender, EventArgs e)
        {
            UCSocialHistory uCSocialHistory = new UCSocialHistory();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCSocialHistory);
            hideMenu();
          //  UCMain.Instance.updateStatus(btnSocialPost);
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            UCSetting uCSetting = new UCSetting();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCSetting);
            hideMenu();
           // UCMain.Instance.updateStatus(btnSetting);
        }
    }
}
