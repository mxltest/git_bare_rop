using Net4Frm.ServiceImplement;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Net4Frm.ServiceImplement;
//using Net4Frm.ServiceInterface;
namespace Net4Frm.ServiceContainer
{
    internal class Container
    {
        internal static void Configer(IContainer container)
        {
            container.Register<OperationSysDatUserImpl, IOperationSysDatUser>(new OperationSysDatUserImpl());
            container.Register<OperationSysDatRoleImpl, IOperationSysDatRole>(new OperationSysDatRoleImpl());
            container.Register<OperationRolePrivilegeImpl, IOperationRolePrivilege>(new OperationRolePrivilegeImpl());
            container.Register<OperationUserRoleAndDepartImpl, IOperationUserRoleAndDepart>(new OperationUserRoleAndDepartImpl());
            container.Register<OperationDepartmentImpl, IOperationDepartment>(new OperationDepartmentImpl());
            container.Register<OperationDataPrivilegeImpl, IOperationDataPrivilege>(new OperationDataPrivilegeImpl());
            container.Register<OperationCheckDataUniqueImpl, IOperationCheckDataUnique>(new OperationCheckDataUniqueImpl());
<<<<<<< HEAD
            container.Register<OperationPrivilegeReportImpl, IOperationPrivilegeReport>(new OperationPrivilegeReportImpl());
=======
            container.Register<OperationWorkCalTemplateImpl, IOperationWorkCalTemplate>(new OperationWorkCalTemplateImpl());
>>>>>>> master
            
            
        }
    }
}
