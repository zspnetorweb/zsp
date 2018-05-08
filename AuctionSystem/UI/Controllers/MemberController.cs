using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Logic.Model;
using UI.Logic.UIBLL;

namespace UI.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Login()
        {
            return View();
        }

	    public ActionResult Register()
	    {
		    return View();
	    }

	    [HttpPost]
	    public ActionResult Register(Member model)
	    {
		    var result = MemberBll.Register(model);
		    return Json(result);
	    }

    }
}