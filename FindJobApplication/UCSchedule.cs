using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCSchedule : UserControl
    {
        int month;
        int year;

        public UCSchedule()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        private void displayDay(int days, int dayOfWeek)
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName + " " + year;
            int cnt = 1;
            for (int col = 0; col < dayOfWeek; col++)
            {
                UCScheduleDay uCScheduleDay = new UCScheduleDay();
                tlpCalendar.Controls.Add(uCScheduleDay, col, 0);
                uCScheduleDay.Hide();

            }
            for (int row = 0; row < tlpCalendar.RowCount; row++)
            {
                for (int col = 0; col < tlpCalendar.ColumnCount; col++)
                {
                    if (tlpCalendar.GetControlFromPosition(col, row) == null)
                    {
                        
                        UCScheduleDay uCScheduleDay = new UCScheduleDay();
                        tlpCalendar.Controls.Add(uCScheduleDay, col, row);
                        uCScheduleDay.LblDay.Text = cnt.ToString();
                        if (cnt == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                        {
                            uCScheduleDay.PnlDay.FillColor = Color.FromArgb(51, 102, 255);
                            uCScheduleDay.PnlDay.FillColor2 = Color.FromArgb(51, 102, 255);
                            uCScheduleDay.PnlDay.FillColor3 = Color.FromArgb(51, 102, 255);
                            uCScheduleDay.PnlDay.FillColor4 = Color.FromArgb(51, 102, 255);
                            uCScheduleDay.LblDay.ForeColor = Color.White;
                        }
                        cnt++;
                        if (cnt > days) break;
                    }
                }
                if (cnt > days) break;
            }
        }
        private void UCSchedule_Load(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            
            // get the first of the month
            DateTime dayStartOfMonth = new DateTime(year, month, 1);
            // get the count of days of month
            int days = DateTime.DaysInMonth(year, month);
            // tính số ngày còn sót lại của tháng trc
            int dayOfWeek = Convert.ToInt32(dayStartOfMonth.DayOfWeek.ToString("d"));
            displayDay(days, dayOfWeek);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tlpCalendar.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            DateTime dayStartOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(dayStartOfMonth.DayOfWeek.ToString("d"));
            displayDay(days, dayOfWeek);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tlpCalendar.Controls.Clear();
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            DateTime dayStartOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(dayStartOfMonth.DayOfWeek.ToString("d"));
            displayDay(days, dayOfWeek);
        }
    }
}
