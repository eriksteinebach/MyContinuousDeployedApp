using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyContinuousDeployedApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Dit is een automatisch uitgerolde applicatie met TeamCity en Octopus Deploy";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
