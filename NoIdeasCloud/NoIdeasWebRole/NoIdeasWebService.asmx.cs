using System.Data;
using System.Web.Services;
using NoIdeas.Phone.Lib;
using NoIdeasServer.Lib;


namespace NoIdeasWebRole
{
    /// <summary>
    /// Summary description for NoIdeasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NoIdeasWebService : System.Web.Services.WebService
    {

        /// <summary>
        /// Creates/Updates the user profile in DB
        /// </summary>
        /// <param name="profile">User Profile </param>
        /// <returns>True/False</returns>
        [WebMethod]
        public bool UpdateProfile(Profile profile)
        {
            WorkerClass worker = new WorkerClass();
            return worker.UpdateProfile(profile);
             
           
        }
        /// <summary>
        /// Loads the dating profile to the DataBase 
        /// </summary>
        /// <param name="dprofile">Dating Profile</param>
        /// <returns>True/False</returns>
        [WebMethod]
        public bool LoadDatingProfile(DatingProfile dprofile)
        {
            WorkerClass worker = new WorkerClass();
            return worker.LoadDatingProfile(dprofile);
        }
        /// <summary>
        /// Deletes the dating profile from the DataBase 
        /// </summary>
        /// <param name="dprofile">Dating profile</param>
        /// <returns>True/False</returns>
        [WebMethod]
        public bool DeletedatingProfile(DatingProfile dprofile)
        {
            WorkerClass worker = new WorkerClass();
            return worker.DeletedateingProfile(dprofile);
        }

        /// <summary>
        /// Returns the DataTable with all people in the range 
        /// </summary>
        /// <param name="longitude">GPS longitude</param>
        /// <param name="latitude">GPS latitude</param>
        /// <returns>DataTable with all matches</returns>
        [WebMethod]
        public DataTable FindMatches(double longitude, double latitude)
        {
            WorkerClass worker = new WorkerClass();
            return worker.FindMatches(longitude, latitude);
        }
        /// <summary>
        /// Deletes the user with given Profile from the activeUser list 
        /// and updates the DataBase(isOnline off)
        /// </summary>
        /// <param name="profile">User profile</param>
        /// <returns>True/False</returns>
        [WebMethod]
        public bool EndSession(Profile profile)
        {
            WorkerClass worker = new WorkerClass();
            return worker.EndSession(profile);

        }

        /// <summary>
        /// Returns the number of Active users 
        /// </summary>
        /// <returns>the number of active users</returns>
        [WebMethod]
        public int GetNumberOfActiveUsers()
        {
            WorkerClass worker = new WorkerClass();
            return worker.NumberOfActiveUsers();
        }
    }
}
