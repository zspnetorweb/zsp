using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 订单表
	/// </summary>
	public class Order
	{
		/// <summary>
		/// 订单ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 商品ID，外键
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// 会员ID，外键
		/// </summary>
		public int MemberId { get; set; }
		/// <summary>
		/// 快递单号
		/// </summary>
		public string ExpressNumber { get; set; }
		/// <summary>
		/// 配送方式
		/// </summary>
		public string DeliveryMethod { get; set; }
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; }
		/// <summary>
		/// 支付方式
		/// </summary>
		public string PayMethod { get; set; }
		/// <summary>
		/// 支付时间
		/// </summary>
		public DateTime? PayTime { get; set; }
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime SubmitTime { get; set; }
		/// <summary>
		/// 订单状态
		/// </summary>
		public int State { get; set; }
	}
}
