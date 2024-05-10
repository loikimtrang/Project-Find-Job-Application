using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindJobApplication.Entities;

namespace FindJobApplication.Daos
{
    public class LocationDao
    {
        private QLXinViecDFContext db = null;
        public LocationDao()
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<Location> FindAllLocationList()
        {
            return db.Locations.ToList();
        }
    }
}
