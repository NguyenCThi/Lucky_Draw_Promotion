using ClosedXML.Excel;
using Lucky_Draw_Promotion.DTO;
using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class WinnerController : ControllerBase
    {
        private readonly IWinnerService _winnerService;
        public WinnerController(DataContext context, IWinnerService winnerService)
        {
            _winnerService = winnerService;
        }
        [HttpGet("/winner/{campaignId}")]
        public async Task<ActionResult> GetAllWinnerByCampaignId(int campaignId)
        {
            var winners = await _winnerService.GetAllWinnerByCampaignId(campaignId);
            if(winners.Count == 0)
            {
                return BadRequest("There no winner yet for this campaign.");
            }
            return Ok(winners);
        }
        [HttpPut("/winner/send-gift-check/{winnerId}")]
        public async Task<ActionResult> ActiveSendGiftWinner(int winnerId)
        {
            var winner = await _winnerService.IsSendGift(winnerId);
            if(winner == 0)
            {
                return BadRequest("This winner not found.");
            }
            else if(winner == 1)
            {
                return BadRequest("This winner already receive they gift.");
            }
            else
            {
                return Ok("Winner set receive gift success.");
            }
        }
        [HttpPost("/winner/add-winner")]
        public async Task<ActionResult> AddNewWinner(AddNewWinnerDTO request)
        {
            var winner = await _winnerService.AddNewWinner(request);
            if(winner == 0)
            {
                return BadRequest("Error appear when add new winner.");
            }
            return Ok("Winner add success. The winner Id: " + winner);
        }
        [HttpPost("/winner/export-excel/{campaignId}")]
        public async Task<ActionResult> ExportWinnersByCampaignId(int campaignId)
        {
            var isCheck = await _winnerService.GetAllWinnerByCampaignId(campaignId);
            if(isCheck.Count == 0)
            {
                return BadRequest("There no winners on this campaign.");
            }
            else
            {
                var streamexport = await _winnerService.ExportExcelAllWinnerByCampaignId(campaignId);
                var content = streamexport.ToArray();
                var filename = "winner" + campaignId + ".xlsx";
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filename);
            }
        }
    }
}
