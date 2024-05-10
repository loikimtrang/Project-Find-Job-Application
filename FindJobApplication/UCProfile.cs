using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCProfile : UserControl
    {
        private UserProfile userProfile;
        private UserProfileDao userProfileDao = new UserProfileDao();
        UCUCUserProfileEducationAndWorkExperience uCEduaction = new UCUCUserProfileEducationAndWorkExperience();
        UCUCUserProfileEducationAndWorkExperience uCWorkExperience = new UCUCUserProfileEducationAndWorkExperience();
        UCSkillTag uCUserProfileSkill = new UCSkillTag();
        UCUserProfileProject uCUserProfileProject = new UCUserProfileProject();

        public UCProfile()
        {
            InitializeComponent();
            panelProfile.AutoScroll = true;
            btnBack.Visible = false;
            Dock = DockStyle.Fill;
            pnlProfile.HorizontalScroll.Maximum = 0;
            pnlProfile.AutoScroll = false;
            pnlProfile.VerticalScroll.Visible = true;
            pnlProfile.AutoScroll = true;
        }
        public UCProfile(int userId) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(userId);
        }

        public void hideAllBtn()
        {
            btnBack.Visible = true;
            btnFollow.Visible = true;

            pbEducationEdit.Visible = false;
            pbIntroductionEdit.Visible = false;
            pbPersonalProjectEdit.Visible = false;
            pbProfileEdit.Visible = false;
            pbSkillsEdit.Visible = false;
            pbWorkExperienceEdit.Visible = false;

            uCEduaction.pbDeleteEducationOrWork.Visible = false;
            uCEduaction.pbEditEducationOrWork.Visible = false;

            uCWorkExperience.pbDeleteEducationOrWork.Visible = false;
            uCWorkExperience.pbEditEducationOrWork.Visible = false;

            uCUserProfileProject.pbDeleteProject.Visible = false;
            uCUserProfileProject.pbEditProject.Visible = false;

        }
        public Panel panelProfile { get => pnlProfile; }

        private void pbProfileEdit_Click(object sender, EventArgs e)
        {
            FUserProfileInformationEdit fUserProfileInformationEdit = new FUserProfileInformationEdit();
            fUserProfileInformationEdit.Show();
        }

        private void pbIntroductionEdit_Click(object sender, EventArgs e)
        {
            FUserProfileIntroductionEdit fUserProfileIntroductionEdit = new FUserProfileIntroductionEdit();
            fUserProfileIntroductionEdit.Show();
        }

        private void pbEducationEdit_Click(object sender, EventArgs e)
        {
            FUserProfileEducationEdit fUserProfileEducationEdit = new FUserProfileEducationEdit();
            fUserProfileEducationEdit.Show();
        }

        private void pbWorkExperienceEdit_Click(object sender, EventArgs e)
        {
            FUserProfileWorkExperienceEdit fUserProfileWorkExperienceEdit = new FUserProfileWorkExperienceEdit();
            fUserProfileWorkExperienceEdit.Show();
        }

        private void pbSkillsEdit_Click(object sender, EventArgs e)
        {
            FUserProfileSkillsEdit fUserProfileSkillsEdit = new FUserProfileSkillsEdit();   
            fUserProfileSkillsEdit.Show();
        }

        private void pbPersonalProjectEdit_Click(object sender, EventArgs e)
        {
            FUserProfilePersonalProjectEdit fUserProfilePersonalProjectEdit = new FUserProfilePersonalProjectEdit();
            fUserProfilePersonalProjectEdit.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            //CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            //if (btnFollow.Text == "Following")
            //{
            //    btnFollow.Text = "Follow";
            //    companyProfileDao.DeleteUserIdFollowing(Session.account.Id, userId);
            //}
            //else
            //{
            //    btnFollow.Text = "Following";
            //    companyProfileDao.SaveUserIdFollowing(Session.account.Id, userId);
            //}
        }

        private void UCProfile_Load(object sender, EventArgs e)
        {
            pbProfileAvatar.Image = ImageUtils.FromBytesToImage(userProfile.Account.Avatar);
            lblProfileName.Text = Session.account.Name;
            lblProfileTitle.Text = userProfile.Title;
            lblProfileEmail.Text = Session.account.Email;
            lblProfileGender.Text = userProfile.Gender;
            lblProfileDateOfBirth.Text = userProfile.DateOfBirth.ToString();
            lblProfilePhoneNumber.Text = userProfile.PhoneNumber;
            lblProfileAddress.Text = userProfile.Address;
            lblProfileTitle.Text = userProfile.Title;
            lblProfileLink.Text = userProfile.PersonalLink;
            rtxtAboutMe.Text = userProfile.AboutMe;
            pnlEducationDetail.Controls.Clear();
            foreach (var item in userProfile.UserEducations)
            {
                UCUCUserProfileEducationAndWorkExperience uCUCUserProfileEducationAndWorkExperience = new UCUCUserProfileEducationAndWorkExperience(item);
                pnlEducationDetail.Controls.Add(uCUCUserProfileEducationAndWorkExperience);
            }
            foreach (var item in userProfile.UserWorkExperiences)
            {
                UCUCUserProfileEducationAndWorkExperience uCUCUserProfileEducationAndWorkExperience = new UCUCUserProfileEducationAndWorkExperience(item);
                pnlWorkExperienceDetail.Controls.Add(uCUCUserProfileEducationAndWorkExperience);
            }
            foreach (var item in userProfile.Skills)
            {
                UCSkillTag uCUserProfileSkill = new UCSkillTag(item);
                pnlSkillDetail.Controls.Add(uCUserProfileSkill);
            }
            foreach(var item in userProfile.UserPersonalProjects)
            {
                UCUserProfileProject uCUserProfileProject = new UCUserProfileProject(item);
                pnlProjectDetail.Controls.Add(uCUserProfileProject);
            }
            if (isFollowing(userProfile.Id))
            {
                btnFollow.Text = "Following";
            }
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
        private bool isFollowing(int userId)
        {
            return Session.account.Accounts.Where(row => row.Id == userId).Any();
        }
    }
}
