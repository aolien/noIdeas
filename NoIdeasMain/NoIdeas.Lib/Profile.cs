
namespace NoIdeas.Lib
{
    /// <summary>
    /// This class represents the User Profile
    /// </summary>
    public class Profile
    {
        string name = string.Empty;
        string lastName = string.Empty;
        string nickName = string.Empty;
        string sex = string.Empty;
        int age = -1;
        int online = -1;
        int race = -1;
        int height_ft = -1;
        int height_in = -1;
        int weight = -1;
        int hair = -1;
        int interest1 = -1;
        int interest2 = -1;
        int interest3 = -1;
        double distance = -1;
        double latitude = -1;
        double longitude = -1;

        #region Get/Set methods

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }


        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }


        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public int Interest3
        {
            get { return interest3; }
            set { interest3 = value; }
        }

        public int Interest2
        {
            get { return interest2; }
            set { interest2 = value; }
        }

        public int Interest1
        {
            get { return interest1; }
            set { interest1 = value; }
        }

        public int Hair
        {
            get { return hair; }
            set { hair = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Height_in
        {
            get { return height_in; }
            set { height_in = value; }
        }

        public int Height_ft
        {
            get { return height_ft; }
            set { height_ft = value; }
        }

        public int Race
        {
            get { return race; }
            set { race = value; }
        }

        public int Online
        {
            get { return online; }
            set { online = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        #endregion


        /// <summary>
        /// Default constructor
        /// </summary>
        public Profile()
        {
        }
        /// <summary>
        /// Constructor for testing 
        /// </summary>
        /// <param name="nickName"></param>
        /// <param name="distance"></param>
        /// <param name="latitude"></param>
        /// <param name="longidute"></param>
        public Profile(string nickName, double distance, double latitude, double longidute)
        {
            NickName = nickName;
            Distance = distance;
            Latitude = latitude;
            Longitude = longitude;
        }

        
    }
}
