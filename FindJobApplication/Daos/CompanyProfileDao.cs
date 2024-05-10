using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FindJobApplication.Entities;
using System.CodeDom.Compiler;

namespace FindJobApplication.Daos
{
    public class CompanyProfileDao
    {
        private QLXinViecDFContext db = null;

        public CompanyProfileDao()
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<CompanyProfile> FindAllCompanyProfile()
        {
            return db.CompanyProfiles.ToList();
        }

        public CompanyProfile FindCompanyProfileByAccountId(int accountId)
        {
            var result = from q in db.CompanyProfiles
                         where q.Id == accountId
                         select q;
            return result.FirstOrDefault();
        }

        public int SaveCompanySignUp(CompanyProfile companyProfile, string password)
        {
            return 0;
        }

        public List<int> FindAllUserIdFollowing(int companyAccountId)
        {
            return null;
        }

        public int SaveUserIdFollowing(int companyAccountId, int userAccountId)
        {
            return 0;
        }

        public int DeleteUserIdFollowing(int companyAccountId, int userAccountId)
        {
            return 0;
        }

        public int UpdateCompanyReason(int companyId, string reason)
        {
            var companyProfile = FindCompanyProfileByAccountId(companyId);
            companyProfile.Reason = reason;
            return db.SaveChanges();
        }

        public int UpdateCompanyOverview(int companyId, string overview)
        {
            var companyProfile = FindCompanyProfileByAccountId(companyId);
            companyProfile.Overview = overview;
            return db.SaveChanges();
        }

        public int UpdateCompanyProfile(CompanyProfile companyProfile)
        {
            return 0;
        }
        public int UpdateUserApplyStatus(int userId, int jobPostId, string status)
        {
            return 0;
        }

        public ICollection<CompanyProfile> FindTopFollowedCompany(int top)
        {
            var results = db.UserProfiles
                .SelectMany(row => row.Account.Account1)
                .GroupBy(row => row.CompanyProfile.Id)
                .OrderByDescending(gp => gp.Count())
                .Take(top)
                .Select(gp => gp.FirstOrDefault().CompanyProfile)
                .ToList();

            return results;
        }
    }
}
