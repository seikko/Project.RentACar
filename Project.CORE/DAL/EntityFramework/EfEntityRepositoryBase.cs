using Microsoft.EntityFrameworkCore;
using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.CORE.DAL.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        //IDisposable pattern
        public void Add(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(item);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var deleteEntity = context.Entry(item);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {//eger filtre null iste Tolist'e dok ver 
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
                //null degilse filtreleyip ver.
            }
        }

        public void Update(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(item);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
