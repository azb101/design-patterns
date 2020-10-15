using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Canonical;
using UnitOfWork.Canonical.Models;

namespace UnitOfWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbContext = new MyDbContext("connectionString");

            var unitOfWork = new UnitOfWork.Canonical.UnitOfWork(dbContext);

            var books = unitOfWork.BOokRepo.Entities;

            unitOfWork.AuthorRepo.Add(new Author());

            unitOfWork.Commit();
        }
    }
}