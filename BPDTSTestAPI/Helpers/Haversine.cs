using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPDTSTestAPI.Helpers
{
    public class Haversine
    {
        ///calculates the distance between two coordinates following the Haversine formula
        public static double Calculate(double userLatitude, double userLongitude, double londonLatitude, double londonLongitude)
        {
            var radius = 3958.8; // in miles
            var dLat = toRadians(londonLatitude - userLatitude);
            var dLon = toRadians(londonLongitude - userLongitude);
            userLatitude = toRadians(userLatitude);
            londonLatitude = toRadians(londonLatitude);

            var area =
                Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2) *
                Math.Cos(userLatitude) * Math.Cos(londonLatitude);

            var circumference = 2 * Math.Asin(Math.Sqrt(area));

            return radius * circumference;
        }

        private static double toRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
