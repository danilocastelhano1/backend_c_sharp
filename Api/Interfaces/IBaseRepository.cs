using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Edit(TEntity obj);
        int Delete(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
