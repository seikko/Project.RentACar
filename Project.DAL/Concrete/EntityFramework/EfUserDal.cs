using Project.CORE.DAL.EntityFramework;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Concrete.EntityFramework
{
   public class EfUserDal: EfEntityRepositoryBase<User, MyContext>, IUserDal
    {
    }
}
