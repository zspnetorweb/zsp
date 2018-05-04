using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 广告
	/// </summary>
	public class Banner
	{
		/// <summary>
		/// ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 轮播图
		/// </summary>
		public string Images { get; set; }
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; }
	}
}
