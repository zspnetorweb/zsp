using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Logic.BLL;
using UI.Logic.Model;

namespace Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin


	    public ActionResult Login()
	    {
		    return View();
	    }
		[HttpPost]
		public ActionResult LoginCheck(Administrator model)
	    {
			var result = AdminBll.LoginCheck(model);
		    return Json(result);
	    }

		public ActionResult Logout()
		{
			var result = AdminBll.Logout();
			return Json(result,JsonRequestBehavior.AllowGet);
		}
    }
}