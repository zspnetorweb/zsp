using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Logic.BLL;

namespace Admin.Controllers
{
    public class IBaseController : Controller
    {

	    public IBaseController()
	    {
		    ViewBag.iMenuList = AdminBll.GetMenuList();
	    }
    }
}