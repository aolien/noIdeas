//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using NoIdeas.Lib;
//using System.Data;
//using System.Data.SqlTypes;

//namespace NoIdeasServer.Lib
//{
//    public class MatchMaker
//    {
       
//        public double matchPercentage(String user1, String user2)
//        {
//            //get each users profile information
//            Profile userOne = new Profile();
//            userOne = loadProfileFromDB(user1, userOne);
//            Profile userTwo = new Profile();
//            userTwo = loadProfileFromDB(user2, userTwo);

//            //keep a running total of the total points
//            double total_points = 0;
//            //need to get the information from the dating ads


//            db.Initialize(connectionString);
//            db.OpenConnection();
//            DataTable userOneRequests = db.ExecuteSQL("SELECT * FROM datingAds WHERE username='" + userOne.UserName + "';", "datingAds", 1);
//            DataTable userTwoRequests = db.ExecuteSQL("SELECT * FROM datingAds WHERE username='" + userTwo.UserName + "';", "datingAds", 1);
//            db.CloseConnection();

//            //string userNameFromDB = (string)userOneRequests.Rows[0]["username"];

//            //If height is in range add points (MAX 10)
//            //check if userOne is in userTwos range
//            if (userOne.HeightFt >= (int)userTwoRequests.Rows[0]["min_height_ft"] && userOne.HeightFt <= (int)userTwoRequests.Rows[0]["max_height_ft"] &&
//                userOne.HeightIn >= (int)userTwoRequests.Rows[0]["min_height_in"] && userOne.HeightIn <= (int)userTwoRequests.Rows[0]["max_height_in"])
//            {
//                total_points += 10;
//            }
//            //check if userTwo is in userOnes range



//            if (userTwo.HeightFt >= (int)userOneRequests.Rows[0]["min_height_ft"] && userTwo.HeightFt <= (int)userOneRequests.Rows[0]["max_height_ft"] &&
//                userTwo.HeightIn >= (int)userOneRequests.Rows[0]["min_height_in"] && userTwo.HeightIn <= (int)userOneRequests.Rows[0]["max_height_in"])
//            {
//                total_points += 10;
//            }


//            //If weight is in range add points (MAX 10)
//            //check if userOne is in userTwos range
//            if (userOne.Weight >= (int)userTwoRequests.Rows[0]["min_weight"] && userOne.Weight <= (int)userTwoRequests.Rows[0]["max_weight"])
//            {
//                total_points += 10;
//            }
//            //check if userTwo is in userOnes range
//            if (userTwo.Weight >= (int)userOneRequests.Rows[0]["min_weight"] && userTwo.Weight <= (int)userOneRequests.Rows[0]["max_weight"])
//            {
//                total_points += 10;
//            }

//            //If age is in range add points (MAX 10)
//            //check if userOne is in userTwos range
//            if (userOne.Age >= (int)userTwoRequests.Rows[0]["min_age"] && userOne.Age <= (int)userTwoRequests.Rows[0]["max_age"])
//            {
//                total_points += 10;
//            }
//            //check if userTwo is in userOnes range
//            if (userTwo.Age >= (int)userOneRequests.Rows[0]["min_age"] && userTwo.Age <= (int)userOneRequests.Rows[0]["max_age"])
//            {
//                total_points += 10;
//            }

//            //10 points for race match
//            if (userOne.Race == (int)userTwoRequests.Rows[0]["race"])
//            {
//                total_points += 10;
//            }
//            if (userTwo.Race == (int)userOneRequests.Rows[0]["race"])
//            {
//                total_points += 10;
//            }

//            //10 points for hair match
//            if (userOne.Hair == (int)userTwoRequests.Rows[0]["hair"])
//            {
//                total_points += 10;
//            }
//            if (userTwo.Hair == (int)userOneRequests.Rows[0]["hair"])
//            {
//                total_points += 10;
//            }

//            //10 points for each matching interest
//            if (userOne.Interest1 == (int)userTwoRequests.Rows[0]["interest_1"])
//            {
//                total_points += 10;
//            }
//            if (userTwo.Interest1 == (int)userOneRequests.Rows[0]["interest_1"])
//            {
//                total_points += 10;
//            }
//            //interest 2
//            if (userOne.Interest2 == (int)userTwoRequests.Rows[0]["interest_2"])
//            {
//                total_points += 10;
//            }
//            if (userTwo.Interest2 == (int)userOneRequests.Rows[0]["interest_2"])
//            {
//                total_points += 10;
//            }
//            //interest 3
//            if (userOne.Interest3 == (int)userTwoRequests.Rows[0]["interest_3"])
//            {
//                total_points += 10;
//            }
//            if (userTwo.Interest3 == (int)userOneRequests.Rows[0]["interest_3"])
//            {
//                total_points += 10;
//            }

//            return Math.Round((total_points / 160) * 100, 2);
//        }


//        public Profile loadProfileFromDB(string userName, Profile userProfile)
//        {

//            db.Initialize(connectionString);
//            db.OpenConnection();
//            DataTable userInfo = db.ExecuteSQL("SELECT * FROM userInfo WHERE nickname='" + userName + "';", "userInfo", 1);
//            userProfile.UserName = userName;
//            userProfile.Sex = (string)userInfo.Rows[0]["sex"];
//            userProfile.Weight = (int)userInfo.Rows[0]["weight"];
//            userProfile.Age = (int)userInfo.Rows[0]["age"];
//            //int tmp = (Byte)userInfo.Rows[0]["race"];
//            //must cast all tiny ints as byte then it should be able to convert to int
//            userProfile.Race = (int)(userInfo.Rows[0]["race"]);
//            userProfile.Hair = (int)userInfo.Rows[0]["hair"];
//            userProfile.HeightFt = (int)userInfo.Rows[0]["height_ft"];
//            userProfile.HeightIn = (int)userInfo.Rows[0]["height_in"];
//            userProfile.Interest1 = (int)userInfo.Rows[0]["interest_1"];
//            userProfile.Interest2 = (int)userInfo.Rows[0]["interest_2"];
//            userProfile.Interest3 = (int)userInfo.Rows[0]["interest_3"];

//            db.CloseConnection();

//            return userProfile;
//        }
//    }
//}
