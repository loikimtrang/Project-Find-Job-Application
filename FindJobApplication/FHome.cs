using FindJobApplication.Daos;
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
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FHome : Form
    {
        UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();

        public FHome()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCHome());
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session.account.Name;
            pbUserImage.Image = ImageUtils.FromBytesToImage(Session.account.Avatar);
            btnHome.PerformClick();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCSocial());
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCMail());
        }

        private void btnTrending_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCTopTrending());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCProfile());
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCUserListCompanyFollowing());
        }

        private void btnMyJob_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCMyJob());
        }

        private void btnHistorySocial_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCSocialHistory());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.account = null;

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            uCUserSubMenuRight.HideAndShowSubMenu(ucUserSubMenu);
        }
    }
}
