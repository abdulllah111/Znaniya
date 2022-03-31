using Microsoft.AspNetCore.Mvc;
using Znaniya.Domain;
using Znaniya.Domain.Entities;

namespace Znaniya.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;      

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            var model = new AllPositions
            {
                Shelves = dataManager.Shelfs.GetShelves(),
                Books = dataManager.Books.GetBooks(),
                Chapters = dataManager.Chapters.GetChapters(),
                Pages = dataManager.Pages.GetPages(),

            };
            return View(model);

        }
    }
}