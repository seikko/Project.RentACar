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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getAllColor")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addColor")]
        public IActionResult AddColor(Color item)
        {
            var result = _colorService.Add(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteColor")]
        public IActionResult DeleteColor(Color item)
        {
            var result = _colorService.Delete(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("updateColor")]
        public IActionResult UpdateColor(Color item)
        {

            var result = _colorService.Update(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getById")]
        public IActionResult GetByColor(int id)
        {
            var result = _colorService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
