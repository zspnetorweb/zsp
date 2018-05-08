using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	public class AjaxResult
	{
		/// <summary>
		/// 0：失败；1：成功
		/// </summary>
		public int Code { get; set; }
		/// <summary>
		/// 结果消息-标题
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// 结果消息-内容
		/// </summary>
		public string Content { get; set; }
	}
}
