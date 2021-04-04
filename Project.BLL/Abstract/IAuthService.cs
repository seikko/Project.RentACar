using Project.CORE.Entities.Concrete;
using Project.CORE.Utilities.Results;
using Project.CORE.Utilities.Security.JWT;
using Project.ENTITIES.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{

    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
