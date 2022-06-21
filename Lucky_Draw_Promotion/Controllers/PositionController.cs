using Lucky_Draw_Promotion.DTO;
using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService _positionService;
        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }
        [HttpGet("/position")]
        public async Task<ActionResult> GetAllPosition()
        {
            var positions = await _positionService.GetAllPositionAsync();
            return Ok(positions);
        }
        [HttpGet("/position/{id}")]
        public async Task<ActionResult> GetPositionById(int id)
        {
            var position = await _positionService.GetPositionById(id);
            if(position == null)
            {
                return BadRequest("Position not found.");
            }
            return Ok(position);
        }
        [HttpPost("/position/create-new-position")]
        public async Task<ActionResult> CreateNewPosition([FromForm]CreateNewPositionDTO request)
        {
            var positionId = await _positionService.CreateNewPosition(request);
            if(positionId == 0)
            {
                return BadRequest("Error appear when create new position.");
            }
            var positionInfo = await _positionService.GetPositionById(positionId);
            return Ok(positionInfo);
        }
        [HttpPut("/position/edit-position/{id}")]
        public async Task<ActionResult> EditPosition(int id, [FromForm]string positionName)
        {
            var positionId = await _positionService.EditPosition(id, positionName);
            if(positionId == 0)
            {
                return BadRequest("Position not found.");
            }
            var positionInfo = await _positionService.GetPositionById(positionId);
            return Ok(positionInfo);
        }
        [HttpDelete("/position/delete-position/{id}")]
        public async Task<ActionResult> DeletePositionById([FromForm]int id)
        {
            var isDelete = await _positionService.DeletePosition(id);
            if(isDelete == 0)
            {
                return BadRequest("Position not found.");
            }
            return Ok("Position have been delete.");
        }
    }
}
