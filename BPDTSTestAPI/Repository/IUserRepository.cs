using BPDTSTestAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPDTSTestAPI.Repository
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetLondonUsers();
        public Task<IEnumerable<User>> GetWithinLondonRadius();
    }
}
