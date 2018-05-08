using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 商品收藏表
	/// </summary>
	public class MemberFavorite
	{
		/// <summary>
		/// ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 商品ID
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// 会员ID
		/// </summary>
		public int MemberId { get; set; }
	}
}
