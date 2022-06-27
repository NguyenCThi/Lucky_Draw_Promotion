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
    }
}
