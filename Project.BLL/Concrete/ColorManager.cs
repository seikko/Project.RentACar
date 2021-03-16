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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color item)
        {
            _colorDal.Add(item);
            return new SuccessResult(Messanges.ProductAdded);
        }

        public IResult Delete(Color item)
        {
            _colorDal.Delete(item);
            return new SuccessResult(Messanges.ProductDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messanges.ProductListed);
        }

        public IDataResult<List<Color>> GetByID(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(x => x.ID == id), Messanges.ProductListed);
        }

        public IResult Update(Color item)
        {
            _colorDal.Update(item);
            return new SuccessResult(Messanges.ProductModified);
        }
    }
}
