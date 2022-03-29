using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Znaniya.Domain;
using Znaniya.Models;

namespace Znaniya.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
      public IActionResult Index()
        {
            return View();
        }
        

        //private readonly DataManager dataManager;

        //public HomeController(DataManager dataManager)
        //{
        //    this.dataManager = dataManager;
        //}

        //public IActionResult Index()
        //{
        //    return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        //}

        //public IActionResult Contacts()
        //{
        //    return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        //}
    }
}