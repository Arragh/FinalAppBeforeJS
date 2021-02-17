using FinalAppBeforeJS.Models;
using FinalAppBeforeJS.Models.DataBase;
using FinalAppBeforeJS.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAppBeforeJS.Controllers
{
    public class AdminController : Controller
    {
        private IAppRepository repository;
        public AdminController(IAppRepository repository) => this.repository = repository;

        [HttpGet]
        public ViewResult CreateCategory() => View();
        [HttpPost]
        public IActionResult ProcessCategory(CreateCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                repository.AddCategory(new Category { CategoryId = Guid.NewGuid(), Name = model.Name });
                TempData["Created"] = $"Категория \"{model.Name}\" создана";
                return RedirectToAction("Index", "Main");
            }
            return View("CreateCategory");
        }

        [HttpGet]
        public ViewResult CreateNews() => View(new CreateNewsViewModel { Categories = new SelectList(repository.Categories, "CategoryId", "Name") });
        [HttpPost]
        public IActionResult ProcessNews(CreateNewsViewModel model)
        {
            if (model.CategoryId == null)
            {
                ModelState.AddModelError("CategoryId", "Необходимо выбрать категорию");
            }
            if (ModelState.IsValid)
            {
                repository.AddNews(new News { NewsId = Guid.NewGuid(), Title = model.Title, Body = model.Body, CategoryId = model.CategoryId, Date = DateTime.Now });
                TempData["Created"] = $"Новость \"{model.Title}\" создана";
                return RedirectToAction("Index", "Main");
            }
            return View("CreateNews");
        }
    }
}
