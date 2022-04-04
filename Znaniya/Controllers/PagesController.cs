using Microsoft.AspNetCore.Mvc;
using Znaniya.Domain;

namespace Znaniya.Controllers
{
    public class PagesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public PagesController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public ActionResult Details(Guid id)
        {
            var model = dataManager.Pages.GetPageById(id);
            return View(model);
        }
    }
}
