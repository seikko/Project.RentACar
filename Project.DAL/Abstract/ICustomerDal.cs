using Project.CORE.DAL.EntityFramework;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
