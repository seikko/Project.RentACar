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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getAllBrand")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addBrand")]
        public IActionResult AddBrand(Brand item)
        {
            var result = _brandService.Add(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteBrand")]
        public IActionResult DeleteBrand(Brand item)
        {
            var result = _brandService.Delete(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("updateBrand")]
        public IActionResult UpdateBrand(Brand item)
        {

            var result = _brandService.Update(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getBrandId")]
        public IActionResult GetByID(int brandId)
        {
            var result = _brandService.GetByID(brandId);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
