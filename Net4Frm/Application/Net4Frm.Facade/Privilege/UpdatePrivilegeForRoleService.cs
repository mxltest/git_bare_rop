using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Privilege;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Privilege
{
    public class UpdatePrivilegeForRoleService : BaseService<IOperationRolePrivilege>
    {
        public UpdatePrivilegeForRoleRes Any(UpdatePrivilegeForRoleReq req)
        {
            UpdatePrivilegeForRoleRes res = new UpdatePrivilegeForRoleRes();
            try
            {
                var inserted = Mapper.MapGeneric<RolePrivilegeInfo, N4_RolePrivilege>(req.inserted_privileges);
                var deleted = Mapper.MapGeneric<RolePrivilegeInfo, N4_RolePrivilege>(req.deleted_privileges);
                var ptcp = ServiceImpl.UpdatePrivilegeForRole(inserted, deleted);
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;

            }
            catch (Exception ex)
            {
                res.DoResult = ex.Message;
                res.DoFlag = false;
            }
            return res;
        }
    }
}
