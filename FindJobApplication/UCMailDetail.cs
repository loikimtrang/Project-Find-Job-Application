using FindJobApplication.Entities;
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
    public partial class UCMailDetail : UserControl
    {
        public UCMailDetail()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCMailDetail(Mail mail) : this()
        {
            Tag = mail;
            lblFrom.Text = mail.Account.Name;
            lblTo.Text= mail.Account1.Name;
            lblTitle.Text = mail.Title;
            rtxtLetter.Text = mail.Contents;

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

        private void btnResponse_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
    }
}
