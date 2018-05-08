using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library;
using UI.Logic.Model;
using UI.Logic.Model.Admin;
using UI.Logic.Model.Context;

namespace UI.Logic.AdminBLL
{
	public static class AdminBll
	{
		private static readonly RedisCache Cache = new RedisCache();
		/// <summary>
		/// 登录验证
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public static AjaxResult LoginCheck(Administrator model)
		{
			var db = AuctionSystemContext.Instance;
			var ar = new AjaxResult()
			{
				Code = 0,
				Title = "登录失败",
				Content = "请检查用户名和密码"
			};
			if (model != null)
			{
				model.Password = Tool.GetMd5(model.Password);
				var count = db.Queryable<Administrator>().Count(l => l.UserName == model.UserName && l.Password == model.Password);
				if (count > 0)
				{
					HttpContext.Current.Session["Admin_UserName"] = model.UserName;
					ar.Code = 1;
					ar.Title = "登录成功";
					ar.Content = "正在进入首页";
				}
			}
			else
			{
				ar.Title = "异常";
				ar.Content = "实体对象不存在";
			}
			return ar;
		}

		/// <summary>
		/// 获取菜单列表
		/// </summary>
		/// <returns></returns>
		public static List<IMenuList> GetMenuList()
		{
			var db = AuctionSystemContext.Instance;
			List<MenuList> menuList = null;
			if (Cache.Get<List<MenuList>>("MenuList") == null)
			{
				menuList = db.Queryable<MenuList>().ToList();
				Cache.Insert("MenuList", menuList);
			}
			else
				menuList = Cache.Get<List<MenuList>>("MenuList");
			var listFirstMenu = menuList.Where(l => l.ParentId == 0);
			var iMenuList = new List<IMenuList>();
			foreach (var item in listFirstMenu)
			{
				var iModel = new IMenuList()
				{
					Name = item.Name,
					CodeUrl = item.CodeUrl,
					ParentId = item.ParentId,
					MenuLists = menuList.Where(l=>l.ParentId==item.Id).ToList()
				};

				iMenuList.Add(iModel);
			}
			foreach (var item in iMenuList)
			{
				foreach (var itemList in item.MenuLists)
				{
					itemList.CodeUrl = string.Format("/{0}/{1}", itemList.CodeUrl.Split('_')[0], itemList.CodeUrl.Split('_')[1]);
				}
			}
			return iMenuList;
		}
		/// <summary>
		/// 注销
		/// </summary>
		/// <returns></returns>
		public static AjaxResult Logout()
		{
			var ar = new AjaxResult();
			try
			{
				HttpContext.Current.Session["Admin_UserName"] = null;
				ar.Code = 1;
				ar.Title = "注销成功";
				ar.Content = "请重新登录";
			}
			catch (Exception)
			{
				ar.Code = 0;
				ar.Title = "注销失败";
			}
			return ar;
		}
	}
}
