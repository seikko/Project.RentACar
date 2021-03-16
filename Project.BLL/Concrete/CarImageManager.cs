using Microsoft.AspNetCore.Http;
using Project.BLL.Abstract;
using Project.BLL.Constants;
using Project.CORE.Helpers;
using Project.CORE.Utilities.Results;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Project.BLL.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(IFormFile file, CarImage image)
        {
          image.ImagePath = FileHelper.Add(file);
            image.Date = DateTime.Now;
            _carImageDal.Add(image);
            return new SuccessResult(Messanges.AddedCarImage);
        }

        public IResult Delete(CarImage image)
        {
            FileHelper.Delete(image.ImagePath);
            _carImageDal.Delete(image);
            return new SuccessResult(Messanges.DeletedCarImage);
        }

        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(x => x.ID == id));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetImagesByCarID(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(x => x.ID == id));
        }

        public IResult Update(IFormFile file, CarImage image)
        {
            image.ImagePath = FileHelper.Update(_carImageDal.Get(x => x.ID == image.ID).ImagePath, file);
            image.Date = DateTime.Now;
            _carImageDal.Update(image);
            return new SuccessResult(Messanges.UpdatedCarImages);
        }

        
    }
}
