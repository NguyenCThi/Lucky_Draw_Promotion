using Lucky_Draw_Promotion.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AdminController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        


        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(AdminDTO request)
        {
            var admin = _context.Admins.ToList().SingleOrDefault(x=>x.Email == request.Email);
            if (admin == null)
            {
                return BadRequest("Email không tồn tại!");
            }
            var hmac = new HMACSHA512(admin.PasswordSalt);
            var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(request.Password));
            if (!computeHash.SequenceEqual(admin.PasswordHash))
            {
                return BadRequest("Sai mật khẩu!");
            }
            string token = CreateToken(admin);
            return Ok(token);
        }

        [HttpGet, Authorize]
        public async Task<ActionResult<List<Admin>>> Get()
        {
            return Ok(await _context.Admins.ToListAsync());
        }

        private string CreateToken(Admin admin)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, admin.FullName)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

        

    }
}
