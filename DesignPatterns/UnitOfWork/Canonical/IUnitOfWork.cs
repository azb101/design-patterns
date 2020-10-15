using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Canonical.Models;

namespace UnitOfWork.Canonical
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Author> AuthorRepo { get; }
        IRepository<Book> BOokRepo { get; }

        void Commit();

        void Rollback();
    }
}