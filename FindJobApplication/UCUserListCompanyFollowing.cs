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

namespace FindJobApplication
{
    public partial class UCUserListCompanyFollowing : UserControl
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        public UCUserListCompanyFollowing()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UCUserListCompanyFollowing_Load(object sender, EventArgs e)
        {
            var companyFollowingList = userProfileDao.FindAllCompanyFollowingByUser(Session.account.Id);
            pnlMain.Controls.Clear();
            pnlMain.RowCount = 0;
            for (int i = 0; i < companyFollowingList.Count; ++i)
            {
                pnlMain.RowCount += 1;
                UCUserCompanyFollwing row = new UCUserCompanyFollwing(i + 1, companyFollowingList.ElementAt(i));
                pnlMain.Controls.Add(row);
            }
            pnlMain.RowCount += 1;
            
        }
    }
}
