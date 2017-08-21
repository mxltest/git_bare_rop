using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceContainer.Impl
{
    internal partial class LightContainer : IContainer
    {
        private static Dictionary<string, object> _container;
        public void InitContainer()
        {
            _container = new Dictionary<string, object>();
            Container.Configer(new LightContainer());
        }

        public void Register<TClass, TInterface>(TClass tClass) where TClass : class, TInterface
        {
            _container.Add(typeof(TInterface).FullName, tClass);
        }

        public TInterface Resolve<TInterface>()
        {
            TInterface tInterface = default(TInterface);
            object obj;
            if (_container.TryGetValue(typeof(TInterface).FullName, out obj))
            {
                tInterface = (TInterface)obj;
            }

            return tInterface;
        }

        public bool TryResolve<TInterface>(out TInterface tInterface)
        {
            object obj;
            bool flag = false;
            tInterface = default(TInterface);
            if (_container.TryGetValue(typeof(TInterface).FullName, out obj))
            {
                tInterface = (TInterface)obj;
                flag = true;
            }
            return flag;
        }
    }
}
