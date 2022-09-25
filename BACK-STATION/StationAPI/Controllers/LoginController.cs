using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StationAPI.Context;
using StationAPI.Models;

namespace StationAPI.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public LoginController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpPost]
        public async Task<IActionResult> SingUp(Auth auth)
        {
            var exists = await _dataContext.Auths
                .AnyAsync(x => x.userName.Equals(auth.userName) && x.password.Equals(auth.password));


            if (!exists)
                return StatusCode(401,401);

            return StatusCode(200,200);
        }
    }
}
