
namespace NoIdeas.Phone.Lib
{
    /// <summary>
    /// This class represents the User Profile
    /// </summary>
    public class Profile
    {
        string nickName = string.Empty;       
        string password = string.Empty;
        string lastName = string.Empty;
        string firstName = string.Empty;
        string sex = string.Empty;
        string hair = string.Empty;
        string race = string.Empty;
        string interest = string.Empty;
        int age = -1;
        int online = -1;
        int height = -1;
        int weight = -1;
        int phone = -1;
        double distance = -1;
        double latitude = 500;
        double longitude = 500;
        
        

        #region Get/Set methods
        /// <summary>
        /// 1
        /// </summary>
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        /// <summary>
        /// 2
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        /// <summary>
        /// 3
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        /// <summary>
        /// 4
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        /// <summary>
        /// 5
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>
        /// 6
        /// </summary>
        public string Hair
        {
            get { return hair; }
            set { hair = value; }
        }
        /// <summary>
        /// 7
        /// </summary>
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        /// <summary>
        /// 8
        /// </summary>
        public string Interest
        {
            get { return interest; }
            set { interest = value; }
        }
        /// <summary>
        /// 9
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// 10
        /// </summary>
        public int Online
        {
            get { return online; }
            set { online = value; }
        }
        /// <summary>
        /// 11
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>
        /// 12
        /// </summary>
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>
        /// 13
        /// </summary>

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>
        /// 14
        /// </summary>
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        /// <summary>
        /// 15
        /// </summary>
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        /// <summary>
        /// 16
        /// </summary>
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        #endregion


        /// <summary>
        /// Default constructor
        /// </summary>
        public Profile()
        {
        
        }
        
    }
}
