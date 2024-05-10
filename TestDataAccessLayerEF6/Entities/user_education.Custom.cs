using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataAccessLayerEF6.Entities
{
    public partial class UserEducation
    {
        public UserEducation() { }
        public UserEducation(string schoolName, string major, DateTime from, DateTime to, string details, int userId) : this()
        {
            this.SchoolName = schoolName;
            this.Major = major;
            this.From = from;
            this.To = to;
            this.Detail = details;
            this.UserId = userId;
        }
    }
}
