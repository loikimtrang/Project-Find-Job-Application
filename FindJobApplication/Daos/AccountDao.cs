using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class AccountDao
    {
        private QLXinViecDFContext db = null;

        public AccountDao()
        {
            db = new QLXinViecDFContext();
        }

        public Account FindAccountByEmail(string email)
        {
            var result = db.Accounts.Where(row => row.Email == email);

            return result.FirstOrDefault();
        }
        public Account FindAccountById(int id)
        {
            return db.Accounts.Find(id);
        }
        public int SaveNewAccount(string email, string name, string password, string role)
        {
            Account account = new Account
            {
                Email = email,
                Name = name,
                Password = password,
                Role = role
            };

            db.Accounts.Add(account);
            return db.SaveChanges();
        }

        public int UpdateAccountPassword(Account account)
        {
            var currentAccount = db.Accounts.Find(account.Id);
            currentAccount.Password = account.Password;
            return db.SaveChanges();
        }
    }
}
