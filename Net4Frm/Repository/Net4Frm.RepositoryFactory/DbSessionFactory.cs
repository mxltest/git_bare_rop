using System.Runtime.Remoting.Messaging;
using Net4Frm.IRepository;

namespace Net4Frm.RepositoryFactory
{
    public class DbSessionFactory
    {
        public static IDbSession GetDbSession()
        {
            string dbSessionKey = string.Format("{0}_DbSession", typeof(DbSessionFactory).Name);

            IDbSession dbSession = (IDbSession)CallContext.GetData(dbSessionKey);

            if (null == dbSession)
            {
                dbSession = new DbSession();
                CallContext.SetData(dbSessionKey, dbSession);
            }

            return dbSession;
        }
    }
}
