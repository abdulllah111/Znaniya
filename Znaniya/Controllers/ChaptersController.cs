using Microsoft.AspNetCore.Mvc;
using Znaniya.Domain;
using Znaniya.Domain.Entities;

namespace Znaniya.Controllers
{
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
