using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace UI.Logic.Model.Context
{
	public class AuctionSystemContext
	{
		public static SqlSugarClient Instance
		{
			get
			{
				return new SqlSugarClient(new ConnectionConfig()
				{
					ConnectionString = ConfigurationManager.ConnectionStrings["SqlServerConn"].ToString(),
					DbType = DbType.SqlServer,
					IsAutoCloseConnection = true,
					InitKeyType = InitKeyType.SystemTable
				});
			}
		}
	}
}
