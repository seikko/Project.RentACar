using Project.CORE.DAL.EntityFramework;
using Project.CORE.Entities.Concrete;
using Project.DAL.Concrete.EntityFramework;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
