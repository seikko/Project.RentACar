using Project.CORE.DAL.EntityFramework;
using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using Project.ENTITIES.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
       List<CarDetailDto> GetCarDetails();
    }
}
