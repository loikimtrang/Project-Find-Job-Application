using FindJobApplication.Entities;
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
    public partial class UCUserProfileProject : UserControl
    {
        public UCUserProfileProject()
        {
            InitializeComponent();
        }

        public UCUserProfileProject(UserPersonalProject userPersonalProject) : this()
        {
            this.lblNameProject.Text = userPersonalProject.ProjectName;
            this.lblStartDay.Text = userPersonalProject.From.ToString("dd-MM-yyyy");
            this.lblEndDay.Text = userPersonalProject.To.ToString("dd-MM-yyyy");
            this.lblSeeProject.Tag = userPersonalProject.Description;
        }

        private void lblSeeProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (this.lblSeeProject.Tag).ToString();
            System.Diagnostics.Process.Start(url);
        }
    }
}
