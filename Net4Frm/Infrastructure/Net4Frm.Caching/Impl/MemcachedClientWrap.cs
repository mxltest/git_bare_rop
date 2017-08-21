using System;
using System.Collections.Generic;
using Enyim.Caching;
using Enyim.Caching.Memcached;
using Net4Frm.Caching;

namespace Icson.FinanceAR.Caching.Impl
{
    internal class MemcachedClientWrap : ICacheClients
    {
        //初始化Memcached的链路
        private static MemcachedClient _memcachedClient = MemcachedClient.CacheClient;


        public bool Add<T>(string key, T value, System.TimeSpan expiresIn)
        {
            return _memcachedClient.Store(StoreMode.Add, key, value, expiresIn);
        }

        public bool Add<T>(string key, T value, System.DateTime expiresAt)
        {
            return _memcachedClient.Store(StoreMode.Add, key, value, expiresAt);
        }

        public bool Add<T>(string key, T value)
        {
            return _memcachedClient.Store(StoreMode.Add, key, value);
        }

        public long Decrement(string key, uint amount)
        {
            return _memcachedClient.Decrement(key, amount);
        }

        public void FlushAll()
        {
            _memcachedClient.FlushAll();
        }

        public T Get<T>(string key)
        {
            return _memcachedClient.Get<T>(key);
        }

        public System.Collections.Generic.IDictionary<string, T> GetAll<T>(System.Collections.Generic.IEnumerable<string> keys)
        {
            //获取指定key 全部数据
            var dics = _memcachedClient.Get_Multi(keys);
            //初始容器
            IDictionary<string, T> dictionary = null;
            //转换数据
            if (dics.Count >= 0)
            {
                dictionary = new Dictionary<string, T>();
                foreach (KeyValuePair<string, object> keyValuePair in dics)
                {
                    dictionary.Add(keyValuePair.Key, (T)keyValuePair.Value);
                }
            }
            return dictionary;
        }

        public long Increment(string key, uint amount)
        {
            return _memcachedClient.Increment(key, amount);
        }

        public bool Remove(string key)
        {
            return _memcachedClient.Remove(key);
        }

        public void RemoveAll(System.Collections.Generic.IEnumerable<string> keys)
        {
            foreach (string key in keys)
            {
                _memcachedClient.Remove(key);
            }
        }

        public bool Replace<T>(string key, T value, System.TimeSpan expiresIn)
        {
            return _memcachedClient.Store(StoreMode.Replace, key, value, expiresIn);
        }

        public bool Replace<T>(string key, T value, System.DateTime expiresAt)
        {
            return _memcachedClient.Store(StoreMode.Replace, key, value, expiresAt);
        }

        public bool Replace<T>(string key, T value)
        {
            return _memcachedClient.Store(StoreMode.Replace, key, value);
        }

        public bool Set<T>(string key, T value, System.TimeSpan expiresIn)
        {
            return _memcachedClient.Store(StoreMode.Set, key, value, expiresIn);
        }

        public bool Set<T>(string key, T value, System.DateTime expiresAt)
        {
            return _memcachedClient.Store(StoreMode.Set, key, value, expiresAt);
        }

        public bool Set<T>(string key, T value)
        {
            return _memcachedClient.Store(StoreMode.Set, key, value);
        }

        public void SetAll<T>(System.Collections.Generic.IDictionary<string, T> values)
        {
            foreach (KeyValuePair<string, T> keyValuePair in values)
            {
                _memcachedClient.Store(StoreMode.Set, keyValuePair.Key, keyValuePair.Value);
            }
        }

        public void Dispose()
        {
            _memcachedClient.Dispose();
        }

        public T Get<T>(string key, Func<T> function) where T : new()
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key, Func<T> function, TimeSpan timeSpan) where T : new()
        {
            throw new NotImplementedException();
        }
    }
}
