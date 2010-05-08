using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace NoIdeas.Phone.Lib
{
    /// <summary>
    /// This class represent the MatchResult instance
    /// </summary>
    public class MatchedResults
    {
        string name = string.Empty;
        int phone = -1;
        double matchPercentage = -1;

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double MatchPercentage
        {
            get { return matchPercentage; }
            set { matchPercentage = value; }
        }

         /// <summary>
        /// Default constructor
        /// </summary>
        public MatchedResults()
        {
        }

    }
}
