using System;
using UnitOfWork.Canonical.Models;

namespace UnitOfWork.Canonical
{
    public class DbContext
    {
        protected string connectionString;

        public DbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}