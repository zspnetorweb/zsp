using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Filter;
using UI.Logic.AdminBLL;
using UI.Logic.Model;

namespace Admin.Controllers
{
	[LoginFilter]
    public class MemberController : IBaseController
    {
		public ActionResult Index()
		{
			
			return View();
		}

		public ActionResult MemberDetailsList()
        {
	        var list = MemberBll.MemberInfoList();
            return View(list);
        }

    }
}