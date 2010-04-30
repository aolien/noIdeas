using System.Collections.Generic;
using System.Configuration;
using System.Data;
using NoIdeas.Phone.Lib;
using System.Text;
using System;

namespace NoIdeasServer.Lib
{
    /// <summary>
    /// This is the main worker class for the Service 
    /// </summary>
    public class WorkerClass
    {
        public static HashSet<User> activeUsers = new HashSet<User>();
        private string connectionString = "Data Source=m67qyuncah.database.windows.net; Initial Catalog =noIdeas; User Id=NoIdeas; Password=P@ssW0rd!;";
        private DataBaseWorker db;

        /// <summary>
        /// Default constructor; Initialize the DB connector 
        /// </summary>
        public WorkerClass()
        {
             db = new DataBaseWorker(connectionString);
        }

        /// <summary>
        /// Checks if the user has an account; If true set online in DataBase to true 
        /// and adds user to the activeUser Set; else adds user information to the DataBase and 
        /// to the active user Set
        /// </summary>
        /// <param name="profile">User Profile</param>
        /// <returns>True/False</returns>
        public bool UpdateProfile(Profile profile)
        {
            // Create User from Profile in order to store in activeUsers HashSet
            User user = ProfileToUser(profile);
            // Since activeUser is a set - we don't have to check for duplicates
            //(We overrided Equal and GetHashCode for the User class) 
            activeUsers.Add(user);
            int result = 0;
            try
            {
                db.OpenConnection();
                // Check if the user info is already in DB
               DataTable dt = db.ExecuteSQL(CheckForUserQuery(profile));
               if (dt.Rows.Count == 0)
               // It's a new user we will need enter his information to DB
               {
                 result = db.ExecuteSql(InsertNewUserQuery(profile));
               }
               // It's existing user all we need to do change online bit to be true  
               else
               {
                  result = db.ExecuteSql(UpdateUserQuery(profile, 1));             
               }
            }
            catch (Exception ex)
            {

            }
            // No matter what happed we need to close DataBase connection
            finally
            {
                db.CloseConnection();
            }
            if (result == 1)
                return true;
            else 
                return false;
        }
        /// <summary>
        /// Returns the DataTable with users in the specified distance range
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        public DataTable FindMatches(double longitude, double latitude)
        {
            DataTable dt = new DataTable();
            return dt;
        }
        /// <summary>
        /// Deletes the user form the activeUser set and change the online status in DataBase
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        public bool EndSession(Profile profile)
        {
            User user = ProfileToUser(profile);
            // Remove user from the Active Users set 
            activeUsers.Remove(user);
            // Turn off theonline bit in DB 
            int result = 0;
            try
            {
                db.OpenConnection();
                result = db.ExecuteSql(UpdateUserQuery(profile, 0));
            }
            catch (Exception ex)
            { }
            // No matter what - we have to close DataBase connection
            finally
            {
                db.CloseConnection();
            }
            if (result == 1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Returns the number of active Users
        /// </summary>
        /// <returns>number of active Users</returns>
        public int NumberOfActiveUsers()
        {
            return activeUsers.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateProfile"></param>
        /// <returns></returns>
        public bool LoadDatingProfile(DatingProfile dateProfile)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("INSERT INTO [noIdeas].[dbo].[datingAds] " +
              "([username],[sex],[min_age],[max_age],[race]" +
              ",[min_height_ft],[min_height_in],[max_height_ft],[max_height_in] " +
              ",[min_weight],[max_weight],[hair],[interest_1] ,[interest_2] " +
              ",[interest_3]) " +
              " VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}','{12}','{13}','{14}')",
              dateProfile.NickName, dateProfile.Sex, dateProfile.Min_Age, dateProfile.Max_Age, dateProfile.Race,
              dateProfile.Min_Height_ft, dateProfile.Min_Height_in,dateProfile.Max_Height_ft, dateProfile.Max_Height_in,
              dateProfile.Min_Weight, dateProfile.Max_Weight,dateProfile.Hair,dateProfile.Interest1, dateProfile.Interest2, dateProfile.Interest3);
            int result = -1;
            try
            {
                db.OpenConnection();
                result = db.ExecuteSql(sql.ToString());
            }
            catch (Exception ex)
            {
            }
            finally
            {
                db.CloseConnection();
            }
            if (result == 1)
                return true;
            else 
                return false; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateProfile"></param>
        /// <returns></returns>
        public bool DeletedateingProfile(DatingProfile dateProfile)
        {
            int result = -1;
            string sql = string.Empty;
            string.Format("DELETE FROM [noIdeas].[dbo].[datingAds] WHERE username = '{0}'",dateProfile.NickName);
            try
            {
                db.OpenConnection();
                result = db.ExecuteSql(sql);
            }
            catch { }
            finally
            {
                db.CloseConnection();
            }
            if (result == 1)
                return true;
            else
                return false;
        }
        
        
        
        /// <summary>
        /// Returns the query to checj if the user's info is alredy in DB (means existing user)
        /// </summary>
        /// <param name="profile">User profile</param>
        /// <returns>sql query</returns>
        private string CheckForUserQuery(Profile profile)
        {
            string sql = string.Format("Select * From [noIdeas].[dbo].[userInfo] Where nickname ='{0}' ",profile.NickName);
            return sql;
        }
        /// <summary>
        /// Returns the query to insert new user Info into the DB
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        private string InsertNewUserQuery(Profile profile)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("INSERT INTO [noIdeas].[dbo].[userInfo]" +
                "([nickname],[firstname],[lastname],[sex],[age],[online],[race],[height_ft],[height_in], " +
                "[weight],[hair],[interest_1],[interest_2],[interest_3],[password],[phone_number]) " +
                "VALUES ('{0}','{1}', '{2}', '{3}','{4}','{5}', '{6}', '{7}', '{8}','{9}','{10}','{11}', '{12}','{13}', '{14}', '{15}' )",
                profile.NickName, profile.Name, profile.LastName, profile.Sex, profile.Age, profile.Online, profile.Race,
                profile.Height_ft, profile.Height_in, profile.Weight, profile.Hair, profile.Interest1, profile.Interest2, profile.Interest3, profile.Password, profile.Phone);

            return sql.ToString();
        }
       
        /// <summary>
        /// Helper method which returns the sql stetament for Updating user Info  
        /// </summary>
        /// <returns></returns>
        private string UpdateUserQuery(Profile profile, int online)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("UPDATE [noIdeas].[dbo].[userInfo] " +
                "SET [online] = '{0}' Where nickname = '{1}' ",online, profile.NickName);  
            
            return sql.ToString();
        }
        
        /// <summary>
        /// Creates User object from the Profile
        /// </summary>
        /// <param name="profile">Profile</param>
        /// <returns>User</returns>
        private User ProfileToUser(Profile profile)
        {
            string nickName = profile.NickName;
            double distanceRange = profile.Distance;
            double latitude = profile.Latitude;
            double longitude = profile.Longitude;
            // Create new User
            User user = new User(nickName, distanceRange, latitude, longitude);
            return user;
        }

    }
}
