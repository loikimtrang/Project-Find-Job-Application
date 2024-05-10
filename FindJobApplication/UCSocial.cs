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
    public partial class UCSocial : UserControl
    {
        SocialPostDao socialPostDao = new SocialPostDao();

        public UCSocial()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            pBAvatar.Image = ImageUtils.FromBytesToImage(Session.account.Avatar);
        }
        private void UCSocial_Load(object sender, EventArgs e)
        {
            ICollection<SocialPost> socialPosts = socialPostDao.FindAllSocialPost();
            pnlSocial.Controls.Clear();
            pnlSocial.RowCount = 0;
            pnlSocial.SuspendLayout();
            foreach (var socialPost in socialPosts)
            {
                pnlSocial.RowCount += 1;

                UCSocialPost uCSocial = new UCSocialPost(socialPost);
                pnlSocial.Controls.Add(uCSocial);
            }
            pnlSocial.RowCount += 1;
            pnlSocial.ResumeLayout();
        }

        private void txtUpSocial_MouseClick(object sender, MouseEventArgs e)
        {
            FPostSocial fPostSocial = new FPostSocial();
            fPostSocial.FormClosed += this.UCSocial_Load;
            fPostSocial.Show();
        }
    }
}
