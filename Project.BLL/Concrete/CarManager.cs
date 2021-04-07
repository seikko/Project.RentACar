using Project.BLL.Abstract;
using Project.BLL.BusinessAspect.Autofac;
using Project.BLL.Constants;
using Project.BLL.ValidationRules.FluentValidation;
using Project.CORE.Aspects.Autofac.Caching;
using Project.CORE.Aspects.Autofac.Validation;
using Project.CORE.CrossCuttingConcerns.Performance;
using Project.CORE.CrossCuttingConcerns.Transcation;
using Project.CORE.Utilities.Business;
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

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("CarSerivce.Get")]
        [PerformanceAspect(5)]//bu metod'un çalışması 5 saniyeyi geçerse beni uyar
        public IResult Add(Car item)
        {
            
            IResult result = BusinessRules.Run(CheckIfCarNameExists(item.CarName));

            _carDal.Add(item); 
            return new SuccessResult(Messanges.ProductAdded);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Messanges.ProductModified);
        }

        public IResult Delete(Car item)
        {
            _carDal.Delete(item);
            return new SuccessResult(Messanges.ProductDeleted);

        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messanges.ProductListed);
        }

        public IDataResult<List<Car>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.DailyPrice <= min && x.DailyPrice >= max), Messanges.PrinceRangeListed);
        }
        [CacheAspect]

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

        [CacheRemoveAspect("IProductService.Get")]//ICarService'bütün get'leri sileriz.
        public IResult Update(Car item)
        {
            _carDal.Update(item);
            return new SuccessResult(Messanges.ProductModified);

        }
        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(x => x.CarName == carName).Any();
            if(result)
            {
                return new ErrorResult(Messanges.CarNameAlreadyExists);
            }
            return new SuccessResult();
        }
       
        }
    }

