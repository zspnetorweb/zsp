using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
	public class ProductController : IBaseController
	{
		// GET: Product
		public ActionResult ProductList()
		{
			return View();
		}

		public ActionResult ProductClassList()
		{
			return View();
		}
	}

}