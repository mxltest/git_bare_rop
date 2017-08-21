using System;
using ServiceStack.CacheAccess.Providers;

namespace Net4Frm.Caching.Impl
{
    internal class LocalCacheClient : MemoryCacheClient, ICacheClients
    {
        private static readonly object LockObj = new object();
        public T Get<T>(string key, Func<T> function) where T : new()
        {
            T t = Get<T>(key);
            if (null == t)
            {
                lock (LockObj)
                {
                    t = Get<T>(key);
                    if (null == t)
                    {
                        t = function();
                        if (t == null)
                        {
                            t = new T();
                        }
                        Set(key, t);
                    }
                }
            }
            return t;
        }

        public T Get<T>(string key, Func<T> function, TimeSpan timeSpan) where T : new()
        {
            T t = Get<T>(key);
            if (null == t)
            {
                lock (LockObj)
                {
                    t = Get<T>(key);
                    if (null == t)
                    {
                        t = function();
                        if (t == null)
                        {
                            t = new T();
                        }
                        Set(key, t, timeSpan);
                    }
                }
            }
            return t;
        }
    }
}
