using ClosedXML.Excel;
using Lucky_Draw_Promotion.DTO;

namespace Lucky_Draw_Promotion.Services
{
    public class WinnerService : IWinnerService
    {
        private readonly DataContext _dataContext;
        public WinnerService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> AddNewWinner(AddNewWinnerDTO request)
        {
            try
            {
                Winner winner = new Winner();
                winner.WinDate = DateTime.Now;
                winner.SendGift = false;
                winner.GiftCodeId = request.GiftCodeId;
                winner.CustomerId = request.CustomerId;
                _dataContext.Winners.Add(winner);
                await _dataContext.SaveChangesAsync();
                return winner.WinnerId;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public async Task<MemoryStream> ExportExcelAllWinnerByCampaignId(int campaignId)
        {
            var winners = _dataContext.Winners.Where(x => x.GiftCode.Gift.CampaignId == campaignId).ToList();
            var winnersDTO = new List<ShowWinnerDTO>();
            foreach (var win in winners)
            {
                var customer = await _dataContext.Customers.FindAsync(win.CustomerId);
                ShowWinnerDTO winnerList = new ShowWinnerDTO();
                winnerList.FullName = customer.Fullname;
                winnerList.PhoneNo = customer.PhoneNumber;
                winnerList.Address = customer.Location;
                winnerList.WinDate = win.WinDate.ToString("dd/mm/yyyy");
                var code = await _dataContext.GiftCodes.FindAsync(win.GiftCodeId);
                winnerList.GiftCode = code.Code;
                var gift = await _dataContext.Gifts.FindAsync(code.GiftId);
                var product = await _dataContext.Products.FindAsync(gift.ProductId);
                winnerList.GiftName = product.ProductName;
                winnerList.IsSendGift = win.SendGift;
                winnersDTO.Add(winnerList);
            }
            using(var package = new XLWorkbook())
            {
                var sheet = package.Worksheets.Add("All winners in Id "+ campaignId);
                var currentRow = 1;
                sheet.Cell(currentRow, 1).Value = "Full Name";
                sheet.Cell(currentRow, 2).Value = "Phone Number"; 
                sheet.Cell(currentRow, 3).Value = "Address";
                sheet.Cell(currentRow, 4).Value = "Win Date";
                sheet.Cell(currentRow, 5).Value = "Gift Code";
                sheet.Cell(currentRow, 6).Value = "Gift Name";
                sheet.Cell(currentRow, 7).Value = "Send Gift";
                foreach(var win in winnersDTO)
                {
                    currentRow++;
                    sheet.Cell(currentRow, 1).Value = win.FullName;
                    sheet.Cell(currentRow, 2).Value = win.PhoneNo;
                    sheet.Cell(currentRow, 3).Value = win.Address;
                    sheet.Cell(currentRow, 4).Value = win.WinDate;
                    sheet.Cell(currentRow, 5).Value = win.GiftCode;
                    sheet.Cell(currentRow, 6).Value = win.GiftName;
                    sheet.Cell(currentRow, 7).Value = win.IsSendGift;
                }
                using(var stream = new MemoryStream())
                {
                    package.SaveAs(stream);
                    return stream;
                }
                    
            }
        }

        public async Task<List<ShowWinnerDTO>> GetAllWinnerByCampaignId(int campaignId)
        {
            var winners = _dataContext.Winners.Where(x => x.GiftCode.Gift.CampaignId == campaignId).ToList();
            var winnersDTO = new List<ShowWinnerDTO>();
            foreach (var win in winners)
            {
                var customer = await _dataContext.Customers.FindAsync(win.CustomerId);
                ShowWinnerDTO winnerList = new ShowWinnerDTO();
                winnerList.FullName = customer.Fullname;
                winnerList.PhoneNo = customer.PhoneNumber;
                winnerList.Address = customer.Location;
                winnerList.WinDate = win.WinDate.ToString("dd/mm/yyyy");
                var code = await _dataContext.GiftCodes.FindAsync(win.GiftCodeId);
                winnerList.GiftCode = code.Code;
                var gift = await _dataContext.Gifts.FindAsync(code.GiftId);
                var product = await _dataContext.Products.FindAsync(gift.ProductId);
                winnerList.GiftName = product.ProductName;
                winnerList.IsSendGift = win.SendGift;
                winnersDTO.Add(winnerList);
            }
            return winnersDTO;
        }

        public async Task<int> IsSendGift(int winnerId)
        {
            Winner? winner = await _dataContext.Winners.FindAsync(winnerId);
            if(winner == null)
            {
                return 0;
            }
            if(winner.SendGift == true)
            {
                return 1;
            }
            else
            {
                winner.SendGift = true;
                _dataContext.Winners.Update(winner);
                await _dataContext.SaveChangesAsync();
            }
            return 2;
        }
    }
    public interface IWinnerService
    {
        Task<List<ShowWinnerDTO>> GetAllWinnerByCampaignId (int campaignId);
        Task<int> IsSendGift(int winnerId);
        Task<int> AddNewWinner(AddNewWinnerDTO request);
        //Task<List<Winner>> SearchWinnerByWinDate();
        Task<MemoryStream> ExportExcelAllWinnerByCampaignId(int campaignId);
    }
}
