using Net4Frm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationUserRoleAndDepart
    {
        Ptcp<IEnumerable<N4_SysDatUser>> QueryUsersByRole(PageQueryInput pager, String role_uniqueid);
        Ptcp<ModelBase> UpdateUsersToRole(IEnumerable<N4_UserRoleAndDepart> inserted_users, IEnumerable<N4_UserRoleAndDepart> deleted_users);
    }
}
