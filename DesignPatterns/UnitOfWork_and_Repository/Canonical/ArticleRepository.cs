using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_and_Repository.Canonical.Models;

namespace UnitOfWork_and_Repository.Canonical
{
    public class ArticleRepository : Repository<Article, decimal>
    {
        public Article create(Article entity)
        {
            throw new NotImplementedException();
        }

        public Article delete(Article entity)
        {
            throw new NotImplementedException();
        }

        public Article read(decimal criteria)
        {
            throw new NotImplementedException();
        }

        public List<Article> readAll()
        {
            throw new NotImplementedException();
        }

        public Article update(Article entity)
        {
            throw new NotImplementedException();
        }
    }
}