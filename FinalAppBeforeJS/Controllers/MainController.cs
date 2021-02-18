using FinalAppBeforeJS.Models;
using FinalAppBeforeJS.Models.DataBase;
using FinalAppBeforeJS.ViewModels.Main;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FinalAppBeforeJS.Controllers
{
    public class MainController : Controller
    {
        private IAppRepository repository;
        public MainController(IAppRepository repository) => this.repository = repository;

        public ViewResult Index() => View();
        public ViewResult ReadNews(string category, int page = 1)
        {
            int newsPerPage = 3;

            ReadNewsViewModel model = new ReadNewsViewModel
            {
                News = repository.News.Where(n => category == null || n.Category.Name == category).OrderByDescending(n => n.Date).Skip(newsPerPage * (page - 1)).Take(newsPerPage).Include(n => n.Category),
                Pagination = new Pagination
                {
                    ActionName = nameof(ReadNews),
                    CurrentPage = page,
                    ItemsPerPage = newsPerPage,
                    TotalItems = category == null ? repository.News.Count() : repository.News.Include(n => n.Category).Where(n => n.Category.Name == category).Count()
                }
            };
            return View(model);
        }
    }
}
