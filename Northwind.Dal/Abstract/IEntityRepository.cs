using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public  interface IEntityRepository<T> where T : EntityBase
    {
        T Add(T entity);
        T Update(T entity);
        T Find(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression); 
        bool Delete(int id);
        bool Delete(T entity);
        List<T> GetAll();
    }
}
