    using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
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
    public partial class UCSocialPost : UserControl
    {
        AccountDao accountDao = new AccountDao();

        public UCSocialPost()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCSocialPost(SocialPost socialPost) : this()
        {
            Account account = accountDao.FindAccountById(socialPost.AccountID);
            llblName.Text = account.Name;
            pbAvatar.Image = ImageUtils.FromBytesToImage(account.Avatar);
            lblDatePost.Text = socialPost.PostDate.ToString("dd-MM-yyyy");
            lblTitle.Text = socialPost.Title;
            rtxtDescription.Text = socialPost.Contents;
            foreach (Skill skill in socialPost.Skills)
            {
                UCSkillTag uCUserProfileSkill = new UCSkillTag(skill);
                this.pnlSkill.Controls.Add(uCUserProfileSkill);
            }
            Tag = socialPost.Id;
        }

        public LinkLabel LlblName { get => llblName; }
        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCProfile uCProfile = new UCProfile();
            UCMain.Instance.PnlMid.Controls.Add(uCProfile);
            uCProfile.hideAllBtn();
            uCProfile.BringToFront();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
    }
}
