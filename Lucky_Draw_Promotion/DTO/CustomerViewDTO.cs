namespace Lucky_Draw_Promotion.DTO
{
    public class CustomerViewDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? DateOfBirth { get; set; }
        public string? TypeOfBusiness { get; set; }
        public string? Location { get; set; }
        public bool Block { get; set; }
    }
}
