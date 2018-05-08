using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Filter;

namespace Admin.Controllers
{
	[LoginFilter]
	public class OrderController : IBaseController
	{
		// GET: Order
		public ActionResult OrderList()
		{
			return View();
		}
	}
}