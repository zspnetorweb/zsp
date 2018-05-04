using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using UI.Logic.Model;
using UI.Logic.Model.Context;
using Library;

namespace UI.Logic.BLL
{
	public static class AdminBll
	{
		private static readonly SqlSugarClient db = AuctionSystemContext.Instance;
		private static RedisCache cache = new RedisCache();
		/// <summary>
		/// 登录验证
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public static object LoginCheck(Administrator model)
		{
			var ar = new AjaxResult()
			{
				Code = 0,
				Title = "登录失败",
				Content = "请检查用户名和密码"
			};
			if (model != null)
			{
				model.Password = Tool.GetMd5(model.Password);
				var count = db.Queryable<Administrator>().Count(l=>l.UserName==model.UserName&&l.Password==model.Password);
				if (count > 0)
				{
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
	}
}
