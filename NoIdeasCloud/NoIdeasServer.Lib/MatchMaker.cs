using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NoIdeas.Phone.Lib;
using System.Data;
using System.Data.SqlTypes;

namespace NoIdeasServer.Lib
{
    public class MatchMaker
    {
        private string connectionString = "Data Source=m67qyuncah.database.windows.net; Initial Catalog =noIdeas; User Id=NoIdeas; Password=P@ssW0rd!;";
        DataBaseWorker db;

        public double matchPercentage(String user1, String user2)
        {
            db = new DataBaseWorker(connectionString);
            //get each users profile information
            Profile userOne = new Profile();
            userOne = loadProfileFromDB(user1, userOne);
            Profile userTwo = new Profile();
            userTwo = loadProfileFromDB(user2, userTwo);
            DatingProfile userOneWants = new DatingProfile();
            userOneWants = loadDatingProfileFromDB(user1, userOneWants);
            DatingProfile userTwoWants = new DatingProfile();
            userTwoWants = loadDatingProfileFromDB(user1, userTwoWants);

            //keep a running total of the total points
            double total_points = 0;

            //If height is in range add points (MAX 10)
            //check if userOne is in userTwos range
            if (userOne.Height_ft >= userTwoWants.Min_Height_ft && userOne.Height_ft <= userTwoWants.Max_Height_ft &&
                userOne.Height_in >= userTwoWants.Min_Height_in && userOne.Height_in <= userTwoWants.Min_Height_in)
            {
                total_points += 10;
            }
            //check if userTwo is in userOnes range



            if (userTwo.Height_ft >= userOneWants.Min_Height_ft && userTwo.Height_ft <= userOneWants.Max_Height_ft &&
                userTwo.Height_in >= userOneWants.Min_Height_in && userTwo.Height_in <= userOneWants.Min_Height_in)
            {
                total_points += 10;
            }


            //If weight is in range add points (MAX 10)
            //check if userOne is in userTwos range
            if (userOne.Weight >= userTwoWants.Min_Weight && userOne.Weight <= userTwoWants.Max_Weight)
            {
                total_points += 10;
            }
            //check if userTwo is in userOnes range
            if (userTwo.Weight >= userOneWants.Min_Weight && userTwo.Weight <= userOneWants.Max_Weight)
            {
                total_points += 10;
            }

            //If age is in range add points (MAX 10)
            //check if userOne is in userTwos range
            if (userOne.Age >= userTwoWants.Min_Age && userOne.Age <= userTwoWants.Max_Age)
            {
                total_points += 10;
            }
            //check if userTwo is in userOnes range
            if (userTwo.Age >= userOneWants.Min_Age && userTwo.Age <= userOneWants.Max_Age)
            {
                total_points += 10;
            }

            //10 points for race match
            if (userOne.Race == userTwoWants.Race)
            {
                total_points += 10;
            }
            if (userTwo.Race == userOneWants.Race)
            {
                total_points += 10;
            }

            //10 points for hair match
            if (userOne.Hair == userTwoWants.Hair)
            {
                total_points += 10;
            }
            if (userTwo.Hair == userOneWants.Hair)
            {
                total_points += 10;
            }

            //10 points for each matching interest
            if (userOne.Interest1 == userTwoWants.Interest1)
            {
                total_points += 10;
            }
            if (userTwo.Interest1 == userOneWants.Interest1)
            {
                total_points += 10;
            }
            //interest 2
            if (userOne.Interest2 == userTwoWants.Interest2)
            {
                total_points += 10;
            }
            if (userTwo.Interest2 == userOneWants.Interest2)
            {
                total_points += 10;
            }
            //interest 3
            if (userOne.Interest3 == userTwoWants.Interest3)
            {
                total_points += 10;
            }
            if (userTwo.Interest3 == userOneWants.Interest3)
            {
                total_points += 10;
            }

            return Math.Round((total_points / 160) * 100, 2);
        }


        public Profile loadProfileFromDB(string userName, Profile userProfile)
        {
            //open the DB connection
            db.OpenConnection();

            //exec the query to the users information
            DataTable userInfo = db.ExecuteSQL("SELECT * FROM userInfo WHERE nickname='" + userName + "';");

            //assign all the vars in the class
            userProfile.NickName  = userName;
            userProfile.Sex       = (string)userInfo.Rows[0]["sex"];
            userProfile.Weight    = (int)userInfo.Rows[0]["weight"];
            userProfile.Age       = (int)userInfo.Rows[0]["age"];
            userProfile.Race      = (int)(userInfo.Rows[0]["race"]);
            userProfile.Hair      = (int)userInfo.Rows[0]["hair"];
            userProfile.Height_ft = (int)userInfo.Rows[0]["height_ft"];
            userProfile.Height_in = (int)userInfo.Rows[0]["height_in"];
            userProfile.Interest1 = (int)userInfo.Rows[0]["interest_1"];
            userProfile.Interest2 = (int)userInfo.Rows[0]["interest_2"];
            userProfile.Interest3 = (int)userInfo.Rows[0]["interest_3"];

            //close the DB connection
            db.CloseConnection();

            //return a reference to the newly filled Profile
            return userProfile;
        }

        public DatingProfile loadDatingProfileFromDB(string userName, DatingProfile dateProfile)
        {
            //open the DB connection
            db.OpenConnection();

            //exec the query to the users dating Ad
            DataTable userInfo = db.ExecuteSQL("SELECT * FROM datingAds WHERE nickname='" + userName + "';");

            //assign all the vars in the class
            dateProfile.NickName      = userName;
            dateProfile.Sex           = (string)userInfo.Rows[0]["sex"];
            dateProfile.Max_Weight    = (int)userInfo.Rows[0]["max_weight"];
            dateProfile.Min_Weight    = (int)userInfo.Rows[0]["min_weight"];
            dateProfile.Max_Age       = (int)userInfo.Rows[0]["max_age"];
            dateProfile.Min_Age       = (int)userInfo.Rows[0]["min_age"];
            dateProfile.Race          = (int)(userInfo.Rows[0]["race"]);
            dateProfile.Hair          = (int)userInfo.Rows[0]["hair"];
            dateProfile.Max_Height_ft = (int)userInfo.Rows[0]["max_height_ft"];
            dateProfile.Min_Height_ft = (int)userInfo.Rows[0]["min_height_ft"];
            dateProfile.Max_Height_in = (int)userInfo.Rows[0]["max_height_in"];
            dateProfile.Min_Height_in = (int)userInfo.Rows[0]["min_height_in"];
            dateProfile.Interest1     = (int)userInfo.Rows[0]["interest_1"];
            dateProfile.Interest2     = (int)userInfo.Rows[0]["interest_2"];
            dateProfile.Interest3     = (int)userInfo.Rows[0]["interest_3"];

            //close the DB connection
            db.CloseConnection();

            //return a reference to the newly filled datingProfile
            return dateProfile;
        }
    }
}
