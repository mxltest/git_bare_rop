using Net4Frm.Assembler;
using Net4Frm.Assembler.External;
using Net4Frm.Assembler.Impl;
using Net4Frm.Logging;
using Net4Frm.Logging.External;
using Net4Frm.ServiceContainer.External;
using ServiceStack.ServiceInterface;

namespace Net4Frm.Facade
{
    public class BaseService<T> : Service
    {
        protected T ServiceImpl { get; set; }

        protected TInterface Resolve<TInterface>()
        {
            return ContainerFactory.GetContainer().Resolve<TInterface>();
        }

        public BaseService()
        {
            ServiceImpl = ContainerFactory.GetContainer().Resolve<T>();
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

        private IUserLogger _logger;
        public IUserLogger Logger
        {
            get
            {
                if (null == _logger)
                {
                    _logger = LoggerIoc.GetLogger();
                }

                return _logger;
            }
        }
    }
}
