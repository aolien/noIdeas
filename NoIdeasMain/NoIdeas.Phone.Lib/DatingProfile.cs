using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace NoIdeas.Phone.Lib
{
   public class DatingProfile
    {     
               
        string nickName = string.Empty;
        string sex = string.Empty;
        int min_age = -1;
        int max_age = -1;
        int race = -1;
        int min_height_ft = -1;
        int max_height_ft = -1;
        int min_height_in = -1;
        int max_height_in = -1;
        int max_weight = -1;
        int min_weight = -1;
        int hair = -1;
        int interest1 = -1;
        int interest2 = -1;
        int interest3 = -1;
        
       

        #region Get/Set methods


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

        public int Max_Weight
        {
            get { return max_weight; }
            set { max_weight = value; }
        }
        public int Min_Weight
        {
            get { return min_weight; }
            set { min_weight = value; }
        }

        public int Max_Height_in
        {
            get { return max_height_in; }
            set { max_height_in = value; }
        }
        public int Min_Height_in
        {
            get { return min_height_in; }
            set { min_height_in = value; }
        }

        public int Max_Height_ft
        {
            get { return max_height_ft; }
            set { max_height_ft = value; }
        }
        public int Min_Height_ft
        {
            get { return min_height_ft; }
            set { min_height_ft = value; }
        }

        public int Race
        {
            get { return race; }
            set { race = value; }
        }
        

        public int Min_Age
        {
            get { return min_age; }
            set { min_age = value; }
        }

        public int Max_Age
        {
            get { return max_age; }
            set { max_age = value; }
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
        public DatingProfile()
        { }
    
    }
}
