using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Znaniya.Areas.Admin.Controllers;
using Znaniya.Domain;
using Znaniya.Service;
using Znaniya.Domain.Entities;
using MyCompany.Areas.Admin.Controllers;

namespace Znaniya.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public BooksController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(Guid id)
        {
            var entity = new Book() { ShelfID = id };
            return View(entity);
        }

        public IActionResult Edit(Guid id)
        {
            var entity = dataManager.Books.GetBookById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Book model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Books.SaveBook(model);
                return RedirectToAction(nameof(ShelfsController.Details), nameof(ShelfsController).CutController(), new {@id = model.ShelfID});
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id, Guid shelfid)
        {
            dataManager.Books.DeleteBook(id);
            return RedirectToAction(nameof(ShelfsController.Details), nameof(ShelfsController).CutController(), new {@id = shelfid});
        }
        public ActionResult Details(Guid id)
        {
            var model = new AllPositions
            {
                Book = dataManager.Books.GetBookById(id),
                Chapters = dataManager.Chapters.GetChaptersByBookId(id)
            };
            return View(model);
        }
    }
}
