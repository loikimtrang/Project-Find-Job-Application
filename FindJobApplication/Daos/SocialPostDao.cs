using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class SocialPostDao
    {
        private QLXinViecDFContext db = null;

        public SocialPostDao()
        {
            db = new QLXinViecDFContext();
        }


        public ICollection<SocialPost> FindAllSocialPost()
        {
            return db.SocialPosts.OrderByDescending(row => row.PostDate).ToList();
        }

        public SocialPost FindSocialPostById(int postId)
        {
            return db.SocialPosts.Find(postId);
        }

        public ICollection<SocialPost> FindSocialPostOfAnUser(int userId)
        {
            var results = db.SocialPosts
                    .Where(row => row.AccountID == userId)
                    .OrderByDescending(row => row.PostDate);

            return results.ToList();
        }

        public int SaveNewSocialPost(SocialPost socialPost)
        {
            db.SocialPosts.Add(socialPost);
            return db.SaveChanges();
        }

        public int DeleteSocialPostById(int postId)
        {
            var socialPost = db.SocialPosts
                        .Include(row => row.Skills)
                        .FirstOrDefault(row => row.Id == postId);
            db.SocialPosts.Attach(socialPost);
            db.SocialPosts.Remove(socialPost);
            return db.SaveChanges();
        }
    }
}
