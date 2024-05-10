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
    public delegate void DayClickClickedEventHandler(object sender, EventArgs e, UCScheduleEvent uCScheduleEvent);
    public partial class UCScheduleDay : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public UCScheduleDay()
        {

            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        public Label LblDay { get => lblDay; set => lblDay = value; }
        public Guna2CustomGradientPanel PnlDay { get => pnlDay; set => pnlDay = value; }

        private void pnlDay_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCScheduleEvent());
        }
    }
}
