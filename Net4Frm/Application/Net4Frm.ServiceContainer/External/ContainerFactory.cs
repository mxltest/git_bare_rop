using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Net4Frm.ServiceContainer.Impl;

namespace Net4Frm.ServiceContainer.External
{
    public class ContainerFactory
    {
        private static IContainer _container;

        public static IContainer GetContainer()
        {
            if (null == _container)
            {
                _container = new LightContainer();
            }
            return _container;
        }
    }
}
