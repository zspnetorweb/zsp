using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model.Admin
{
	public class IMenuList
	{
		public string Name { get; set; }
		public string CodeUrl { get; set; }
		public int ParentId { get; set; }
		public List<MenuList> MenuLists { get; set; }
	}
}
