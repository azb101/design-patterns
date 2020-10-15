using System.Linq;

namespace UnitOfWork.Canonical
{
    internal interface IDbSet<T> : IQueryable
    {
        void Remove<T>(T entity) where T : class;

        void Add<T>(T entity) where T : class;
    }
}