using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NW_Central_Library.Controllers
{
    public class CheckOutInController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckOut()
        {
            ViewData["Message"] = "Future home of media check out page";
            return View();
        }

        public IActionResult CheckIn()
        {
            ViewData["Message"] = "Future home of media check in page";
            return View();
        }

    }
}
