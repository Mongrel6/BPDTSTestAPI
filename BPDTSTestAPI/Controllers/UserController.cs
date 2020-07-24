using System.Collections.Generic;
using System.Threading.Tasks;
using BPDTSTestAPI.Data;
using BPDTSTestAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BPDTSTestAPI.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("[controller]/GetLondonUsers")]
        public async Task<IEnumerable<User>> GetLondonUsers()
        {
            return await _userRepo.GetLondonUsers();
        }

        [HttpGet]
        [Route("[controller]/GetWitinLondonRadiusUsers")]
        public async Task<IEnumerable<User>> GetWithinLondonRadius()
        {
            return await _userRepo.GetWithinLondonRadius();
        }

    }
}
