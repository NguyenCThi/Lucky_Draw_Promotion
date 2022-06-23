using IronBarCode;
using Lucky_Draw_Promotion.DTO;
using ZXing.QrCode;

namespace Lucky_Draw_Promotion.Services
{
    public class BarcodeService : IBarcodeService
    {
        private readonly DataContext _dataContext;
        public BarcodeService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> ActiveBarcode(int id)
        {
            Barcode? barcode = await _dataContext.Barcodes.FindAsync(id);
            if (barcode == null)
            {
                return 0;
            }
            if (barcode.Scanned == true)
            {
                return 1;
            }
            else
            {
                if (barcode.Active == false)
                {
                    barcode.Active = true;
                }
                else
                {
                    barcode.Active = false;

                }
            }
            _dataContext.Barcodes.Update(barcode);
            await _dataContext.SaveChangesAsync();
            return 2;
        }

        public async Task<int> CreateNewBarcode(CreateBarcodeDTO request)
        {
            try
            {
                
                for(int i = 0; i < request.CodeCount; i++)
                {
                    if (request.CharsetId == 1)
                    {
                        Barcode barcode = new Barcode();
                        barcode.CodeRedemptionLimit = request.CodeRedemptionLimit;
                        barcode.Unlimited = request.Unlimited;
                        barcode.CodeLength = request.CodeLength;
                        string prefixB = request.Prefix;
                        string postfixB = request.Postfix;
                        if (prefixB == null)
                        {
                            prefixB = "";
                        }
                        if (postfixB == null)
                        {
                            postfixB = "";
                        }
                        barcode.Prefix = prefixB;
                        barcode.Postfix = postfixB;
                        barcode.CampaignId = request.CampaignId;
                        barcode.CharsetId = request.CharsetId;
                        
                        int prefixL = prefixB.Length;
                        int postfixL = postfixB.Length;
                        int randomBarcodeLength = request.CodeLength - (prefixL + postfixL);
                        var chars = "123456789";
                        var stringChars = new char[randomBarcodeLength];
                        var randomGenerated = new Random();
                        for (int j = 0; j < stringChars.Length; j++)
                        {
                            stringChars[j] = chars[randomGenerated.Next(chars.Length)];
                        }
                        var randomNumber = new String(stringChars);
                        var finalRandomBarcode = prefixB + randomNumber.ToString() + postfixB;
                        barcode.CodeGenerated = finalRandomBarcode.ToUpper();
                        barcode.CreatedDate = DateTime.Now;
                        barcode.Scanned = false;
                        barcode.Active = false;
                        barcode.UsedForSpin = false;
                        _dataContext.Barcodes.Add(barcode);
                        await _dataContext.SaveChangesAsync();
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public Task<List<BarcodeDTO>> GetAllBarcodeByCampaignId(int id)
        {
            var barcode = _dataContext.Barcodes.Where(b => b.CampaignId == id).ToList();
            var viewBarcode = new List<BarcodeDTO>();
            foreach (var barcodes in barcode)
            {
                BarcodeDTO barcodeDTO = new BarcodeDTO();
                barcodeDTO.Id = barcodes.BarcodeId;
                barcodeDTO.Code = barcodes.CodeGenerated;
                GeneratedBarcode barcodeGenerated = BarcodeWriter.CreateBarcode(barcodes.CodeGenerated, BarcodeWriterEncoding.Code128);
                barcodeDTO.Barcode = Convert.ToBase64String(barcodeGenerated.ToPngBinaryData());
                GeneratedBarcode qrGenerated = QRCodeWriter.CreateQrCode(barcodes.CodeGenerated);
                barcodeDTO.QrCode = Convert.ToBase64String(qrGenerated.ToPngBinaryData());
                barcodeDTO.CreatedDate = barcodes.CreatedDate;
                barcodeDTO.ExpiredDate = barcodes.ExpiredDate;
                barcodeDTO.ScannedDate = barcodes.ScannedDate;
                barcodeDTO.Scanned = barcodes.Scanned;
                barcodeDTO.Active = barcodes.Active;
                viewBarcode.Add(barcodeDTO);
            }
            return Task.FromResult(viewBarcode);
        }

        public async Task<BarcodeDTO> GetBarcodeById(int id)
        {
            var barcodeDatabase = await _dataContext.Barcodes.FindAsync(id);
            var barcode = new BarcodeDTO();
            if (barcodeDatabase != null)
            {
                barcode.Id = id;
                barcode.ExpiredDate = barcodeDatabase.ExpiredDate;
                barcode.ScannedDate = barcodeDatabase.ScannedDate;
                barcode.CreatedDate = barcodeDatabase.CreatedDate;
                barcode.Code = barcodeDatabase.CodeGenerated;
                GeneratedBarcode qrGenerated = QRCodeWriter.CreateQrCode(barcodeDatabase.CodeGenerated);
                barcode.QrCode = Convert.ToBase64String(qrGenerated.ToPngBinaryData());
                GeneratedBarcode barcodeGenerated = BarcodeWriter.CreateBarcode(barcodeDatabase.CodeGenerated, BarcodeWriterEncoding.Code128);
                barcode.Barcode = Convert.ToBase64String(barcodeGenerated.ToPngBinaryData());
                barcode.Scanned = barcodeDatabase.Scanned;
                barcode.Active = barcodeDatabase.Active;
            }
            return barcode;
        }
    }
    public interface IBarcodeService
    {
        Task<int> CreateNewBarcode(CreateBarcodeDTO request);
        Task<BarcodeDTO> GetBarcodeById(int id);
        Task<List<BarcodeDTO>> GetAllBarcodeByCampaignId(int id);
        Task<int> ActiveBarcode(int id);
    }
}
