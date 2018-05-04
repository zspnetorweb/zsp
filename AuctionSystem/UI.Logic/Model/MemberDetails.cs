using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Logic.Model
{
	/// <summary>
	/// 会员信息表
	/// </summary>
	public class MemberDetails
	{
		public MemberDetails()
		{
			
		}
		/// <summary>
		/// 会员信息ID
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 会员ID，外键
		/// </summary>
		public int MemberId { get; set; }
		/// <summary>
		/// 真实姓名
		/// </summary>
		public string RealName { get; set; }
		/// <summary>
		/// 出生日期
		/// </summary>
		public DateTime Birthdate { get; set; }
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// 收货地址
		/// </summary>
		public string ShippingAddress { get; set; }
	}
}
