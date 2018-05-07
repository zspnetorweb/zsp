using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 商品表
	/// </summary>
	public class Product
	{
		/// <summary>
		/// 商品ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 商品名
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 商品描述
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// 商品单价
		/// </summary>
		public decimal Price { get; set; }
		/// <summary>
		/// 商品数量
		/// </summary>
		public int Quantity { get; set; }
		/// <summary>
		/// 商品图片
		/// </summary>
		public string Images { get; set; }
		/// <summary>
		/// 会员ID，外键
		/// </summary>
		public int MemberId { get; set; }
		/// <summary>
		/// 商品类别ID，外键
		/// </summary>
		public int ClassId { get; set; }
	}

}