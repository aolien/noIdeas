using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

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
            Application.Run(new HomeForm());
        }
    }
}