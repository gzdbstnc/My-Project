using GYM.Data.Abstract;
using GYM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GYM.Data.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private GymContext _context;
        public GenericRepository(GymContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            //_context.Remove<TEntity>(Get(id));
            //_context.SaveChanges();

            using (var context = new GymContext())
            {
                var deletedEntity = context.Entry(Get(id));
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public void Insert(TEntity entity)
        {
            using (var context = new GymContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Update(TEntity entity)
        {
            using (var context = new GymContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}