using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Entities;

namespace FindJobApplication.Daos
{
    public class SkillDao
    {
        private QLXinViecDFContext db = null;
        public SkillDao()
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<Skill> FindAllSkill()
        {
            return db.Skills.ToList();
        }
    }
}
