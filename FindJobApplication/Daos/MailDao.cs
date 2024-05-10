using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class MailDao
    {
        private QLXinViecDFContext db = null;

        public MailDao() 
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<Mail> FindAllReceivedEmailOfAnUser(int userId)
        {
            var results = db.Mails
                    .Where(row => row.ToId == userId)
                    .OrderByDescending(row => row.SendDate)
                    .ToList();
            return results;
        }
        public ICollection<Mail> FindAllSentEmailOfAnUser(int userId)
        {
            var results = db.Mails
                    .Where(row => row.FromId == userId)
                    .OrderByDescending(row => row.SendDate)
                    .ToList();
            return results;
        }
        public Mail FindMailByMailId(int mailId)
        {
            return db.Mails.Find(mailId);
        }
        public int DeleteMailByMailId(int mailId)
        {
            var mail = db.Mails.Find(mailId);
            db.Mails.Attach(mail);
            db.Mails.Remove(mail);
            return db.SaveChanges();
        }   

        public int SaveNewMail(Mail mail)
        {
            db.Mails.Add(mail);
            return db.SaveChanges();
        }
    }
}
