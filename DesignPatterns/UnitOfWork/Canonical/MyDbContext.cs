using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Canonical.Models;

namespace UnitOfWork.Canonical
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        internal IDbSet<T> Set<T>()
        {
            throw new NotImplementedException();
        }

        public MyDbContext(string connectionString) : base(connectionString)
        {
        }
    }
}