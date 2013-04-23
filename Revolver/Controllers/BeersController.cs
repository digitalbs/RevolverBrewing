using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revolver.Controllers
{
    public class BeersController : Controller
    {
        //
        // GET: /Beers/

        public ActionResult Index()
        {
            return View();
        }

    }
}
