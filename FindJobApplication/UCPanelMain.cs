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
    public partial class UCPanelMain : UserControl
    {
        private static UCPanelMain _instace = null;
        public UCPanelMain()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            _instace = this;
        }

        public static void UC_RequiredAddControl(object sender, UserControl uc)
        {
            if (_instace != null)
            {
                _instace.AddControl(uc);
            }
        }

        public void AddControl(UserControl uc)
        {
            pnlMain.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
