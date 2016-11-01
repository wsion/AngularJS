using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJS.Controllers
{
    //[RoutePrefix("AngularJS")]
    public class FrontEndController : Controller
    {
        //[Route("Content/{viewname:string}")]
        public ActionResult Index(string viewname)
        {
            return View(viewname);
        }

        public ActionResult Partial(string viewname)
        {
            return PartialView(viewname);
        }
    }
}