using Lucky_Draw_Promotion.DTO;
using Lucky_Draw_Promotion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lucky_Draw_Promotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("/customer/{customerId}")]
        public async Task<ActionResult> GetCustomerById(int customerId)
        {
            var customer = await _customerService.GetCustomerById(customerId);
            if(customer == null)
            {
                return BadRequest("Customer not found.");
            }
            return Ok(customer);
        }
        [HttpGet("/customer")]
        public async Task<ActionResult> GetAllCustomer()
        {
            var customers = await _customerService.GetAllCustomer();
            if(customers == null)
            {
                return BadRequest("There no customer yet.");
            }
            return Ok(customers);
        }
        [HttpGet("/customer/search-by-name/{customerName}")]
        public async Task<ActionResult> GetCustomerListByName(string customerName)
        {
            var customers = await _customerService.SearchCustomerByName(customerName);
            if(customers == null)
            {
                return BadRequest("Customer not found.");
            }
            return Ok(customers);
        }
        [HttpPost("/customer/new-customer")]
        public async Task<ActionResult> CreateNewCustomer([FromForm] CreateCustomerDTO request)
        {
            var customerId = await _customerService.CreateNewCustomer(request);
            if(customerId == 0)
            {
                return BadRequest("Error when create new customer.");
            }
            var customer = await _customerService.GetCustomerById(customerId);
            return Ok(customer);
        }
        [HttpPut("/customer/block/{id}")]
        public async Task<ActionResult> IsBlockCustomer([FromForm]int id)
        {
            var customerId = await _customerService.IsBlockCustomer(id);
            if(customerId == 0)
            {
                return BadRequest("Customer not found.");
            }
            var customerInfo = await _customerService.GetCustomerById(customerId);
            return Ok(customerInfo);
        }
        [HttpPut("/customer/edit-customer-info/{id}")]
        public async Task<ActionResult> EditCustomer(int id, [FromForm]EditCustomerDTO request)
        {
            var editCustomer = await _customerService.EditCustomerInfo(id, request);
            if(editCustomer == 0)
            {
                return BadRequest("Customer not found.");
            }
            var customerInfo = await _customerService.GetCustomerById(editCustomer);
            return Ok(customerInfo);
        }
    }
}
