using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Znaniya.Domain;
using Znaniya.Models;

namespace Znaniya.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult Index()
        {
            return View();
        }
    }
}