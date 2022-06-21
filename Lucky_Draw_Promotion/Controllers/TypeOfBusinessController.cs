using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class TypeOfBusinessController : ControllerBase
    {
        private readonly ITypeOfBusinessService _typeOfBusinessService;
        public TypeOfBusinessController(ITypeOfBusinessService typeOfBusinessService)
        {
            _typeOfBusinessService = typeOfBusinessService;
        }
        [HttpGet("/type-of-business")]
        public async Task<ActionResult> GetAllTOB()
        {
            var tobs = await _typeOfBusinessService.GetTypeOfBusinessAll();
            return Ok(tobs);
        }
        [HttpGet("/type-of-business/{id}")]
        public async Task<ActionResult> GetTOBById(int id)
        {
            var tob = await _typeOfBusinessService.GetTypeOfBusinessById(id);
            if(tob == null)
            {
                return BadRequest("Type Of Business not found.");
            }
            return Ok(tob);
        }
        [HttpPost("/type-of-business/create-new-type-of-business")]
        public async Task<ActionResult> CreateNewTypeOfBusiness(string tobName)
        {
            var tob = await _typeOfBusinessService.CreateNewTOB(tobName);
            if(tob == 0)
            {
                return BadRequest("Error appear when create new type of business.");
            }
            var tobInfo = await _typeOfBusinessService.GetTypeOfBusinessById(tob);
            return Ok(tobInfo);
        }
        [HttpPut("/type-of-business/edit-type-of-business/{id}")]
        public async Task<ActionResult> EditTypeOfBusiness(int id, [FromForm]string tobName)
        {
            var tob = await _typeOfBusinessService.EditTOB(id, tobName);
            if(tob == 0)
            {
                return BadRequest("Error appear when edit.");
            }
            var tobInfo = await _typeOfBusinessService.GetTypeOfBusinessById(tob);
            return Ok(tobInfo);
        }
        [HttpDelete("/type-of-business/delete-type-of-business/{id}")]
        public async Task<ActionResult> DeleteTypeOfBusiness([FromForm]int id)
        {
            var tob = await _typeOfBusinessService.DeleteTOB(id);
            if(tob == 0)
            {
                return BadRequest("Type of business not found.");
            }
            return Ok("Delete success.");
        }
    }
}
