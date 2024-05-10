using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
    public partial class UCSocialHistory : UserControl
    {
        public UCSocialHistory()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UCSocialHistory_Load(object sender, EventArgs e)
        {
            SocialPostDao socialPostDao = new SocialPostDao();
            ICollection<SocialPost> socialPosts = socialPostDao.FindSocialPostOfAnUser(Session.account.Id);
            int cnt = 1;
            pnlMain.Controls.Clear();
            pnlMain.RowCount = 0;
            pnlMain.SuspendLayout();
            foreach (var post in socialPosts)
            {
                pnlMain.RowCount += 1;
                UCSocialHistoryRow row = new UCSocialHistoryRow(cnt++, post);
                pnlMain.Controls.Add(row);
            }
            pnlMain.RowCount += 1;
            pnlMain.ResumeLayout();
        }
    }
}
