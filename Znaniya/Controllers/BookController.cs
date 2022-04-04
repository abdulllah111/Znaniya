using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Znaniya.Domain;
using Znaniya.Domain.Entities;

namespace Znaniya.Controllers
{
    public class BooksController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public BooksController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: ShelfsController
        public ActionResult Index()
        {
            var model = dataManager.Books.GetBooks();
            return View(model);
        }

        // GET: ShelfsController/Details/5
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
