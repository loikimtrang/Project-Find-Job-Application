using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Entities;

namespace FindJobApplication.Daos
{
    public class YearExperienceDao
    {
        private QLXinViecDFContext db = null;
        public YearExperienceDao()
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<YearExperience> FindAllExperience()
        {
            return db.YearExperiences.ToList();
        }
    }
}
