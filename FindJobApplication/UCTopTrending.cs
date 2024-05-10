using FindJobApplication;
using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
using Guna.Charts.WinForms;
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

namespace FindJobApplication
{
    public partial class UCTopTrending : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        CompanyProfileDao companyProfileDao = new CompanyProfileDao();
        JobPostDao jobPostDao = new JobPostDao();

        public UCTopTrending()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Load_Data_Top_5();
        }
        private void Load_Data_Top_5()
        {
            BDTop5.DataPoints.Clear();
            chartTop5.Datasets.Clear();

            List<GunaLinkLabel> links = new List<GunaLinkLabel> { llblTop1, llblTop2, llblTop3, llblTop4, llblTop5 };
            List<Guna2Button> btns = new List<Guna2Button> { btnTop1, btnTop2, btnTop3, btnTop4, btnTop5 };
            int numberOfItemsToShow = 5;

            if (cbbSelectTopTrending.SelectedIndex == 0)
            {
                var results = jobPostDao.FindTopMostJobApplied(numberOfItemsToShow);
                BDTop5.Label = "Top 5 Job Apply";
                for (int i = 0; i < numberOfItemsToShow; i++)
                {
                    if (i < results.Count)
                    {
                        btns[i].Visible = true;
                        links[i].Visible = true;
                    }
                    else
                    {
                        btns[i].Visible = false;
                        links[i].Visible = false;
                    }
                }

                if (results.Count > 0)
                {
                    lblbTop1.Text = results.First().Title;
                }
                int index = 0;
                foreach (var item in results)
                {
                    string name = item.Title;
                    int count = item.UserApplyJobs.Count;
                    BDTop5.DataPoints.Add("", count);
                    links[index].Text = name;
                    index++;

                }
            }
            else
            {
                var results = companyProfileDao.FindTopFollowedCompany(numberOfItemsToShow);
                BDTop5.Label = "Top 5 Company";
                for (int i = 0; i < numberOfItemsToShow; i++)
                {
                    if (i < results.Count)
                    {
                        btns[i].Visible = true;
                        links[i].Visible = true;
                    }
                    else
                    {
                        btns[i].Visible = false;
                        links[i].Visible = false;
                    }
                }

                if (results.Count > 0) {
                    lblbTop1.Text = results.First().Account.Name;
                }
                int index = 0;
                foreach (var item in results)
                {
                    string name = item.Account.Name;
                    int count = item.Account.Accounts.Count;
                    BDTop5.DataPoints.Add("", count);
                    links[index].Text = name;
                    index++;

                }
            }

            

            
            chartTop5.Datasets.Add(BDTop5);
            chartTop5.Update();
        }
        private void lblbTop1_Click(object sender, EventArgs e)
        {
            loadDetail(lblbTop1);
        }

        private void llblTop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop1);
        }

        private void llblTop2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop2);

        }

        private void llblTop3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop3);

        }

        private void llblTop4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop4);

        }

        private void llblTop5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop5);

        }
        public void loadDetail(Label lbl)
        {
            int numberOfItemsToShow = 5;
            int row = int.Parse(lbl.Name[lbl.Name.Length - 1].ToString());
            int index = row - 1;
            if (cbbSelectTopTrending.SelectedIndex == 0)
            {
                var jobPost = jobPostDao.FindTopMostJobApplied(numberOfItemsToShow).ElementAt(index);
                bool isFavourite = Session.account.UserProfile.JobPosts.Any(q => q.Id == jobPost.Id);
                UCJobInformation uCJobInformation = new UCJobInformation(jobPost, isFavourite);
                FillToMainPanelClicked?.Invoke(this, uCJobInformation);
            }
            else
            {
                var companyProfile = companyProfileDao.FindTopFollowedCompany(numberOfItemsToShow).ElementAt(index);
                UCCompanyProfile uCCompanyProfile = new UCCompanyProfile(companyProfile.Id);
                FillToMainPanelClicked?.Invoke(this, uCCompanyProfile);

            }
        }

        private void cbbSelectTopTrending_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data_Top_5();
        }
    }
}
