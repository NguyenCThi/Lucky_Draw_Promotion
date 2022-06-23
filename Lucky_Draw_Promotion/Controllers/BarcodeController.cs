using Lucky_Draw_Promotion.DTO;
using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class BarcodeController : ControllerBase
    {
        private readonly IBarcodeService _barcodeService;
        public BarcodeController(IBarcodeService barcodeService)
        {
            _barcodeService = barcodeService;
        }
        [HttpPost("/barcode/create-new-barcode")]
        public async Task<ActionResult> CreateBarcode([FromForm]CreateBarcodeDTO request)
        {
            var barcode = await _barcodeService.CreateNewBarcode(request);
            if(barcode == 0)
            {
                return BadRequest("Error appear when creating new barcode.");
            }
            return Ok("Barcode create success.");
        }
        [HttpGet("/barcode/{id}")]
        public async Task<ActionResult> GetBarcodeById(int id)
        {
            var barcode = await _barcodeService.GetBarcodeById(id);
            return Ok(barcode);
        }
        [HttpGet("/barcode/campaign/{campaignId}")]
        public async Task<ActionResult> GetAllBarcodeByCampaignId(int campaignId)
        {
            var barcodes = await _barcodeService.GetAllBarcodeByCampaignId(campaignId);
            return Ok(barcodes);
        }
        [HttpPut("/barcode/campaign/active/{id}")]
        public async Task<ActionResult> ActiveBarcode(int id)
        {
            var barcode = await _barcodeService.ActiveBarcode(id);
            if (barcode == 0)
                return BadRequest("This barcode not exists.");
            else if (barcode == 1)
                return BadRequest("This barcode already scanned.");
            var barcodeById = new BarcodeDTO();
            if (barcode == 2)
            {
                barcodeById = await _barcodeService.GetBarcodeById(id);
            }
            return Ok(barcodeById);
        }
    }
}
