using System.Collections.Generic;
using System.Threading.Tasks;
using BPDTSTestAPI.Data;
using BPDTSTestAPI.Helpers;

namespace BPDTSTestAPI.Repository
{
    public class UserRepository : IUserRepository
    {

        private static string LondonUsers = @"https://bpdts-test-app.herokuapp.com/city/London/users";
        private static string AllUsers = @"https://bpdts-test-app.herokuapp.com/users";

        public async Task<IEnumerable<User>> GetLondonUsers()
        {
            ///appears api call data is false coordinates seem to be anywhere but London
            ///setting radius returns correct London coordinates.
            ///however task is to "returns people who are listed as either living in London" so this may not mean accurate data in terms of coordinates, just data marked as London.
            ///so this returns the data behind URL listed as "London/users"
            
            return await HtmlReader.readUser(LondonUsers);
            ///return await GetUsersInRadiusOfLondon.GetRadius(x, AllUsers); //- where x is acceptable mile radius outside of center of London for acceptable coordinate accuracy
        }

        public async Task<IEnumerable<User>> GetWithinLondonRadius()
        {
            ///This will cover task "whose current coordinates are within 50 miles of London"
            ///Assumption: London is center. If wanting 50 miles plus Greater London will need to change to 50+45 (45 mile radius taken from https://www.britannica.com/place/Greater-London)
            return await GetUsersInRadiusOfLondon.GetRadius(50, AllUsers);
        }

    }
}
