using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
            return _repository.Add(obj);
        }

        public int Delete(int id)
        {
            var entity = _repository.GetById(id);
            return _repository.Delete(entity);
        }

        public TEntity Edit(TEntity obj)
        {
            return _repository.Edit(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
