using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 会员评论
	/// </summary>
	public class MemberComment
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
		/// 订单ID，外键
		/// </summary>
		public int OrderId { get; set; }
		/// <summary>
		/// 评论消息
		/// </summary>
		public string Comment { get; set; }
		/// <summary>
		/// 评论时间
		/// </summary>
		public DateTime CommentTime { get; set; }
	}
}
