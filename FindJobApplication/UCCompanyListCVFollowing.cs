using FindJobApplication.Daos;
using FindJobApplication.Utils;
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
    public partial class UCCompanyListCVFollowing : UserControl
    {
        public UCCompanyListCVFollowing()
        {
            InitializeComponent();
        }

        private void UCCompanyListCVFollowing_Load(object sender, EventArgs e)
        {
            pnlListCVFollowing.Controls.Clear();
            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            List<int> userFollowingIds = companyProfileDao.FindAllUserIdFollowing(Session.account.Id);
            int cnt = 1;
            foreach (int userId in userFollowingIds)
            {
                UserProfileDao userProfileDao = new UserProfileDao();
                UserProfile userProfile = null;
                //UserProfile userProfile = userProfileDao.FindUserProfileByAccountId(userId);
                UCCompanyCVFollowing uCCompanyCVFollowing = new UCCompanyCVFollowing();
                uCCompanyCVFollowing.LblId.Text = (cnt++).ToString();
                //uCCompanyCVFollowing.LlblName.Text = userProfile.Name;
                //uCCompanyCVFollowing.Tag = userProfile.ID;
                this.pnlListCVFollowing.Controls.Add(uCCompanyCVFollowing);
            }
        }
    }
}
