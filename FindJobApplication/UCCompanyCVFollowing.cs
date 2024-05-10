using Guna.UI.WinForms;
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
    public partial class UCCompanyCVFollowing : UserControl
    {
        public UCCompanyCVFollowing()
        {
            InitializeComponent();
        }
        public Label LblId { get => lblID; set => lblID = value; }
        public GunaLinkLabel LlblName { get => llblName; set => llblName = value; }

        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCProfile uCProfile = new UCProfile((int)this.Tag);
            UCMain.Instance.PnlMid.Controls.Add(uCProfile);
            uCProfile.hideAllBtn();
            uCProfile.BringToFront();
        }
    }
}
