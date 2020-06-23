using BPDTSTestAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BPDTSTestAPI.Helpers
{
    public class HtmlReader
    {
        public static async Task<IEnumerable<User>> readUser(string Url)
        {
            List<User> userList = new List<User>();
            
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(Url);

            if (responseMessage.IsSuccessStatusCode)
            {
               return await responseMessage.Content.ReadAsAsync<IEnumerable<User>>();
            }

            return userList;
        }

    }
}
