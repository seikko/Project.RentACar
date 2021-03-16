using Project.CORE.DAL.EntityFramework;
using Project.DAL.Concrete.EntityFramework;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {

    }
}
