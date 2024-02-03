using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using SozlarJadvali.Models;
using SozlarJadvali.Models.Admins;
using SozlarJadvali.Models.Tokens;
using SozlarJadvali.Services.Admins;
using SozlarJadvali.Services.Tokens;

namespace SozlarJadvali.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class AdminController : RESTFulController
    {
        private readonly IAdminService adminService;
        private readonly ITokenService tokenService;

        public AdminController(
            IAdminService adminService, 
            ITokenService tokenService)
        {
            this.adminService = adminService;
            this.tokenService = tokenService;
        }

        [HttpPost("Register")]
        public async ValueTask<ActionResult<Admin>> RegisterAdmin(Admin admin)
        {
            return await this.adminService.AddAdminAsync(admin);
        }

        [HttpPost("Login")]
        public ActionResult<UserToken> Login(LoginAdmin loginAdmin)
        {
            IQueryable<Admin> AllAdmins = this.adminService.RetrieveAllAdmins();

            var result = AllAdmins.FirstOrDefault(retrievedUser =>
                retrievedUser.Email.Equals(loginAdmin.Email)
                    || retrievedUser.Password.Equals(loginAdmin.Password));

            if (result == null)
                return new UserToken
                {
                    Token = "Bunaqa foydalanuvchi mavjud emas!"
                };

            return this.tokenService.AddToken(result);
        }
    }
}