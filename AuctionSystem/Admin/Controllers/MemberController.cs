using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Logic.Model;
using UI.Logic.BLL;

namespace Admin.Controllers
{
    public class MemberController : Controller
    {

        // GET: Member
        public ActionResult Index()
        {
	        var list = MemberBll.MemberInfoList();
            return View(list);
        }

    }
}