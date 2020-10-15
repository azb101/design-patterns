using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Canonical.Models;

namespace UnitOfWork.Canonical
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IRepository<Author> AuthorRepo =>
            new GenericRepository<Author>(dbContext);

        public IRepository<Book> BOokRepo =>
            new GenericRepository<Book>(dbContext);

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            // dispose code
        }

        public void Rollback()
        {
            // rollback code
        }
    }
}