using FindJobApplication.Daos;
using FindJobApplication.Entities;
using Guna.UI.WinForms;
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
    public partial class UCSocialHistoryRow : UserControl
    {
        public UCSocialHistoryRow()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCSocialHistoryRow(int rowId) : this()
        {
            lblID.Text = rowId.ToString();
        }

        public UCSocialHistoryRow(int rowId, SocialPost socialPost) : this(rowId)
        {
            lblTitle.Text = socialPost.Title;
            lblDatePost.Text = socialPost.PostDate.ToString("dd-MM-yyyy");
            Tag = socialPost.Id;
        }
        
        private void pbEdit_Click(object sender, EventArgs e)
        {
            FPostSocial fPostSocial = new FPostSocial();
            fPostSocial.BtnPost.Text = "Save";
            fPostSocial.Show();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            SocialPostDao socialPostDao = new SocialPostDao();
            int result = socialPostDao.DeleteSocialPostById((int)Tag);
            if (result > 0)
            {
                MessageDialog.Show(this.ParentForm, "Delete success");
            }
            else
            {
                MessageDialog.Show(this.ParentForm, "Delete failed");
            }
        }
    }
}
