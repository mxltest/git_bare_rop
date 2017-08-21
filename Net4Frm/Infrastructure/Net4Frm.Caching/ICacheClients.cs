using System;
using ServiceStack.CacheAccess;

namespace Net4Frm.Caching
{
    public interface ICacheClients : ICacheClient
    {
        T Get<T>(string key, Func<T> function) where T : new();
        T Get<T>(string key, Func<T> function, TimeSpan timeSpan) where T : new();
    }
}
