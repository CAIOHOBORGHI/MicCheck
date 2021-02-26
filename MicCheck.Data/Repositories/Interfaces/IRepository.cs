using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MicCheck.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        int Count();
        
        void Delete(T entity);

        // With this function, we are able to use the power of Linq queries directly into our database
        T Get(Expression<Func<T, bool>> predicate = null);
        List<T> GetAll(Expression<Func<T, bool>> predicate = null);
        
        void Insert(T entity);
        
        void Update(T entity);
    }
}
