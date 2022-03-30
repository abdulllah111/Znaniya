using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Znaniya.Areas.Admin.Controllers;
using Znaniya.Domain;
using Znaniya.Service;
using Znaniya.Domain.Entities;

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
        public IActionResult Index(Guid id)
        {
            var model = dataManager.Shelfs.GetShelfById(id);
            model.Books = dataManager.Books.GetBookByShelfId(model.ShelfID);
            return View(model);
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Shelf() : dataManager.Shelfs.GetShelfById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Shelf model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Shelfs.SaveShelf(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Shelfs.DeleteShelf(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}