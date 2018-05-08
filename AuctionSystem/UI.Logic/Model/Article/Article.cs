using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 文章表
	/// </summary>
	public class Article
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
		/// 图片路径
		/// </summary>
		public string Images { get; set; }
		/// <summary>
		/// 标题
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// 内容
		/// </summary>
		public string Details { get; set; }
		/// <summary>
		/// 发生时间
		/// </summary>
		public DateTime HappenTime { get; set; }
		/// <summary>
		/// 审核状态
		/// </summary>
		public int State { get; set; }
	}
}
