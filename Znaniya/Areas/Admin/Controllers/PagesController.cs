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
    public class PagesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public PagesController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
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
            var entity = new Page() { ChapterID = id, DateAdded = DateTime.Now };
            return View(entity);
        }

        public IActionResult Edit(Guid id)
        {
            var entity = dataManager.Pages.GetPageById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Page model)
        {
            if (ModelState.IsValid)
            {
               
                dataManager.Pages.SavePage(model);
                return RedirectToAction(nameof(ChaptersController.Details), nameof(ChaptersController).CutController(), new { @id = model.ChapterID });
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id, Guid chapterid)
        {
            dataManager.Books.DeleteBook(id);
            return RedirectToAction(nameof(ChaptersController.Details), nameof(ChaptersController).CutController(), new { @id = chapterid });
        }
        public ActionResult Details(Guid id)
        {
            var model = dataManager.Pages.GetPageById(id);
            return View(model);
        }

    }
}
