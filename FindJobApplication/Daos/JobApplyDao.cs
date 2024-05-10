using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class JobApplyDao
    {
        private QLXinViecDFContext db = null;
        public JobApplyDao()
        {
            db = new QLXinViecDFContext();
        }
        public void SaveUserApplyJob(UserApplyJob userApplyJob)
        {
            db.UserApplyJobs.Add(userApplyJob);
            db.SaveChanges();
        }
    }
}
