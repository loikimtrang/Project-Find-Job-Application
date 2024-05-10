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

namespace FindJobApplication.Utils
{
    public enum DialogBoxType
    {
        Error,
        Warning,
        Success,
    }
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        }

        public static void Show(Form parentForm, DialogBoxType type, string title, string message)
        {

        }
    }
}
