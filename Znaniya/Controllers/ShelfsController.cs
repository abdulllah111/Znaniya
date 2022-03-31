using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Znaniya.Domain;
using Znaniya.Domain.Entities;

namespace Znaniya.Controllers
{
    public class ShelfsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ShelfsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: ShelfsController
        public ActionResult Index()
        {
            var model = dataManager.Shelfs.GetShelves();
            return View(model);
        }

        // GET: ShelfsController/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }
    }
}
