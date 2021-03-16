using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer item);
        IResult Delete(Customer item);
        IResult Update(Customer item);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetByID(int id);
    }
}
