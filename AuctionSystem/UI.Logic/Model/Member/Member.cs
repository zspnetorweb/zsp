using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 会员表
	/// </summary>
	public class Member
	{
		/// <summary>
		/// 会员ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 会员名（登录名）
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// 密码
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// 手机号码
		/// </summary>
		public string Phone { get; set; }
		/// <summary>
		/// 发生时间
		/// </summary>
		public DateTime HanppenTime { get; set; }
	}
}
