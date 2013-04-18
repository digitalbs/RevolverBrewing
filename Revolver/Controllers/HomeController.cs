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
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to the Revolver Brewing site.";

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

        [HttpPost]
        public ActionResult Admin(HttpPostedFileBase file)
        {
            //check if user selected file
            if (file != null && file.ContentLength > 0)
            {
                //get file name
                var filename = Path.GetFileName(file.FileName);
                //store file in folder
                var path = Path.Combine(Server.MapPath("~/App_Data/Products"), filename);
                file.SaveAs(path);
            }
            return View("Admin");
        }
    }
}
