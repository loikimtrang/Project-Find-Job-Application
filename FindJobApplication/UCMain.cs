using FindJobApplication.Entities;
using FindJobApplication.Utils;
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
    public partial class UCMain : UserControl
    {
        static UCMain _obj;
        public static UCMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCMain();
                }
                return _obj;
            }
        }
        public UCMain()
        {
            InitializeComponent();
        }
        public Guna2CustomGradientPanel PnlMid { get => pnlMid; set => pnlMid = value; }
        public Guna2Button BtnHome { get => btnHome; set => btnHome = value; }
        public Guna2Button BtnUser { get => btnUser; set => btnUser = value; }
        public GunaButton BtnStatus { get => btnStatus; set => btnStatus = value; }
        public Guna2Button BtnLogOut { get => btnSignOut; set => btnSignOut = value; }
        public Guna2Button BtnSocial { get => btnSocial; set => btnSocial = value; }
        public Guna2CirclePictureBox PbHomeUser { get => pbHomeUser; set => pbHomeUser = value; }
        public void updateStatus(Guna2Button button)
        {
            btnStatus.Image = button.Image;
            btnStatus.Text = button.Text;
        }
        private void UCMain_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Session.account = null;

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)this.TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            UCSocial uCSocial = new UCSocial();
            this.updateStatus(btnSocial);
            this.PnlMid.Controls.Clear();
            this.PnlMid.Controls.Add(uCSocial);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            UCMail uCMail = new UCMail();
            this.updateStatus(btnMail);
            this.PnlMid.Controls.Clear();
            this.PnlMid.Controls.Add(uCMail);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnTopTrending_Click(object sender, EventArgs e)
        {
            UCTopTrending uCTopTrending = new UCTopTrending();
            this.updateStatus(btnTopTrending);
            this.PnlMid.Controls.Clear();
            this.PnlMid.Controls.Add(uCTopTrending);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }
    }
}
