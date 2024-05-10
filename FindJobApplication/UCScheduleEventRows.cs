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
    public delegate void SeePeopleInterviewClickedEventHandler(object sender, EventArgs e, UCScheduleEventDetail uCScheduleEventDetail);

    public partial class UCScheduleEventRows : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public UCScheduleEventRows()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public Label LblNameJob { get => lblNameJob; set => lblNameJob = value; }

        public Label LblDate { get => lblDate; set => lblDate = value; }
        public Label LblFrom { get => lblFrom; set => lblFrom = value; }
        public Label LblTo { get => lblTo; set => lblTo = value; }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            FScheduleAddNewEvent fScheduleAddNewEvent = new FScheduleAddNewEvent();
            fScheduleAddNewEvent.Show();
        }

        private void pbSeePeopleInterview_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCScheduleEventDetail());
        }
    }
}
