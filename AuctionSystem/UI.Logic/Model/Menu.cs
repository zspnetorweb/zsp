using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	public class Menu
	{
		/// <summary>
		/// ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 链接
		/// </summary>
		public string CodeUrl { get; set; }
		/// <summary>
		/// 父ID
		/// </summary>
		public int ParentId { get; set; }
		/// <summary>
		/// 子菜单
		/// </summary>
		public List<Menu> SubMenus { get; set; }
	}
}
