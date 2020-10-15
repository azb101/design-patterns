using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Canonical
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext myDbContext;

        public GenericRepository(DbContext context)
        {
            this.myDbContext = context;
        }

        private IDbSet<T> dbSet => ((MyDbContext)myDbContext).Set<T>();
        public IQueryable<T> Entities => dbSet as IQueryable<T>;

        public void Add(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Add(entity);
        }
    }
}