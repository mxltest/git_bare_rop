using Net4Frm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationRolePrivilege
    {
        Ptcp<ModelBase> UpdatePrivilegeForRole(IEnumerable<N4_RolePrivilege> inserted_privileges, IEnumerable<N4_RolePrivilege> deleted_privileges);
        Ptcp<IEnumerable<N4_RolePrivilege>> QueryPrivilegeByRole(String role_uniqueid);
    }
}
