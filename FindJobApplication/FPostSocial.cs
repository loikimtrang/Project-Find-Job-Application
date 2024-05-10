using FindJobApplication.Daos;
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
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FPostSocial : Form
    {
        public FPostSocial()
        {
            InitializeComponent();
        }
        public Guna2Button BtnPost { get => btnPost; set => btnPost = value; }
        private void btnPost_Click(object sender, EventArgs e)
        {
            ICollection<Skill> postSkills = new List<Skill>();
            foreach (Control control in pnlSkill.Controls)
            {
                postSkills.Add(control.Tag as Skill);
            }
            SocialPost socialPost = new SocialPost()
            {
                Title = txtTitle.Text,
                PostDate = DateTime.Now,
                Contents = rtxtStatus.Text,
                AccountID = Session.account.Id,
                Skills = postSkills
            };

            SocialPostDao socialPostDao = new SocialPostDao();
            int result = socialPostDao.SaveNewSocialPost(socialPost);
            if (result > 0)
            {
                MessageDialog.Show(this, "Post success");
                this.Close();
            }
            else
            {
                MessageDialog.Show(this, "Post failed");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UCSkillTag uCSkillTag = new UCSkillTag(new Skill() {
                Id = (int)cbSkill.SelectedValue,
                Name = cbSkill.Text
            });
            pnlSkill.Controls.Add(uCSkillTag);
        }

        private void FPostSocial_Load(object sender, EventArgs e)
        {
            this.skillTableAdapter.Fill(this.skillDataSet.Skill);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
