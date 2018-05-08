using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using UI.Logic.Model;


namespace UI.Logic.BLL
{
	public static class MemberBll
	{
		private static SqlSugarClient db = UI.Logic.Model.Context.AuctionSystemContext.Instance;

		public static List<MemberDetails> MemberInfoList()
		{
			var list = db.Queryable<MemberDetails>().ToList();
			return list;
		}
	}
}
