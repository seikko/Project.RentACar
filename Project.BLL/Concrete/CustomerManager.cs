using Project.BLL.Abstract;
using Project.BLL.Constants;
using Project.BLL.ValidationRules.FluentValidation;
using Project.CORE.Aspects.Autofac.Validation;
using Project.CORE.Utilities.Business;
using Project.CORE.Utilities.Results;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.BLL.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer item)
        {
            IResult result = BusinessRules.Run(CheckIfEmailExists(item.CompanyName));
            _customerDal.Add(item);
            return new SuccessResult(Messanges.CustomerAdded);
        }

        public IResult Delete(Customer item)
        {
            _customerDal.Delete(item);
            return new SuccessResult(Messanges.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messanges.CustomersListed);
        }

        public IDataResult<List<Customer>> GetByID(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(x => x.ID == id), Messanges.FindCustomerListed);
        }

        public IResult Update(Customer item)
        {
            _customerDal.Update(item);
            return new SuccessResult(Messanges.CustomerModified);
        }
        private IResult CheckIfEmailExists(string companyName)
        {
            var result = _customerDal.GetAll().Any();
            if(result)
            {
                new ErrorResult(Messanges.CompanyAlReadyExists);
            }
            return new SuccessResult();
        }
    }
}
