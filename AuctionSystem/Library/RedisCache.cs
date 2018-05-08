using System;
using System.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Library
{
	public class RedisCache:ICache
	{
		private int Default_Timeout = 600;//默认超时时间（秒）
		private string address;

		private JsonSerializerSettings jsonConfig = new JsonSerializerSettings()
		{
			ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
			NullValueHandling = NullValueHandling.Ignore
		};

		private ConnectionMultiplexer connectionMultiplexer;
		private IDatabase database;

		class CacheObject<T>
		{
			public int ExpireTime { get; set; }
			public bool ForceOutofDate { get; set; }
			public T Value { get; set; }
		}

		public RedisCache()
		{
			this.address = ConfigurationManager.ConnectionStrings["RedisConn"].ToString();
			if(this.address==null||string.IsNullOrWhiteSpace(this.address.ToString()))
				throw new ApplicationException("配置文件中未找到RedisServer的有效配置");
			this.connectionMultiplexer = ConnectionMultiplexer.Connect(address);
			this.database = connectionMultiplexer.GetDatabase();
		}
		/// <summary>
		/// 连接超时设置
		/// </summary>
		public int TimeOut
		{
			get { return Default_Timeout; }
			set { Default_Timeout = value; }
		}

		public object Get(string key)
		{
			return Get<object>(key);
		}

		public T Get<T>(string key)
		{
			DateTime begin = DateTime.Now;
			var cacheValue = database.StringGet(key);
			DateTime endCache = DateTime.Now;
			var value = default(T);
			if (!cacheValue.IsNull)
			{
				var cacheObject = JsonConvert.DeserializeObject<CacheObject<T>>(cacheValue, jsonConfig);
				if (!cacheObject.ForceOutofDate)
					database.KeyExpire(key, new TimeSpan(0, 0, cacheObject.ExpireTime));
				value = cacheObject.Value;
			}
			DateTime endJson = DateTime.Now;
			return value;
		}

		public void Remove(string key)
		{
			database.KeyDelete(key, CommandFlags.HighPriority);
		}

		public void Clear()
		{
		}

		public void Insert(string key, object data)
		{
			var jsonData = GetJsonData(data, TimeOut, false);
			database.StringSet(key, jsonData);
		}

		public void Insert<T>(string key, T data)
		{
			var jsonData = GetJsonData<T>(data, TimeOut, false);
			database.StringSet(key, jsonData);
		}

		public void Insert(string key, object data, int cacheTime)
		{
			var timeSpan = TimeSpan.FromSeconds(cacheTime);
			var jsonData = GetJsonData(data, TimeOut, true);
			database.StringSet(key, jsonData, timeSpan);
		}

		public void Insert<T>(string key, T data, int cacheTime)
		{
			var timeSpan = TimeSpan.FromSeconds(cacheTime);
			var jsonData = GetJsonData<T>(data, TimeOut, true);
			database.StringSet(key, jsonData, timeSpan);
		}

		public void Insert(string key, object data, DateTime cacheTime)
		{
			var timeSpan = cacheTime - DateTime.Now;
			var jsonData = GetJsonData(data, TimeOut, true);
			database.StringSet(key, jsonData, timeSpan);
		}

		public void Insert<T>(string key, T data, DateTime cacheTime)
		{
			var timeSpan = cacheTime - DateTime.Now;
			var jsonData = GetJsonData<T>(data, TimeOut, true);
			database.StringSet(key, jsonData, timeSpan);
		}

		private string GetJsonData(object data, int cacheTime, bool forceOutOfDate)
		{
			var cacheObject = new CacheObject<object>(){Value = data,ExpireTime = cacheTime,ForceOutofDate = forceOutOfDate};
			return JsonConvert.SerializeObject(cacheObject, jsonConfig);
		}

		private string GetJsonData<T>(T data, int cacheTime, bool forceOutOfDate)
		{
			var cacheObject = new CacheObject<T>(){Value = data,ExpireTime = cacheTime,ForceOutofDate = forceOutOfDate};
			return JsonConvert.SerializeObject(cacheObject, jsonConfig);
		}

		public bool Exists(string key)
		{
			return database.KeyExists(key);
		}
	}
}
