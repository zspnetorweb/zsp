using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using UI.Logic.Model;
using UI.Logic.Model.Context;
using Library;
using System.Web;
using UI.Logic.Enum;

namespace UI.Logic.BLL
{
	public static class AdminBll
	{
		private static RedisCache cache = new RedisCache();
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
		public static List<Menu> GetMenuList()
		{
			var db = AuctionSystemContext.Instance;
			if (cache.Get<List<Menu>>("MenuList") == null)
			{
				var list = db.Queryable<Menu>().ToList();
				cache.Insert("MenuList",list);
			}
				var listMenu = cache.Get<List<Menu>>("MenuList").Where(l=>l.ParentId==0).ToList();
				foreach (var item in listMenu)
				{
					item.CodeUrl = String.Format("/{0}/{1}",item.CodeUrl.Split('_')[0],item.CodeUrl.Split('_')[1]);
					item.SubMenus = cache.Get<List<Menu>>("MenuList").Where(l => l.ParentId == item.Id).ToList();
					foreach (var subMenu in item.SubMenus)
					{
						subMenu.CodeUrl = String.Format("/{0}/{1}",subMenu.CodeUrl.Split('_')[0],subMenu.CodeUrl.Split('_')[1]);
					}
				}
			return listMenu ?? new List<Menu>();
		}
	}
}
