using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
   public interface IColorService
    {
        IResult Add(Color item);
        IResult Delete(Color item);
        IResult Update(Color item);
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetByID(int id);

    }
}
