using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using UI.Logic.Model;
using UI.Logic.Model.Context;

namespace UI.Logic.UIBLL
{
	public class MemberBll
	{
		private static readonly RedisCache Cache = new RedisCache();
		/// <summary>
		/// 用户注册
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public static AjaxResult Register(Member model)
		{
			var db = AuctionSystemContext.Instance;
			var ar = new AjaxResult()
			{
				Code = 0,Title = "注册失败",Content = "请检查原因"
			};
			try
			{
				 //判断缓存是否过期
				if (Cache.Get<List<Member>>("MemberList") == null)
				{
					var memberList = db.Queryable<Member>().ToList();
					Cache.Insert("MemberList",memberList);
				}
				//判断用户名是否存在
				var userNameCount = Cache.Get<List<Member>>("MemberList").Count(l => l.UserName == model.UserName);
				if (userNameCount > 0)
				{
					ar.Content = "用户名已存在";
					return ar;
				}
				//判断手机号码是否存在
				var phoneCount = Cache.Get<List<Member>>("MemberList").Count(l => l.Phone == model.Phone);
				if (phoneCount > 0)
				{
					ar.Content = "手机号码已被注册";
					return ar;
				}
				//MD5加密
				model.Password = Tool.GetMd5(model.Password);
				//注册时间
				model.HappenTime = DateTime.Now;
				var rows = db.Insertable(model).ExecuteCommand();
				if (rows > 0)
				{
					Cache.Remove("MemberList");
					ar.Code = 1;
					ar.Title = "注册成功";
					ar.Content = "正在跳转登录页";
				}
			}
			catch (Exception ex)
			{
				ar.Content = ex.Message;
			}
			return ar;
		}
	}
}
