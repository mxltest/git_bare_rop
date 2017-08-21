using Icson.FinanceAR.Caching.Impl;

namespace Net4Frm.Caching.Impl
{
    internal class CacheClientSession : ICacheClientSession
    {
        private static ICacheClients _localCacheClient;
        public ICacheClients LocalCacheClient
        {
            get
            {
                if (null == _localCacheClient)
                {
                    _localCacheClient = new LocalCacheClient();
                }
                return _localCacheClient;
            }
        }

        private static ICacheClients _memcachedClient;
        public ICacheClients MemcachedClient
        {
            get
            {
                if (null == _memcachedClient)
                {
                    _memcachedClient = new MemcachedClientWrap();
                }
                return _memcachedClient;
            }
        }
    }
}
