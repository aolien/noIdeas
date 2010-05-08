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
        string race = string.Empty;
        int height_min = -1;
        int height_max = -1;
        int max_weight = -1;
        int min_weight = -1;
        string hair = string.Empty;
        string interest = string.Empty;
        int range = -1;
        
       

        #region Get/Set methods
               
       /// <summary>
       /// 1
       /// </summary>
        public string Hair
        {
            get { return hair; }
            set { hair = value; }
        }
       /// <summary>
       /// 2
       /// </summary>
        public int Max_Weight
        {
            get { return max_weight; }
            set { max_weight = value; }
        }
        /// <summary>
        /// 3
        /// </summary>
        public int Min_Weight
        {
            get { return min_weight; }
            set { min_weight = value; }
        }

        /// <summary>
        /// 4
        /// </summary>
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        
        /// <summary>
        /// 5
        /// </summary>
        public int Min_Age
        {
            get { return min_age; }
            set { min_age = value; }
        }
        /// <summary>
        /// 6
        /// </summary>
        public int Max_Age
        {
            get { return max_age; }
            set { max_age = value; }
        }
        /// <summary>
        /// 7
        /// </summary>
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        /// <summary>
        /// 8
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>
        /// 9
        /// </summary>
        public int Height_Max
        {
            get { return height_max; }
            set {height_max = value;}
        }
       /// <summary>
       /// 10
       /// </summary>
 
       public int Height_Min
        {
            get { return height_min; }
            set { height_min = value; }
        }
       /// <summary>
       /// 11
       /// </summary>
       public string Interest
       {
           get { return interest; }
           set { interest = value; }
       }

       public int Range
       {
           get { return range; }
           set { range = value; }
       }

        #endregion
       /// <summary>
       /// Default constructor
       /// </summary>
        public DatingProfile()
        { }
    
    }
}
