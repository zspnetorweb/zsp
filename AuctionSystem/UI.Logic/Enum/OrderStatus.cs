using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Enum
{
	public enum OrderStatus
	{
		[Description("已取消")]
		AlreadyCancel = -1,

		[Description("未付款")]
		NonPayment = 0,

		[Description("待发货")]
		WaitDeliverGoods = 1,

		[Description("已发货")]
		AlreadyDeliverGoods = 2,

		[Description("已签收")]
		AlreadySignFor = 3,

		[Description("待评论")]
		WaitComment = 4
	}
}
