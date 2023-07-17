using Business.Dto;
using Business.Interface;
using Business.Service;
using Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        [Route("UserAdd")]
        public ActionResult UserAdd(CustomerRequest customer)
        {
            _customerService.AddCustomer(customer);
            return Ok();
        }
    }
}
