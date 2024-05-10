using FindJobApplication.Entities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCUserCompanyFollwing : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;
        public UCUserCompanyFollwing()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCUserCompanyFollwing(int rowId) : this()
        {
            lblID.Text = rowId.ToString();
        }

        public UCUserCompanyFollwing(int rowId, Account account) : this(rowId)
        {
            llblNameCompany.Text = account.Name;
            llblNameCompany.Tag = account.Id;
        }

        private void llblNameCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCCompanyProfile((int)llblNameCompany.Tag));
        }
    }
}
