using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.CORE.DAL.EntityFramework
{
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filter = null fitre vermeyebilirim tüm datayı getir.
        T Get(Expression<Func<T, bool>> filter);//filter veririm.Ona gore getir...
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
