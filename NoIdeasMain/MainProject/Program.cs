using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using NoIdeas.Phone.Lib;
using Microsoft.LiveLocationWrapper;
using System.Threading;

namespace NoIdeas.Phone
{
    static class Program
    {
        /// <summary>
        /// Application Id for this application.
        /// Ask your professor for the correct value to use here.
        /// </summary>
        public const string ApplicationId = "DC43F5F6-B62D-4A69-BF21-95D4F836FA15";
        /// <summary>
        /// Instance of the user profile
        /// </summary>
        public static Profile profile = new Profile();

       
        /// <summary>
        /// Instance of the dating profile
        /// </summary>
        public static DatingProfile dprofile = new DatingProfile();
        /// <summary>
        /// Used to indicate if current user have a profile in DataBase
        /// </summary>
        public static bool doesHaveProfile = false;

        public static bool doesHaveDateProfile = false;

        public static string nickName = string.Empty;

        public static bool isFirstTime = true;
        /// <summary>
        /// Name of this application.
        /// </summary>
        public const string Name = "NoIdeas";

        /// <summary>
        /// URL for application's privacy statement.
        /// </summary>
        public const string PrivacyStatementUrl =
            "http://research.microsoft.com/en-us/um/redmond/projects/hawaii/privacystatement.html";
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {

           Application.Run(new LoginForm());
        }

       
        
    }

}