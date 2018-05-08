using System;

namespace Library
{
	public interface ICache
	{
		/// <summary>
		/// 缓存过期时间
		/// </summary>
		int TimeOut { get; set; }
		/// <summary>
		/// 获取指定值的缓存值
		/// </summary>
		/// <param name="key">缓存键</param>
		/// <returns>缓存值</returns>
		object Get(string key);
		/// <summary>
		/// 获取指定键的缓存值
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key"></param>
		/// <returns></returns>
		T Get<T>(string key);
		/// <summary>
		/// 从缓存中移除指定键的缓存值
		/// </summary>
		/// <param name="key"></param>
		void Remove(string key);
		/// <summary>
		/// 清空所以缓存对象
		/// </summary>
		void Clear();
		/// <summary>
		/// 将指定键的对象添加到缓存中
		/// </summary>
		/// <param name="key"></param>
		/// <param name="data"></param>
		void Insert(string key, object data);
		/// <summary>
		/// 将指定键的对象添加到缓存中
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key"></param>
		/// <param name="data"></param>
		void Insert<T>(string key, T data);
		/// <summary>
		/// 将指定键的对象添加到缓存中，并指定过期时间
		/// </summary>
		/// <param name="key"></param>
		/// <param name="data"></param>
		/// <param name="cacheTime"></param>
		void Insert(string key, object data, int cacheTime);
		/// <summary>
		/// 将指定键的对象添加到缓存中,并指定过期时间
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key"></param>
		/// <param name="data"></param>
		/// <param name="cacheTime"></param>
		void Insert<T>(string key, T data, int cacheTime);
		/// <summary>
		/// 将指定键的对象添加到缓存中,并指定过期时间
		/// </summary>
		/// <param name="key"></param>
		/// <param name="data"></param>
		/// <param name="cacheTime"></param>
		void Insert(string key, object data, DateTime cacheTime);
		/// <summary>
		/// 将指定键的对象添加到缓存中,并指定过期时间
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key"></param>
		/// <param name="data"></param>
		/// <param name="cacheTime"></param>
		void Insert<T>(string key, T data, DateTime cacheTime);
		/// <summary>
		/// 判断key是否存在
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		bool Exists(string key);
	}
}
