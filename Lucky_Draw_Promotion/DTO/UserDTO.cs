namespace Lucky_Draw_Promotion.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? OTPChangePass { get; set; }
    }
}
