using FindJobApplication.Entities;
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
    public delegate void SeeDetailClickedEventHandler(object sender, EventArgs e, UCMailDetail ucMailDetail);

    public partial class UCMailRow : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public UCMailRow()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCMailRow(int rowId) : this()
        {
            lblID.Text = rowId.ToString();
        }

        public UCMailRow(int rowId, Mail mail, bool isSentRender) : this(rowId)
        {
            Tag = mail;
            lblFrom.Text = isSentRender ? mail.Account1.Name : mail.Account.Name;
            lblTitle.Text = mail.Title;
            lblTime.Text = mail.SendDate.ToString("dd-MM-yyyy");
        }

        private void pbSeeDetail_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCMailDetail(Tag as Mail));
        }
    }
}
