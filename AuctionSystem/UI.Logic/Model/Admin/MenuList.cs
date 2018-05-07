using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model.Admin
{
	public class MenuList
	{
		/// <summary>
		/// Id
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 菜单名
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 菜单链接
		/// </summary>
		public string CodeUrl { get; set; }
		/// <summary>
		/// 父级菜单主键
		/// </summary>
		public int ParentId { get; set; }

	}
}
