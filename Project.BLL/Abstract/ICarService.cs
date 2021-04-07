using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using Project.ENTITIES.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetCarByBrandID(int id);
        IDataResult<List<Car>> GetCarsByColorID(int id);
        IDataResult<List<CarDetailDto>> GetCarDetail();
        IDataResult<List<Car>> GetByPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetAll();
        IResult Add(Car item);
        IResult Delete(Car item);
        IResult Update(Car item);
        IResult AddTransactionalTest(Car car);

    }
}
