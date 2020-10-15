using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_and_Repository.Canonical.Models;

namespace UnitOfWork_and_Repository.Canonical
{
    public interface Repository<T, K>
    {
        List<T> readAll();

        T read(K criteria);

        T create(T entity);

        T update(T entity);

        T delete(T entity);
    }
}