using Project.BLL.Abstract;
using Project.BLL.Constants;
using Project.BLL.ValidationRules.FluentValidation;
using Project.CORE.Aspects.Autofac.Validation;
using Project.CORE.Utilities.Results;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using Project.ENTITIES.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.BLL.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car item)
        {
            if(item.Description.Length>=2)
            {
                if (item.DailyPrice>0)
                {
                    _carDal.Add(item);
                    return new SuccessResult(Messanges.ProductAdded);
                }
              
            }
            return new ErrorResult(Messanges.NoProductAdded);
          
             
        }

        public IResult Delete(Car item)
        {
            _carDal.Delete(item);
            return new SuccessResult(Messanges.ProductDeleted);
           
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messanges.ProductListed);
        }

        public IDataResult<List<Car>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.DailyPrice <= min && x.DailyPrice >= max), Messanges.PrinceRangeListed);
        }

        public IDataResult<List<Car>> GetCarByBrandID(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.BrandID == id), Messanges.BrandListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messanges.CarDetailListed);
        }

        public IDataResult<List<Car>> GetCarsByColorID(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.ColorID == id), Messanges.ColorListed);
        }

        public IResult Update(Car item)
        {
            _carDal.Update(item);
            return new SuccessResult(Messanges.ProductModified);

        }
    }
}
