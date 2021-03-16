using Project.BLL.Abstract;
using Project.BLL.Constants;
using Project.BLL.ValidationRules.FluentValidation;
using Project.CORE.Aspects.Autofac.Validation;
using Project.CORE.Utilities.Results;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand item)
        {
            _brandDal.Add(item);
            return new SuccessResult(Messanges.ProductAdded);
        }

        public IResult Delete(Brand item)
        {
            _brandDal.Delete(item);
            return new SuccessResult(Messanges.ProductDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messanges.ProductListed);
        }

        public IDataResult<List<Brand>> GetByID(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(x => x.ID == id), Messanges.ProductListed);
        }

        public IResult Update(Brand item)
        {
            _brandDal.Update(item);
            return new SuccessResult(Messanges.ProductModified);
        }
    }
}
