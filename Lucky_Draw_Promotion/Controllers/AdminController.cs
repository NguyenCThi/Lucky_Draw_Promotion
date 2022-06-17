using Lucky_Draw_Promotion.DTO;
using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using static Lucky_Draw_Promotion.Services.AdminService;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _service;
        

        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromForm]AdminDTO request)
        {
            var admin = _service.Login(request).ToString();
            
            if (admin == "Email không tồn tại.")
            {
                return BadRequest("Email không tồn tại!");
            }
            else if (admin == "Password sai.")
            {
                return BadRequest("Sai mật khẩu!");
            }
            else
            {
                return admin;
            }
        }

        

        

        

    }
}
