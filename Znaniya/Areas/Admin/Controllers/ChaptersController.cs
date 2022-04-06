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
using System.Text.RegularExpressions;
using System.Linq;

namespace Znaniya.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChaptersController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ChaptersController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
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
            var entity = new Chapter() { BookID = id, DateAdded = DateTime.Now };
            return View(entity);
        }

        public IActionResult Edit(Guid id)
        {
            var entity = dataManager.Chapters.GetChapterById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Chapter model)
        {
            if (ModelState.IsValid)
            {
                
                dataManager.Chapters.SaveChapter(model);
                return RedirectToAction(nameof(BooksController.Details), nameof(BooksController).CutController(), new { @id = model.BookID });
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id, Guid bookid)
        {
            dataManager.Books.DeleteBook(id);
            return RedirectToAction(nameof(BooksController.Details), nameof(BooksController).CutController(), new { @id = bookid });
        }
        public ActionResult Details(Guid id)
        {
            var model = new AllPositions
            {
                Chapter = dataManager.Chapters.GetChapterById(id),
                Pages = dataManager.Pages.GetPagesByChapterId(id)
            };
            return View(model);
        }

    }
}
