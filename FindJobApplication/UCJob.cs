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
using FindJobApplication.Daos;
using Guna.UI2.WinForms;
using FindJobApplication.Utils;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class UCJob : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked;

        UserProfileDao userProfileDao = new UserProfileDao();

        public UCJob()
        {
            InitializeComponent();
        }
        public UCJob(JobPost jobPost, bool isFavourite) : this()
        {
            Tag = jobPost;
            pBCompany.Image = ImageUtils.FromBytesToImage(jobPost.CompanyProfile.Account.Avatar);
            JobName.Text = standardizeNames(jobPost.Title);
            CompanyName.Text = jobPost.CompanyProfile.Account.Name;
            Location.Text = jobPost.Location.Name;
            Salary.Text = jobPost.Salary.ToString();
            LLblNameJob.Tag = jobPost.Id;
            CompanyName.Tag = jobPost.CompanyId;

            foreach (Skill skill in jobPost.Skills)
            {
                UCSkillTag uCSkillTag = new UCSkillTag(skill);
                pnlSkill.Controls.Add(uCSkillTag);

                if (pnlSkill.PreferredSize.Width > pnlSkill.Width)
                {
                    pnlSkill.Controls.RemoveAt(pnlSkill.Controls.Count - 1);

                    Label etc = new Label();
                    etc.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    etc.Text = "...";
                    etc.Height = 28;
                    pnlSkill.Controls.Add(etc);
                }
            }

            btnSave.Checked = isFavourite;
        }

        public new GunaLinkLabel LLblNameJob { get => lLblNameJob; set { lLblNameJob = value; } }
        public GunaLinkLabel JobName { get => lLblNameJob; set { lLblNameJob = value; } }
        public new GunaLinkLabel CompanyName { get => lblNameCompany; set { lblNameCompany = value; } }
        public new Label Location { get => lblLocation; set { lblLocation = value; } }
        public Label Salary { get => lblSalary; set { lblSalary = value; } }
        public FlowLayoutPanel PnlSkill { get => pnlSkill; set => pnlSkill = value; }
        public Guna2PictureBox PBCompany { get => pBCompany; set => pBCompany = value; }
        public Guna2ImageCheckBox BtnSave { get => btnSave; set => btnSave = value; }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FUserSubmitCV fUserSubmitCV = new FUserSubmitCV((JobPost)Tag);
            fUserSubmitCV.Show();
        }

        private void lLblNameJob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCJobInformation uCJobInformation = new UCJobInformation(Tag as JobPost, btnSave.Checked);
            FillToMainPanelClicked?.Invoke(sender, uCJobInformation);
        }

        private void lblNameCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyProfile uCCompanyProfile = new UCCompanyProfile((int)lblNameCompany.Tag);
            FillToMainPanelClicked?.Invoke(sender, uCCompanyProfile);
            uCCompanyProfile.hideAllButton();
        }
        public string standardizeNames(string name)
        {
            if (name.Length <= 16)
            {
                return name;
            }
            else
            {
                return name.Substring(0, 14) + "...";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Checked == true)
            {
                userProfileDao.SaveUserFollowJob(Session.account.Id, (Tag as JobPost).Id);
            }
            else
            {
                userProfileDao.DeleteUserFollowJob(Session.account.Id, (Tag as JobPost).Id);
            }
        }
    }
}
