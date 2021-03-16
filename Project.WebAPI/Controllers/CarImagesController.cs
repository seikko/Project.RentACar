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
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("addImage")]
        public IActionResult AddCarImage([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage image)
        {
            var result = _carImageService.Add(file, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteImage")]
        public IActionResult DeleteCarImage([FromForm(Name = ("ID"))] int id)
        {
            var image = _carImageService.Get(id).Data;
            var result = _carImageService.Delete(image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateImage")]
        public IActionResult UpdateCarImage([FromForm(Name = ("Image"))] IFormFile file , [FromForm(Name =("ID"))] int id)
        {
            var image = _carImageService.Get(id).Data;
            var result = _carImageService.Update(file, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getByID")]
        public IActionResult GetByID([FromForm(Name ="ID")]int id)
        {
            var result = _carImageService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getAllImage")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getImageByCarID")]
        public IActionResult GetImagesByCarID([FromForm(Name =("CarID"))]int id)
        {
            var result = _carImageService.GetImagesByCarID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
