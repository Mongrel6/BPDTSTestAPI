using System.Collections.Generic;
using System.Threading.Tasks;
using BPDTSTestAPI.Data;

namespace BPDTSTestAPI.Helpers
{
    public class GetUsersInRadiusOfLondon
    { 
        public static async Task<IEnumerable<User>> GetRadius(double mileRadius, string dataUrl)
        {
            //london coordinates 51.5074° N, 0.1278° W (assuming center point of London)

            double londonLatitude = 51.5074;
            double londonLongitude = 0.1278;

            var users = await HtmlReader.readUser(dataUrl);
            var usersWitinRadius = new List<User>();

            foreach (var user in users)
            {
                if (Haversine.Calculate(user.latitude, user.longitude, londonLatitude, londonLongitude) <= mileRadius)
                {
                    usersWitinRadius.Add(user);
                }
            }

            return usersWitinRadius;
        }

    }
}
