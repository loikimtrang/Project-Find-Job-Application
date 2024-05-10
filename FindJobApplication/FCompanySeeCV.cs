using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class FCompanySeeCV : Form
    {
        private int userId;
        public FCompanySeeCV()
        {
            InitializeComponent();
        }

        public FCompanySeeCV(int userId) : this()
        {
            this.userId = userId;
        }
        public void LoadCV()
        {
            //UCProfile uCProfile = new UCProfile(this.userId);
            //uCProfile.hideAllBtn();
            //this.Controls.Add(uCProfile);
        }

        private void FCompanySeeCV_Load(object sender, EventArgs e)
        {
           // LoadCV();
        }
    }
}
