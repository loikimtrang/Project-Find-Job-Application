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
    public partial class UCUCUserProfileEducationAndWorkExperience : UserControl
    {
        public UCUCUserProfileEducationAndWorkExperience()
        {
            InitializeComponent();
        }

        public UCUCUserProfileEducationAndWorkExperience(UserEducation userEducation) : this()
        {
            this.lblMajor.Text = userEducation.Major;
            this.lblSchool.Text = userEducation.SchoolName;
            this.lblStartDay.Text = userEducation.From.ToString("dd-MM-yyyy");
            this.lblEndDay.Text = userEducation.To.ToString("dd-MM-yyyy");
        }

        public UCUCUserProfileEducationAndWorkExperience(UserWorkExperience userWorkExperience) : this()
        {
            this.lblMajor.Text = userWorkExperience.JobTitle;
            this.lblSchool.Text = userWorkExperience.CompanyName;
            this.lblStartDay.Text = userWorkExperience.From.ToString("dd-MM-yyyy");
            this.lblEndDay.Text = userWorkExperience.To.ToString("dd-MM-yyyy");
        }
    }
}
