using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_and_Repository.Initial;
using UnitOfWork_and_Repository.Canonical;

namespace UnitOfWork_and_Repository
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var item = new ArticleRepository();
            item.read(100M);
        }
    }
}