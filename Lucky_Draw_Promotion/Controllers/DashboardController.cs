using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly ICampaignService _campaignService;
        public DashboardController(IDashboardService dashboardService, ICampaignService campaignService)
        {
            _dashboardService = dashboardService;
            _campaignService = campaignService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Campaign>>> GetAllCampaign()
        {
            var getAll = await _campaignService.GetAllCampaign();
            return Ok(getAll);
        }
    }
    
}
