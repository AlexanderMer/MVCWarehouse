using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index",
                new RouteValueDictionary(new { controller = "Items", action = "Index"}));
        }

        public ActionResult About()
        {
            ViewBag.Message = "My \"Mini Warehouse\" Implementation.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Creator";

            return View();
        }
    }
}