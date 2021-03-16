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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User item)
        {
            _userDal.Add(item);
            return new SuccessResult(Messanges.UserAdded);
        }

        public IResult Delete(User item)
        {
            _userDal.Delete(item);
            return new SuccessResult(Messanges.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messanges.UsersListed);
        }

        public IDataResult<List<User>> GetByID(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(x => x.ID == id), Messanges.GetUserListed);
        }

        public IResult Update(User item)
        {
            _userDal.Update(item);
            return new SuccessResult(Messanges.UserModified);
        }
    }
}
