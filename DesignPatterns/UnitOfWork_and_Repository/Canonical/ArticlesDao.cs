using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_and_Repository.Canonical.Models;

namespace UnitOfWork_and_Repository.Canonical
{
    public interface ArticleDao
    {
        List<Article> readAll();

        List<Article> readLatest();

        List<Article> readByTags(string tags);

        Article readById(long id);

        Article create(Article article);

        Article update(Article article);

        Article delete(Article article);
    }
}