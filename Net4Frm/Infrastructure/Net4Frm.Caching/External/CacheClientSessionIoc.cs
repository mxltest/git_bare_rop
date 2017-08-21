using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net4Frm.Caching.Impl;

namespace Net4Frm.Caching.External
{
    public class CacheClientSessionIoc
    {
        private static ICacheClientSession _cacheClientSession;
        public static ICacheClientSession GetCacheClientSession()
        {
            if (null == _cacheClientSession)
            {
                _cacheClientSession = new CacheClientSession();
            }
            return new CacheClientSession();
        }
    }
}
