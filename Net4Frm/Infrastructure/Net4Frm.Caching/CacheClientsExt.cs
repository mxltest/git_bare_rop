using System;
using Icson.FinanceAR.Caching;
using ServiceStack.ServiceHost;

namespace Net4Frm.Caching
{
    public static class CacheClientsExt
    {

        public static object ServiceCache<T>(this ICacheClients cacheClients, string cacheKey, Func<T> factoryFn, IRequestContext context,
                            TimeSpan? expireCacheIn = null) where T : class
        {
            //return cacheClient.Cache(cacheKey, responseDto, context, expireCacheIn);
            //context.CompressionType[1] = 1;
            return context.ToOptimizedResultUsingCache(cacheClients, cacheKey, expireCacheIn, factoryFn);
        }
    }
}
