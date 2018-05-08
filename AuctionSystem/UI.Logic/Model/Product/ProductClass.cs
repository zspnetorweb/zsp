using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 商品类别表
	/// </summary>
	public class ProductClass
	{
		/// <summary>
		/// 商品类别ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 类别名
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 类别描述
		/// </summary>
		public string Description { get; set; }
	}
}
