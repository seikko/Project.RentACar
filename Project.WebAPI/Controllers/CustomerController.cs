using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getAllCustomer")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addCustomer")]
        public IActionResult AddCustomer(Customer item)
        {
            var result = _customerService.Add(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteCustomer")]
        public IActionResult DeleteCustomer(Customer item)
        {
            var result = _customerService.Delete(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("updateCustomer")]
        public IActionResult UpdateCustomer(Customer item)
        {

            var result = _customerService.Update(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getById")]
        public IActionResult GetByCustomer (int id)
        {
            var result = _customerService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Messange);
        }



    }
}
