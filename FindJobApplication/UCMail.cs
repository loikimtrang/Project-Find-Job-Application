using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
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
    public partial class UCMail : UserControl
    {
        MailDao mailDao = new MailDao();

        public UCMail()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UCMail_Load(object sender, EventArgs e)
        {
            btnMailReceived.PerformClick();
        }
        private void btnMailReceived_Click(object sender, EventArgs e)
        {
            lblFrom.Text = "From";
            var mails = mailDao.FindAllReceivedEmailOfAnUser(Session.account.Id);
            AddEmailRow(mails, false);
        }

        private void btnMailSent_Click(object sender, EventArgs e)
        {
            lblFrom.Text = "To";
            var mails = mailDao.FindAllSentEmailOfAnUser(Session.account.Id);
            AddEmailRow(mails, true);
        }

        private void AddEmailRow(ICollection<Mail> mails, bool isSentRender)
        {
            pnlListMail.Controls.Clear();
            pnlListMail.RowCount = 0;
            pnlListMail.SuspendLayout();
            for (int i = 0; i < mails.Count; i++)
            {
                pnlListMail.RowCount += 1;
                UCMailRow row = new UCMailRow(i + 1, mails.ElementAt(i), isSentRender);
                pnlListMail.Controls.Add(row);
            }
            pnlListMail.RowCount += 1;
            pnlListMail.ResumeLayout();
        }

        private void btnComposeEmail_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
    }
}
