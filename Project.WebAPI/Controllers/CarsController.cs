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
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getAllCar")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addCar")]
        public IActionResult AddCar(Car item)
        {
            var result = _carService.Add(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteCar")]
        public IActionResult DeleteCar(Car item)
        {
            var result = _carService.Delete(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("updateCar")]
        public IActionResult UpdateCar(Car item)
        {

            var result = _carService.Update(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("carDetail")]
        public IActionResult GetCarDetail()
        {

            var result = _carService.GetCarDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getPrice")]
        public IActionResult GetByPrice(int min, int max)
        {
            var result = _carService.GetByPrice(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getByBrand")]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _carService.GetCarByBrandID(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getColor")]
        public IActionResult GetByColor(int colorId)
        {
            var result = _carService.GetCarsByColorID(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }

    }

