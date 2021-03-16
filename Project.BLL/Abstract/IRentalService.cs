using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
   public  interface IRentalService
    {
        IResult Add(Rental item);
        IResult Delete(Rental item);
        IResult Update(Rental item);
        IDataResult<List<Rental>> GetAll();

    }
}
