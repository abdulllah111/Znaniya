using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Znaniya.Areas.Admin.Controllers;
using Znaniya.Domain;
using Znaniya.Service;
using Znaniya.Domain.Entities;
using AngleSharp;
using AngleSharp.Html.Parser;
using AngleSharp.Dom;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShelfsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ShelfsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var model = dataManager.Shelfs.GetShelves();
            return View(model);
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Shelf() { DateAdded = DateTime.Now } : dataManager.Shelfs.GetShelfById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Shelf model)
        {
            if (ModelState.IsValid)
            {
                List<string> hrefTags = new List<string>();

                var parser = new HtmlParser();
                var document = parser.ParseDocument(model.Text);
                foreach (IElement element in document.QuerySelectorAll("a"))
                {
                    hrefTags.Add(element.GetAttribute("input"));
                }
                dataManager.Shelfs.SaveShelf(model);
                return RedirectToAction(nameof(ShelfsController.Index), nameof(ShelfsController).CutController());
            }
            return View(model);
        }



        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Shelfs.DeleteShelf(id);
            return RedirectToAction(nameof(ShelfsController.Index), nameof(ShelfsController).CutController());
        }
        public ActionResult Details(Guid id)
        {
            var model = new AllPositions
            {
                Shelf = dataManager.Shelfs.GetShelfById(id),
                Books = dataManager.Books.GetBookByShelfId(id)
            };
            return View(model);
        }
    }
}