using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Edit(TEntity obj);
        int Delete(int id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
