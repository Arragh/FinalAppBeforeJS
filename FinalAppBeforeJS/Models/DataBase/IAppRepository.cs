using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAppBeforeJS.Models.DataBase
{
    public interface IAppRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<News> News { get; }
        void AddCategory(Category category);
        void AddNews(News news);
    }
}
