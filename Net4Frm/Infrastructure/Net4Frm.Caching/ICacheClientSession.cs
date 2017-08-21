
namespace Net4Frm.Caching
{
    public interface ICacheClientSession
    {
        ICacheClients LocalCacheClient { get; }
        ICacheClients MemcachedClient { get; }
    }
}
