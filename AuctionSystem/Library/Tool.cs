using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Library
{
	/// <summary>
	/// 工具类
	/// </summary>
	public static class Tool
	{
		/// <summary>
		/// MD5加密
		/// </summary>
		/// <param name="password"></param>
		/// <returns></returns>
		public static string GetMd5(string password)
		{
			var md5 = MD5.Create();
			var buffer = Encoding.UTF8.GetBytes(password);
			var newBuffer = md5.ComputeHash(buffer);
			var sb = new StringBuilder();
			foreach (var b in newBuffer)
			{
				sb.Append(b.ToString("x2"));
			}
			return sb.ToString();
		}

		/// <summary>
		/// 获取枚举描述
		/// </summary>
		/// <param name="enumValue"></param>
		/// <returns></returns>
		public static string GetEnumDescription(Enum enumValue)
		{
			string value = enumValue.ToString();
			FieldInfo field = enumValue.GetType().GetField(value);
			object[] objs = field.GetCustomAttributes(typeof (DescriptionAttribute), false);//获取描述属性
			if (objs == null || objs.Length == 0)//当描述属性没有时，直接返回名称
				return value;
			DescriptionAttribute descriptionAttribute = objs[0] as DescriptionAttribute;
			return descriptionAttribute.Description;
		}
	}
}
