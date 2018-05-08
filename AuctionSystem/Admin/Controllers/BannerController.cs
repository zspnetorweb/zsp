using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Filter;

namespace Admin.Controllers
{
	[LoginFilter]
    public class BannerController : Controller
    {
        // GET: Banner
		public ActionResult Slideshow()
        {
            return View();
        }
    }
}