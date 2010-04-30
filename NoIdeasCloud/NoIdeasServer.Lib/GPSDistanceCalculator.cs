using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoIdeasServer.Lib
{
    /// <summary>
    /// This class allows to calculate the distance between two GPS points using
    /// Haversine formula:
    /// R = earth’s radius (mean radius = 6,371km)
    /// Δlat = lat2− lat1
    /// Δlong = long2− long1
    /// a = sin²(Δlat/2) + cos(lat1).cos(lat2).sin²(Δlong/2)
    /// c = 2.atan2(√a, √(1−a))
    /// d = R.c
    /// (Note that angles need to be in radians to pass to trig functions).
    /// </summary>

    public class GPSDistanceCalculator
    {
        private double distance;

        /// <summary>
        /// The return type for the distance 
        /// </summary>
        public enum DistanceType { Miles, Kilometers };

        // Earth radius
        const double earthRadiusKM = 6378.7;  // Kilometers
        const double earthRadiusM = 3960;   // Miles

        /// <summary>
        /// Default constractor 
        /// </summary>
        public GPSDistanceCalculator() { }

        /// <summary>
        /// Calculate and returns the distance between to points in KM
        /// </summary>
        /// <param name="lat1">latitude of 1st point</param>
        /// <param name="lat2">latitude of 2nd point</param>
        /// <param name="long1">longitude of 1st point</param>
        /// <param name="long2">longitude of 2nd point</param>
        /// <returns>Distance in KM</returns>
        public double GetDistance(double lat1, double lat2, double long1, double long2, DistanceType type)
        {
            double radius = (type == DistanceType.Miles) ? earthRadiusKM : earthRadiusM;
            // Declare local variables
            double lat1Rad;
            double lat2Rad;
            double long1Rad;
            double long2Rad;
            double dlat;
            double dlong;
            // Convert angles to Radian
            lat1Rad = DegreeToRadian(lat1);
            lat2Rad = DegreeToRadian(lat2);
            long1Rad = DegreeToRadian(long1);
            long2Rad = DegreeToRadian(long2);
            dlat = lat2Rad - lat1Rad;
            dlong = long2Rad - long1Rad;
            double a = Math.Pow(Math.Sin(dlat / 2.0), 2.0) +
                   Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                   Math.Pow(Math.Sin(dlong / 2.0), 2.0);

            // Calculate c - great circle distance in Radians
            double c = 2.0 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1.0 - a));
            // Calculate Distance
            distance = radius * c;

            return distance;
        }

        /// <summary>
        /// Converts to Radians 
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
        /// <summary>
        /// Main Test method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Coordinates of Statue of Liberty
            double lat1 = 40.689167;
            double long1 = -74.044444;
            // Coordinates of  Golden Gate Bridge
            double lat2 = 37.819722;
            double long2 = -122.478611;

            // Expected distance 4100.7461912784374 in KM
            // Expected distance 2585.9436608746823 in Miles

            GPSDistanceCalculator dcalc = new GPSDistanceCalculator();
            Console.WriteLine(dcalc.GetDistance(lat1, lat2, long1, long2, DistanceType.Miles) + ": Miles");
            Console.WriteLine(dcalc.GetDistance(lat1, lat2, long1, long2, DistanceType.Kilometers) + ": Kilometers");
            Console.ReadLine();

        }

    }

}
