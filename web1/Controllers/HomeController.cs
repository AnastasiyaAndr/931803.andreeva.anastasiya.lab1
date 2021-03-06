using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web1.Models;

namespace web1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            var viewModel = new RNG();
            return View(viewModel);
        }

        public IActionResult PassUsingViewData()
        {
            ViewData["RNG"] = new RNG();
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.rng = new RNG();
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
