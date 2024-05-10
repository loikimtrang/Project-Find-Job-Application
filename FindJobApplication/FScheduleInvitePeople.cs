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
    public partial class FScheduleInvitePeople : Form
    {
        public FScheduleInvitePeople()
        {
            InitializeComponent();
        }

        private void FScheduleInvitePeople_Load(object sender, EventArgs e)
        {
            for (int i = 0;i<5; i++)
            {
               UCScheduleEventPeopleWaitInvite uCScheduleEventPeopleWaitInvite = new UCScheduleEventPeopleWaitInvite();
                pnlListPeopleWaitInterview.Controls.Add(uCScheduleEventPeopleWaitInvite);
            }
        }
    }
}
