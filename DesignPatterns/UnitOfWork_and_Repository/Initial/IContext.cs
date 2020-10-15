using System;
using System.Collections.Generic;

namespace UnitOfWork_and_Repository.Initial
{
    public interface IDBContext : IDisposable
    {
        IEnumerable<PersonModel> People { get; }
        IEnumerable<CompanyModel> Company { get; }
    }
}