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
    public partial class UCSkillTag : UserControl
    {
        public UCSkillTag()
        {
            InitializeComponent();
        }
        public UCSkillTag(Skill skill) : this()
        {
            btnSkill.Text = skill.Name;
            Tag = skill;
        }

        public void ShowBtnDelete()
        {
            pBDelete.Visible = true;
            pBDelete.Enabled = true;
        }
        private void pBDelete_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }
        }
    }
}
