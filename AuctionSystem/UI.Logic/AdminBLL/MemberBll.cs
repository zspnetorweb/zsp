using System.Collections.Generic;
using SqlSugar;
using UI.Logic.Model;

namespace UI.Logic.AdminBLL
{
	public static class MemberBll
	{
		private static SqlSugarClient db = Model.Context.AuctionSystemContext.Instance;

		public static List<MemberDetails> MemberInfoList()
		{
			var list = db.Queryable<MemberDetails>().ToList();
			return list;
		}
	}
}
