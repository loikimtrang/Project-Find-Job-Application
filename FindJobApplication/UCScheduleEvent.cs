using FindJobApplication.Utils;
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
    public partial class UCScheduleEvent : UserControl
    {
        public UCScheduleEvent()
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

        private void UCScheduleEvent_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                UCScheduleEventRows uCScheduleEventRows = new UCScheduleEventRows();
                pnlListEvent.Controls.Add(uCScheduleEventRows);
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            FScheduleAddNewEvent fScheduleAddNewEvent = new FScheduleAddNewEvent(Session.account.Id);
            fScheduleAddNewEvent.Show();
        }
    }
}
