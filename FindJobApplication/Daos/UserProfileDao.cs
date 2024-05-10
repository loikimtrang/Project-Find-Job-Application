using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using FindJobApplication.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace FindJobApplication.Daos
{
    public class UserProfileDao
    {
        private QLXinViecDFContext db = null;

        public UserProfileDao()
        {
            db = new QLXinViecDFContext();
        }

        public ICollection<UserProfile> FindAllUserProfile()
        {
            var results = db.UserProfiles.ToList();

            return results.ToList();
        }

        public UserProfile FindUserProfileByAccountId(int userId)
        {
            var result = db.UserProfiles.Single(row => row.Id == userId);

            return result;
        }

        public ICollection<Account> FindAllCompanyFollowingByUser(int userId)
        {
            var results = db.Accounts
                    .Where(row => row.Id == userId)
                    .SelectMany(row => row.Account1)
                    .ToList();
            return results;
        }

        public int SaveUserEducation(UserEducation userEducation)
        {
            db.UserEducations.Add(userEducation);
            return db.SaveChanges();
        }
        public int SaveUserWorkExperience(UserWorkExperience userWorkExperience)
        {
            db.UserWorkExperiences.Add(userWorkExperience);
            return db.SaveChanges();
        }
        public int SaveUserPersonalProject(UserPersonalProject userPersonalProject)
        {
            db.UserPersonalProjects.Add(userPersonalProject);
            return db.SaveChanges();
        }
        public int SaveUserSkill(int skillId)
        {
            return db.SaveChanges();
        }
        public int SaveUserFollowJob(int userId, int jobPostId)
        {
            var userProfile = FindUserProfileByAccountId(userId);
            var jobPost = db.JobPosts.Find(jobPostId);
            userProfile.JobPosts.Add(jobPost);
            return db.SaveChanges();
        }
        public int UpdateUserProfile(UserProfile userProfile)
        {
            db.UserProfiles.Attach(userProfile);
            return db.SaveChanges();
        }
        
        public int DeleteUserEducation(int id)
        {
            var userEducation = db.UserEducations.Find(id);
            db.UserEducations.Remove(userEducation);
            db.UserEducations.Attach(userEducation);
            return db.SaveChanges();
        }
        public int DeleteUserWorkExperience(int id)
        {
            var userWorkExperience = db.UserWorkExperiences.Find(id);
            db.UserWorkExperiences.Remove(userWorkExperience);
            db.UserWorkExperiences.Attach(userWorkExperience);
            return db.SaveChanges();
        }
        public int DeleteUserPersonalProject(int id)
        {
            var userPersonalProject = db.UserPersonalProjects.Find(id);
            db.UserPersonalProjects.Remove(userPersonalProject);
            db.UserPersonalProjects.Attach(userPersonalProject);
            return db.SaveChanges();
        }

        public int DeleteUserFollowJob(int userId, int jobPostId)
        {
            var userProfile = FindUserProfileByAccountId(userId);
            var jobPost = db.JobPosts.Find(jobPostId);
            userProfile.JobPosts.Remove(jobPost);
            db.UserProfiles.Attach(userProfile);
            return db.SaveChanges();
        }
    }
}
