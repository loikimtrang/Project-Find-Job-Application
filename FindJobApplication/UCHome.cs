using Guna.UI.WinForms;
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
using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;

namespace FindJobApplication
{
    public partial class UCHome : UserControl
    {
        UCPanelMain parentContainer = null;
        public UCHome()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        
        public Guna2TextBox TxtSeach { get => txtSearch; }
        public GunaComboBox CbLocation { get => cbLocation; }
        public GunaComboBox CbExperince { get => cbExperience; }
        public Guna2Button BtnSearch { get => btnSearch; }
        public FlowLayoutPanel PnlListJob { get => pnlListJob; }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = TxtSeach.Text;
            int locationId = CbLocation.SelectedIndex;
            int experienceId = CbExperince.SelectedIndex;

            JobPostDao jobPostDao = new JobPostDao();
            ICollection<JobPost> dt = jobPostDao.FindAllJobPost();
            if (!string.IsNullOrEmpty(keyword))
            {
                dt = dt.Where(row => row.Title.Contains(keyword)).ToList();
            }
            this.fillJobPostToPanel(dt);
        }

        public void fillJobPostToPanel(ICollection<JobPost> jobPosts)
        {
            pnlListJob.Controls.Clear();

            UserProfileDao userProfileDao = new UserProfileDao();
            var favourites = new HashSet<int> (
                userProfileDao
                .FindUserProfileByAccountId(Session.account.Id)
                .JobPosts
                .Select(row => row.Id)
                .ToList()
            );
            foreach (JobPost jobPost in jobPosts)
            {
                bool isFavourite = favourites.Contains(jobPost.Id);
                UCJob uCJob = new UCJob(jobPost, isFavourite);
                uCJob.FillToMainPanelClicked += FillToParentPanel;
                uCJob.FillToMainPanelClicked += FillToParentPanel;
                pnlListJob.Controls.Add(uCJob);
            }
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            YearExperienceDao yearExperienceDao = new YearExperienceDao();
            LocationDao locationDao = new LocationDao();

            CbLocation.ValueMember = "id";
            CbLocation.DisplayMember = "name";
            CbLocation.DataSource = locationDao.FindAllLocationList();

            CbExperince.ValueMember = "id";
            CbExperince.DisplayMember = "name";
            CbExperince.DataSource = yearExperienceDao.FindAllExperience();

            fillJobPostToPanel(jobPostDao.FindAllJobPost());
        }

        private void FillToParentPanel(object sender, UserControl uc)
        {
            parentContainer.AddControl(uc);
        }
    }
}
