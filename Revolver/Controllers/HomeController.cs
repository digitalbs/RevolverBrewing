using Revolver.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revolver.Controllers
{
    public class HomeController : Controller
    {
        private OrdersContext db = new OrdersContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Upcoming Tour Events - $10 Admission";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Revolver.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }

        [Authorize(Roles="Administrator")]
        public ActionResult Admin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "admin" });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View();
        }
        
    }
}
