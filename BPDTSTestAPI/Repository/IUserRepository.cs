using System.Collections.Generic;
using System.Threading.Tasks;
using BPDTSTestAPI.Data;

namespace BPDTSTestAPI.Repository
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetLondonUsers();
        public Task<IEnumerable<User>> GetWithinLondonRadius();
    }
}
