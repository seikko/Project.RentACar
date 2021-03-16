using Project.CORE.DAL.EntityFramework;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using Project.ENTITIES.DTOs;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyContext>, ICarDal
    {
        
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyContext context = new MyContext())
            {
                var result = from c in context.Cars 
                             join b in context.Brands on c.BrandID equals b.ID
                             join cl in context.Colors on c.ColorID equals cl.ID
                             select new CarDetailDto
                             { 
                                 ID = c.ID,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,  
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description
                                 
                             };
                return result.ToList();
            }
        }
    }
}
