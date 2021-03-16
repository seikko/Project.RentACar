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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental item)
        {
            _rentalDal.Add(item);
            return new SuccessResult(Messanges.RentalAdded);
        }

        public IResult Delete(Rental item)
        {
            _rentalDal.Delete(item);
            return new SuccessResult(Messanges.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messanges.LeasedVehiclesListed);
        }

        public IResult Update(Rental item)
        {
            _rentalDal.Update(item);
            return new SuccessResult(Messanges.RentalModified);
        }
    }
}
