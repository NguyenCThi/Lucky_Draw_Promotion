using Lucky_Draw_Promotion.DTO;

namespace Lucky_Draw_Promotion.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly DataContext _context;
        public CampaignService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> ActiveGiftCode(int giftCodeId)
        {
            //TODO
            GiftCode? giftCode = await _context.GiftCodes.FindAsync(giftCodeId);
            if (giftCode == null)
            {
                return 0;
            }
            if(giftCode.Active == false)
            {
                giftCode.Active = true;
                giftCode.ActiveDate = DateTime.Now;
            }
            else
            {
                giftCode.Active = false;
            }
            _context.GiftCodes.Update(giftCode);
            await _context.SaveChangesAsync();
            return giftCode.GiftCodeId;

        }

        public async Task<int> AddGift(int productId, int giftCodeCount, int campaignId)
        {
            //TODO
            var campaign = await _context.Campaigns.FindAsync(campaignId);
            Gift gifts = new Gift();
            gifts.ProductId = productId;
            gifts.CreatedDate = DateTime.Now;
            gifts.CampaignId = campaignId;
            _context.Gifts.Add(gifts);
            await _context.SaveChangesAsync();
            for (int i = 0; i < giftCodeCount; i++)
            {
                GiftCode giftCode = new GiftCode();
                string prefixC = campaign.Prefix;
                string postfixC = campaign.Postfix;
                if(prefixC == null)
                {
                    prefixC = "";
                }
                if(postfixC == null)
                {
                    postfixC = "";
                }
                int codeLengthC = campaign.CodeLength;
                int prefixLength = prefixC.Length;
                int postfixLength = postfixC.Length;
                int randomGeneratedLength = codeLengthC - (prefixLength + postfixLength);
                if (campaign.CharsetId == 1)
                {
                    var chars = "123456789";
                    var stringChars = new char[randomGeneratedLength];
                    var randomGenerated = new Random();
                    for (int j = 0; j < stringChars.Length; j++)
                    {
                        stringChars[j] = chars[randomGenerated.Next(chars.Length)];
                    }
                    var randomNumber = new String(stringChars);
                    var finalRandomGiftCode = prefixC + randomNumber.ToString() + postfixC;
                    giftCode.Code = finalRandomGiftCode;
                    giftCode.CreatedDate = DateTime.Now;
                    giftCode.Active = false;
                    giftCode.GiftId = gifts.GiftId;
                    _context.GiftCodes.Add(giftCode);
                    await _context.SaveChangesAsync();
                }
            }
            return gifts.GiftId;
        }

        public async Task<int> CreateBulkCampaign(CreateBulkCodeDTO request)
        {
            //TODO
            Campaign campaign = new Campaign();
            campaign.CampaignName = request.ProgramName;
            campaign.AutoUpdate = request.AutoUpdate;
            campaign.OnlyJoinOne = request.OnlyJoinOne;
            campaign.Description = request.Description;
            campaign.CodeUsageLimit = request.CodeUsageLimit;
            campaign.Unlimited = request.Unlimited;
            campaign.CodeCount= request.CodeCount;
            campaign.CodeLength = request.CodeLength;
            campaign.Prefix = request.Prefix;
            campaign.Postfix = request.Postfix;
            campaign.CharsetId = request.CharsetId;
            campaign.ProgramSizeId = 1;
            _context.Campaigns.Add(campaign);
            await _context.SaveChangesAsync();
            return campaign.CampaignId;
        }

        public async Task<int> CreateRuleForGift(CreateRuleForGiftDTO request)
        {
            //TODO
            RuleGift rule = new RuleGift();
            rule.RuleName = request.RuleName;
            rule.GiftId = request.GiftId;
            rule.GiftAmount = request.GiftAmount;
            rule.StartTime = request.StartTime;
            rule.EndTime = request.EndTime;
            rule.AllDay = request.AllDay;
            rule.Probability = request.Probability;
            if(request.MonthlyOnDay == true)
            {
                rule.MonthlyOnDay = request.MonthlyOnDay;
                rule.SelectDayForMonthlyOnDay = request.SelectDayMOD;
            }
            if(request.WeeklyOn == true)
            {
                rule.WeeklyOn = request.WeeklyOn;
                string ChooseDay = "";
                if (request.MonWO == true)
                    ChooseDay += "2";
                if (request.TueWO == true)
                    ChooseDay += "3";
                if (request.WedWO == true)
                    ChooseDay += "4";
                if (request.ThuWO == true)
                    ChooseDay += "5";
                if (request.FriWO == true)
                    ChooseDay += "6";
                if (request.SatWO == true)
                    ChooseDay += "7";
                if (request.SunWO == true)
                    ChooseDay += "8";
                rule.ChooseDayForWeeklyOn = ChooseDay;
            }
            if(request.RepeatDaily == true)
            {
                rule.RepeatDaily = request.RepeatDaily;
                rule.StartDateRD = request.StartDate;
                rule.EndDateRD = request.EndDate;
            }
            _context.RuleGifts.Add(rule);
            await _context.SaveChangesAsync();
            return rule.RuleId;
        }

        public async Task<int> CreateStandaloneCode(CreateStandaloneCodeDTO request)
        {
            //TODO
            Campaign campaign = new Campaign();
            campaign.CampaignName = request.CampaignName;
            campaign.ApplyForAllCampaign = request.ApplyForAllCampaign;
            campaign.Description = request.Description;
            campaign.CodeUsageLimit = request.CodeUsageLimit;
            campaign.Unlimited = request.Unlimited;
            campaign.CodeLength = request.CodeLength;
            campaign.Prefix = request.Prefix;
            campaign.Postfix= request.Postfix;
            campaign.CharsetId = request.CharsetId;
            campaign.ProgramSizeId = 2;
            _context.Campaigns.Add(campaign);
            await _context.SaveChangesAsync();
            return campaign.CampaignId;
        }

        public async Task<int> EditProduct(int productId, string productName, string productDescription)
        {
            //TODO
            Product product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return 0;
            }
            if (productName != null)
                product.ProductName = productName;
            if(productDescription != null)
                product.ProductDescription = productDescription;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return product.ProductId;
        }

        public async Task<List<Campaign>> GetAllCampaign()
        {
            //TODO
            return await _context.Campaigns.ToListAsync();
        }

        public Task<List<GiftCode>> GetAllGiftCodeByGiftId(int giftId)
        {
            //TODO
            var giftCodes = _context.GiftCodes.Where(x => x.GiftId == giftId).ToList();
            return Task.FromResult(giftCodes);
        }

        public Task<List<Gift>> GetAllGiftFromCampaignId(int campaignId)
        {
            //TODO
            var gifts = _context.Gifts.Where(x => x.CampaignId == campaignId).ToList();
            return Task.FromResult(gifts);


        }

        public async Task<Campaign> GetCampaignById(int campaignId)
        {
            //TODO
            var campaign = await _context.Campaigns.FindAsync(campaignId);
            return campaign;
        }

        public async Task<GiftCode> GetGiftCodeById(int giftCodeId)
        {
            //TODO
            var giftcode = await _context.GiftCodes.FindAsync(giftCodeId);
            return giftcode;
        }

        public async Task<Product> GetProductById(int productId)
        {
            //TODO
            var product = await _context.Products.FindAsync(productId);
            return product;
        }

        public async Task<RuleGift> GetRuleById(int ruleId)
        {
            //TODO
            var rule = await _context.RuleGifts.FindAsync(ruleId);
            return rule;
        }

        public Task<List<Campaign>> SearchingCampaignByName(string campaignName)
        {
            //TODO
            var campaign = _context.Campaigns.Where(x => x.CampaignName.ToLower().Contains(campaignName.Trim().ToLower())).ToList();
            return Task.FromResult(campaign);
        }

        public Task<List<Product>> SearchingProductByName(string productName)
        {
            //TODO
            var product = _context.Products.Where(x => x.ProductName.ToLower().Contains(productName.Trim().ToLower())).ToList();
            return Task.FromResult(product);
        }

        public async Task<int> SetTimeFrame(int campaignId, SetTimeFrameDTO request)
        {
            //TODO
            Campaign campaign = await _context.Campaigns.FindAsync(campaignId);
            if(campaign == null)
            {
                return 0;
            }
            DateTime startDate = request.StartDate.Date.Add(request.EnterTimeSD.TimeOfDay);
            campaign.StartDate = startDate;
            DateTime endDate = request.EndDate.Date.Add(request.EnterTimeED.TimeOfDay);
            campaign.EndDate = endDate;
            _context.Campaigns.Update(campaign);
            await _context.SaveChangesAsync();
            return campaign.CampaignId;
        }
    }

    public interface ICampaignService
    {
        Task<List<Campaign>> GetAllCampaign();
        Task<int> CreateBulkCampaign(CreateBulkCodeDTO request);
        Task<int> CreateStandaloneCode(CreateStandaloneCodeDTO request);
        Task<Campaign> GetCampaignById(int campaignId);
        Task<int> SetTimeFrame(int campaignId, SetTimeFrameDTO request);
        Task<List<Gift>> GetAllGiftFromCampaignId(int campaignId);
        Task<int> AddGift(int productId, int giftCodeCount, int campaignId);
        Task<List<GiftCode>> GetAllGiftCodeByGiftId(int giftId);
        Task<int> ActiveGiftCode(int giftCodeId);
        Task<GiftCode> GetGiftCodeById(int giftCodeId);
        Task<int> CreateRuleForGift(CreateRuleForGiftDTO request);
        Task<RuleGift> GetRuleById(int ruleId);
        Task<List<Campaign>> SearchingCampaignByName(string campaignName);
        Task<int> EditProduct(int productId, string productName, string productDescription);
        Task<Product> GetProductById(int productId);
        Task<List<Product>> SearchingProductByName(string productName);
    }
}
