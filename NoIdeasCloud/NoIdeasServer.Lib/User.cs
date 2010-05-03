
namespace NoIdeasServer.Lib
{
    /// <summary>
    /// This class represent an active User with following information:
    /// name, distance range, current GPS latitude, current GPS longitude
    /// </summary>
    public class User : System.Object
    {
        private string nickName = string.Empty;
        private double distanceRange = -1;
        private double latitude = -1;
        private double longitude = -1;
        private int phone = -1;

        #region Get/Set methods
        public string UserNickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        public double DistanceRange
        {
            get { return distanceRange; }
            set { distanceRange = value; }

        }

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        
        #endregion

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="distance"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        public User(string nickName, double distance, double latitude, double longitude,int phone)
        {
            UserNickName = nickName;
            DistanceRange = distance;
            Latitude = latitude;
            Longitude = longitude;
            Phone = phone;
        }
        /// <summary>
        /// Override method to compare Users by the nickName
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            User user = (obj as User);
            if (user == null)
                return false;
            return this.nickName.Equals(user.nickName);
        }
        /// <summary>
        /// Override method to compare Users by the nickName
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return nickName.GetHashCode();
        }


    }
}
