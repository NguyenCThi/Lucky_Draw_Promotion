namespace Lucky_Draw_Promotion.DTO
{
    public class BarcodeDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string QrCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? ScannedDate { get; set; }
        public bool Scanned { get; set; }
        public bool Active { get; set; }
    }
}
