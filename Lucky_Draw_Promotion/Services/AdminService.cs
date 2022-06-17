using Lucky_Draw_Promotion.DTO;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Lucky_Draw_Promotion.Services
{
    public interface IAdminService
    {
        string Login(AdminDTO request);
    }
    public class AdminService : IAdminService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public AdminService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
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
        public string Login(AdminDTO request)
        {
            //TODO
            var admin = _context.Admins.ToList().SingleOrDefault(x => x.Email == request.Email);
            string wrongEmail = "Email không tồn tại.";
            string wrongPassword = "Password sai.";
            if (admin == null)
            {
                return wrongEmail;
            }
            var hmac = new HMACSHA512(admin.PasswordSalt);
            var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(request.Password));
            if (!computeHash.SequenceEqual(admin.PasswordHash))
            {
                return wrongPassword;
            }
            string token = CreateToken(admin);
            return token;
        }
    }
}
