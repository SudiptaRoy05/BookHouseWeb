using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter);

        public IEnumerable<T> GetAll();

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(T entity);
    }
}
