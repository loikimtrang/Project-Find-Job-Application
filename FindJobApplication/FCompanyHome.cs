using FindJobApplication.Daos;
using FindJobApplication.Utils;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FCompanyHome : Form
    {
        public FCompanyHome()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.account = null;

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }
        private void FCompanyHome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session.account.Name;
            pbUserImage.Image = ImageUtils.FromBytesToImage(Session.account.Avatar);
            btnHome.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            this.ucCompanySubMenuRight.hideAndShowSubMenu(this.ucCompanySubMenuRight);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCCompanyHome());
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCSocial());
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCMail());

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCSchedule());
        }
    }
}
