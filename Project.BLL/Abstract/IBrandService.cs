using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand item);
        IResult Delete(Brand item);
        IResult Update(Brand item);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetByID(int id);


    }
}
