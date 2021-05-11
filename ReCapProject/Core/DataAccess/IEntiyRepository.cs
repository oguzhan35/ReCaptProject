using Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
  public  interface IEntiyRepository<T> where T:class,IEntity,new(){
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);
    }
}
