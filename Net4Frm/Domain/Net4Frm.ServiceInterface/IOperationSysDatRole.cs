using Net4Frm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationSysDatRole
    {
        Ptcp<ModelBase> InsertSysDatRoleInfo(N4_SysDatRole role);
        Ptcp<ModelBase> InsertSysDatRoleInfos(IEnumerable<N4_SysDatRole> roles);
        Ptcp<ModelBase> UpdateSysDatRoleInfo(N4_SysDatRole role);
        IEnumerable<N4_SysDatRole> QueryRoles(PageQueryInput pager, N4_SysDatRole role);
    }
}
