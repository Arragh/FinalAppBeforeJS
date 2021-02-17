using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAppBeforeJS.Models.DataBase
{
    public class EFAppRepository : IAppRepository
    {
        private AppDbContext context;
        public EFAppRepository(AppDbContext context) => this.context = context;

        public IQueryable<Category> Categories => context.Categories;

        public IQueryable<News> News => context.News;

        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void AddNews(News news)
        {
            context.News.Add(news);
            context.SaveChanges();
        }
    }
}
