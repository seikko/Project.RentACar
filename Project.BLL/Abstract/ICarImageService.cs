using Microsoft.AspNetCore.Http;
using Project.CORE.Utilities.Results;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage image);
        IResult Delete(CarImage image);
        IResult Update(IFormFile file, CarImage image);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesByCarID(int id);
        IDataResult<CarImage> Get(int id);

    }
}
