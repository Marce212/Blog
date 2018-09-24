using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_Blog_1._0.Models;

namespace my_Blog_1._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //string titulo About
        public IActionResult About()
        {

            ViewData["Message"] = "Bibliography";

            return View();
        }
        //string Titulo Contact
        public IActionResult Contact()
        {
            ViewData["Message"] = "About me.";

            return View();
        }

        public IActionResult InstallDockerAspNetCoreView()
        {
            ViewData["Message"] = "InstallDockerAspNetCoreView";

            return View();
        }

        public IActionResult RemisOnlineView()
        {
            ViewData["Message"] = "RemisOnlineView";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
