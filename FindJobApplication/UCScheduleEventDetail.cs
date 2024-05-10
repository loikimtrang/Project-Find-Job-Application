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
    public partial class UCScheduleEventDetail : UserControl
    {
        public UCScheduleEventDetail()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }
        }

        private void UCScheduleEventDetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) 
            {
                UCScheduleEventDetailRow row = new UCScheduleEventDetailRow();
                pnlListPeopleInterview.Controls.Add(row);
            }
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            FScheduleInvitePeople fScheduleInvitePeople = new FScheduleInvitePeople();
            fScheduleInvitePeople.Show();
        }
    }
}
