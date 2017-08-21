using System;
using Net4Frm.Assembler;
using Net4Frm.Assembler.External;
using Net4Frm.Caching;
using Net4Frm.Caching.External;
using Net4Frm.IRepository;
using Net4Frm.Logging;
using Net4Frm.RepositoryFactory;
using ServiceStack.ServiceClient.Web;
using Net4Frm.Logging.External;

namespace Net4Frm.ServiceImplement
{
    public class BaseService : INotice
    {
        //private IDbSession _dbSession;
        protected IDbSession DbSession
        {
            get
            {
                //if (null == _dbSession)
                //{
                //    _dbSession = DbSessionFactory.GetDbSession();
                //}
                //return _dbSession;
                return DbSessionFactory.GetDbSession(); ;
            }
        }

        private IMapper _mapper;
        public IMapper Mapper
        {
            get
            {
                if (null == _mapper)
                {
                    _mapper = AssemblerIoc.GetMapper();
                }
                return _mapper;
            }
        }

        //private IUserLogger _logger;
        //protected IUserLogger Logger
        //{
        //    get
        //    {
        //        if (null == _logger)
        //        {
        //            _logger = LoggerIoc.GetLogger();
        //        }
        //        return _logger;
        //    }
        //}

        private ICacheClientSession _cacheClientSession;
        public ICacheClientSession CacheClientSession
        {
            get { return _cacheClientSession ?? (_cacheClientSession = CacheClientSessionIoc.GetCacheClientSession()); }
        }

       

    }
}
