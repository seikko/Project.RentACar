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
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getAllUser")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addUser")]
        public IActionResult AddUser(User item)
        {
            var result = _userService.Add(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteUser")]
        public IActionResult DeleteUser(User item)
        {
            var result = _userService.Delete(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("updateUser")]
        public IActionResult UpdateUser(User item)
        {

            var result = _userService.Update(item);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getById")]
        public IActionResult GetByUser(int id)
        {
            var result = _userService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Messange);
        }

    }
}
