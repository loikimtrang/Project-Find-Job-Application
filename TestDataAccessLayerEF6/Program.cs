using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDataAccessLayerEF6.Entities;

namespace TestDataAccessLayerEF6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Get user_profile
            UserProfileDFContext context = new UserProfileDFContext();
            var userProfile = (from q in context.UserProfiles
                              where q.Id == 6
                              select q).FirstOrDefault();

            //Add new user_education
            /*
            user_education user_Education1 = new user_education(
                "HCMCUTE",
                "Artiticial Intelligence",
                DateTime.Parse("2021-08-01"),
                DateTime.Parse("2025-08-01"),
                "Engineer degree",
                userProfile.account_id
            );
            */

            /*            
            userProfile.user_education.Add(new user_education(
                "HCMCUTE",
                "Software engineer",
                DateTime.Parse("2021-08-01"),
                DateTime.Parse("2025-08-01"),
                "Engineer degree",
                userProfile.account_id
            ));
            */

            /*
            user_education user_Education1 = new user_education(
                "HCMCUTE",
                "Network Security",
                DateTime.Parse("2021-08-01"),
                DateTime.Parse("2025-08-01"),
                "Engineer degree",
                userProfile.account_id
            );
            */

            UserEducation userEducation = (from q in userProfile.UserEducations
                                          where q.Id == 1
                                          select q)
                                          .FirstOrDefault();
            userEducation.Detail = "Bachelor degree";
            context.SaveChanges();

            Console.WriteLine("Done");
        }
    }
}
