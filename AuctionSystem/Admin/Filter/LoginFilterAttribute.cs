using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Filter
{
	public class LoginFilterAttribute:ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			if (filterContext.HttpContext.Session["Admin_UserName"] == null)
			{
				filterContext.Result = new RedirectResult("/Admin/Login");
			}
			base.OnActionExecuting(filterContext);
		}
	}
}