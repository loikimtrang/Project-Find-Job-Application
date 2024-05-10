using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using FindJobApplication.Entities;

namespace FindJobApplication.Daos
{
    public class JobPostDao
    {
        private QLXinViecDFContext db = null;

        public JobPostDao()
        {
            db = new QLXinViecDFContext();
        }

        public int SaveNewJobPost(JobPost jobpost)
        {
            db.JobPosts.Add(jobpost);
            return db.SaveChanges();
        }
        public ICollection<JobPost> FindAllJobPost()
        {
            return db.JobPosts.ToList();
        }
        public JobPost FindJobPostById(int jobPostId)
        {
            return db.JobPosts.Find(jobPostId);
        }
        public ICollection<JobPost> FindAllJobPostByCompanyId(int companyId)
        {
            var results = from q in db.JobPosts
                          where q.CompanyId == companyId
                          select q;

            return results.ToList();
        }
        public int CountUserAppliedForOneJob(int jobPostId)
        {
            var jobPost = db.JobPosts.Find(jobPostId);
            return jobPost.UserApplyJobs.Count;
        }
        public ICollection<UserApplyJob> FindAllUserIdAppliedForOneJob(int jobPostId)
        {
            var results = db.UserApplyJobs
                    .Where(row => row.JobPostId == jobPostId)
                    .OrderByDescending(row => row.AppliedAt)
                    .ToList();
            return results;
        }
        public int DeleteJobPostById(int jobPostId)
        {
            JobPost jobPost = new JobPost() { Id = jobPostId };
            db.JobPosts.Attach(jobPost);
            db.JobPosts.Remove(jobPost);
            return db.SaveChanges();
        }
        public int UpdateJobPostById(JobPost jobPost)
        {
            db.JobPosts.Attach(jobPost);
            return db.SaveChanges();
        }

        public ICollection<JobPost> FindTopMostJobApplied(int top)
        {
            var results = db.UserApplyJobs
                    .GroupBy(row => row.JobPostId)
                    .OrderByDescending(gp => gp.Count())
                    .Take(top)
                    .Select(gp => gp.FirstOrDefault().JobPost)
                    .ToList();
            return results;
        }
    }
}
