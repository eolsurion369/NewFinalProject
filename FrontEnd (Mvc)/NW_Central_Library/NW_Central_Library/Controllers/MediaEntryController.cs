using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NW_Central_Library.Controllers
{
    public class MediaEntryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MediaEntry()
        {
            ViewData["Message"] = "Future home of media entry screen";
            return View();
        }
    }
}
