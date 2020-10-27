using Interfaces;
using ApiInfra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ApiContext _ctx;

        public BaseRepository(ApiContext ctx) 
        {
            _ctx = ctx;
        }

        public TEntity Add(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
            _ctx.SaveChanges();
            return obj;
        }

        public int Delete(TEntity obj)
        {
            _ctx.Set<TEntity>().Remove(obj);
            return _ctx.SaveChanges();
        }

        public TEntity Edit(TEntity obj)
        {
            _ctx.Update(obj);
            _ctx.SaveChanges();
            return obj;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            var entity = _ctx.Set<TEntity>().Find(id);
            return entity;
        }
    }
}
