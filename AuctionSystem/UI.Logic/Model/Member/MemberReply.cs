using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 消息回复表
	/// </summary>
	public class MemberReply
	{
		/// <summary>
		/// ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 会员留言ID，外键
		/// </summary>
		public int MemMessageId { get; set; }
		/// <summary>
		/// 会员评论ID,外键
		/// </summary>
		public int MenCommentId { get; set; }
		/// <summary>
		/// 回复消息
		/// </summary>
		public string ReplyMessage { get; set; }
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime ReplyTime { get; set; }
	}
}
