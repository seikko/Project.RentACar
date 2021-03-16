using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
    public interface IUserService
    {
        IResult Add(User item);
        IResult Delete(User item);
        IResult Update(User item);
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetByID(int id);
    }
}
