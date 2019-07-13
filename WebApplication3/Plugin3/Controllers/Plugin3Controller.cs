using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plugin3.Controllers
{
    [Export("Plugin3", typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Plugin3Controller : Controller
    {
        // GET: Plugin3
        public ActionResult Index()
        {
            int C = 2;
            ViewBag.f = C;
            return View();
        }
    }
}