using Microsoft.AspNetCore.Mvc;
using Znaniya.Domain;

namespace Znaniya.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}