using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CampaignController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public CampaignController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        // lấy tất cả dữ liệu campaign có trong database
        [HttpGet]
        public async Task<ActionResult<List<Campaign>>> GetAllCampaign()
        {
            return Ok(await _context.Campaigns.ToListAsync());
        }

        // lấy dữ liệu campaign theo id
        [HttpGet("{id}")]
        public async Task<ActionResult<Campaign>> GetCampaign(int id)
        {
            var campaign = await _context.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return BadRequest("Không tìm thấy được campaign.");
            }
            return Ok(campaign);
        }

        // tạo 1 campaign
        [HttpPost]
        public async Task<ActionResult<List<Campaign>>> PostCampaign(CreateCampaign request)
        {
            Campaign campaign = new Campaign();
            campaign.CampaignName = request.CampaignName;
            campaign.ApplyForAllCampaign = request.ApplyForAllCampaign;
            campaign.CharsetId = request.CharsetId;
            campaign.AutoUpdate = request.AutoUpdate;
            campaign.CodeCount = request.CodeCount;
            campaign.CodeLength = request.CodeLength;
            campaign.CodeUsageLimit = request.CodeUsageLimit;
            campaign.Description = request.Description;
            campaign.StartDate = request.StartDate;
            campaign.EndDate = request.EndDate;
            campaign.Prefix = request.Prefix;
            campaign.Postfix = request.Postfix;
            campaign.ProgramSizeId = request.ProgramSizeId;
            campaign.Unlimited = request.Unlimited;
            _context.Campaigns.Add(campaign);
            await _context.SaveChangesAsync();
            return Ok(await _context.Campaigns.ToListAsync());
        }

        // xóa 1 campaign
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Campaign>>> DeleteCampaign(int id)
        {
            var dbCampaign = await _context.Campaigns.FindAsync(id);
            if(dbCampaign == null)
            {
                return BadRequest("Không tìm thấy Campaign.");
            }
            _context.Campaigns.Remove(dbCampaign);
            await _context.SaveChangesAsync();
            return Ok(await _context.Campaigns.ToListAsync());
        }

        // sửa 1 campaign
        [HttpPut]
        public async Task<ActionResult<List<Campaign>>> PutCampaign(UpdateCampaign campaign)
        {
            var dbCampaign = await _context.Campaigns.FindAsync(campaign.CampaignId);
            if(dbCampaign == null)
            {
                return BadRequest("Không tìm thấy Campaign.");
            }
            dbCampaign.CampaignName = campaign.CampaignName;
            dbCampaign.Description = campaign.Description;
            dbCampaign.CodeUsageLimit = campaign.CodeUsageLimit;
            await _context.SaveChangesAsync();
            return Ok(await _context.Campaigns.ToListAsync());
        }

    }
}
