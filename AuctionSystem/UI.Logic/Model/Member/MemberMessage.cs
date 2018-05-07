using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 会员留言表
	/// </summary>
	public class MemberMessage
	{
		/// <summary>
		/// ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 会员ID，外键
		/// </summary>
		public int MemberId { get; set; }
		/// <summary>
		/// 商品ID，外键
		/// </summary>
		protected int ProductId { get; set; }
		/// <summary>
		/// 留言消息
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// 留言时间
		/// </summary>
		public DateTime MessageTime { get; set; }
	}
}
