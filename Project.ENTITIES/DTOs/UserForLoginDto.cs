using Project.CORE.Entities.DTOClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.DTOs
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
