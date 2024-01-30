using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using SozlarJadvali.Models.Users;
using SozlarJadvali.Services.Users;

namespace SozlarJadvali.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class UserController : RESTFulController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("Add-User")]
        public async ValueTask<ActionResult<User>> PostUser(User user)
        {
            return await this.userService.AddUserAsync(user);
        }

        [HttpGet("Get-All-Users")]
        [Authorize]
        public ActionResult<User> GetAllUsers()
        {
            IQueryable<User> AllUsers =  
                this.userService.RetrieveAllUsers();

            return Ok(AllUsers);
        }

        [HttpDelete("Delete-User")]
        [Authorize]
        public async ValueTask<ActionResult<User>> DeleteUser(User user)
        {
            return await this.userService.RemoveUserAsync(user);
        }
    }
}
