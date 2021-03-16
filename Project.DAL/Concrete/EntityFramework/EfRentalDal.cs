using Project.CORE.DAL.EntityFramework;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using Project.ENTITIES.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace Project.DAL.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyContext>, IRentalDal
    {
       
        
    }
}
