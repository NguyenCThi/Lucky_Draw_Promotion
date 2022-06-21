using Lucky_Draw_Promotion.DTO;
using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CampaignController : ControllerBase
    {
        
        private readonly ICampaignService _service;
        public CampaignController(ICampaignService service)
        {
            
            _service = service;
        }
        // lấy tất cả dữ liệu campaign có trong database
        [HttpGet]
        public async Task<ActionResult<List<Campaign>>> GetAllCampaign()
        {
            var getAll = await _service.GetAllCampaign();
            return Ok(getAll);
        }
        
        // lấy campaign bằng id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCampaignById(int id)
        {
            var campaign = await _service.GetCampaignById(id);
            if(campaign == null)
            {
                return BadRequest("Campaign not found!");
            }
            return Ok(campaign);
        }

        [HttpPost("Bulk-Code")]
        public async Task<ActionResult> CreateBulkCodeCampaign([FromForm]CreateBulkCodeDTO request)
        {
            var campaignId = await _service.CreateBulkCampaign(request);
            if(campaignId == 0)
            {
                return BadRequest();
            }
            var campaign = await _service.GetCampaignById(campaignId);
            return CreatedAtAction(nameof(GetCampaignById), new {id = campaignId}, campaign);
        }

        [HttpPost("Standalone-Code")]
        public async Task<ActionResult> CreateStandaloneCodeCampaign([FromForm]CreateStandaloneCodeDTO request)
        {
            var campaignId = await _service.CreateStandaloneCode(request);
            if (campaignId == 0)
            {
                return BadRequest();
            }
            var campaign = await _service.GetCampaignById(campaignId);
            return CreatedAtAction(nameof(GetCampaignById), new { id = campaignId }, campaign);
        }

        [HttpPut("Set-time-frame")]
        public async Task<ActionResult> CampaignSetTimeFrame([FromForm]SetTimeFrameDTO request, int campaignId)
        {
            var setTimeSuccess = await _service.SetTimeFrame(campaignId, request);
            if(setTimeSuccess == 0)
            {
                return BadRequest();
            }
            return Ok(setTimeSuccess);
        }

        [HttpGet("/{campaignId}/gifts")]
        public async Task<ActionResult> GetGiftByCampaignId(int campaignId)
        {
            var gifts = await _service.GetAllGiftFromCampaignId(campaignId);
            if (gifts == null)
            {
                return Ok();
            }
            return Ok(gifts);
        }

        [HttpGet("/gifts/getGiftCode")]
        public async Task<ActionResult> GetAllGiftCodeByGiftId(int id)
        {
            var giftsCode = await _service.GetAllGiftCodeByGiftId(id);
            if (giftsCode == null)
            {
                return BadRequest("Gift code not found!");
            }
            return Ok(giftsCode);
        }


        [HttpPost("/gifts/create-gift")]
        public async Task<ActionResult> CreateGiftCodes(int campaignId, int productId, int giftCodeCount)
        {
            var giftId = await _service.AddGift(productId, giftCodeCount, campaignId);
            if (giftId == 0)
            {
                return BadRequest("Error appear when add gifts.");
            }
            var giftCode = await _service.GetAllGiftCodeByGiftId(giftId);
            return Ok(giftCode); 
        }
        [HttpGet("/gifts/gifts-code/{id}")]
        public async Task<ActionResult> GetGiftCode(int id)
        {
            var giftcode = await _service.GetGiftCodeById(id);
            if(giftcode == null)
            {
                return BadRequest("Gift code not found.");
            }
            return Ok(giftcode);
        }

        [HttpPut("/gifts/gifts-code/active")]
        public async Task<ActionResult> ActiveGiftCode(int id)
        {
            var giftCode = await _service.ActiveGiftCode(id);
            if(giftCode == 0)
            {
                return BadRequest("Gift code not found.");
            }
            var giftCodeResult = await _service.GetGiftCodeById(giftCode);
            return Ok(giftCodeResult);
        }

        [HttpPost("/rule-for-gift")]
        public async Task<ActionResult> AddRuleForGift([FromForm]CreateRuleForGiftDTO request)
        {
            var ruleId = await _service.CreateRuleForGift(request);
            if(ruleId == 0)
            {
                return BadRequest("An error appear when create the rule.");
            }
            var rule = await _service.GetRuleById(ruleId);
            return Ok(rule);
        }
        [HttpGet("/rule-for-gift/{id}")]
        public async Task<ActionResult> GetRule(int id)
        {
            var rule = await _service.GetRuleById(id);
            if (rule == null)
            {
                return BadRequest("rule not found.");
            }
            return Ok(rule);
        }

        [HttpGet("/campaign/search-by-name/{name}")]
        public async Task<ActionResult> GetCampaignByName(string name)
        {
            var campaign = await _service.SearchingCampaignByName(name);
            if (campaign == null)
            {
                return BadRequest("Campaign not found.");
            }
            return Ok(campaign);
        }

        [HttpGet("/product/{productId}")]
        public async Task<ActionResult> GetProductById (int productId)
        {
            var product = await _service.GetProductById(productId);
            if(product == null)
            {
                return BadRequest("Product not found.");
            }
            return Ok(product);
        }

        [HttpPut("/product/edit-product/{productId}")]
        public async Task<ActionResult> EditProductInfo(int productId, string productName, string productDescription)
        {
            var editProduct = await _service.EditProduct(productId, productName, productDescription);
            if (editProduct == 0)
            {
                return BadRequest("Product not found.");
            }
            var product = await _service.GetProductById(productId);
            return Ok(product);
        }
        [HttpGet("/product/search-by-name/{productName}")]
        public async Task<ActionResult> SearchProductByName(string productName)
        {
            var products = await _service.SearchingProductByName(productName);
            if (products == null)
            {
                return BadRequest("Product not found.");
            }
            return Ok(products);
        }
    }
}
