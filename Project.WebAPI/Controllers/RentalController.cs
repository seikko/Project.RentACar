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
    public class RentalController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getAllRental")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addRental")]
        public IActionResult AddRental(Rental item)
        {
            var result = _rentalService.Add(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteRental")]
        public IActionResult DeleteCustomer(Rental item)
        {
            var result = _rentalService.Delete(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("updateRental")]
        public IActionResult UpdateCustomer(Rental item)
        {

            var result = _rentalService.Update(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
