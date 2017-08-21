using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Privilege;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Privilege
{
    public class QueryPrivilegeByRoleService : BaseService<IOperationRolePrivilege>
    {
        public QueryPrivilegeByRoleRes Any(QueryPrivilegeByRoleReq req)
        {
            QueryPrivilegeByRoleRes res = new QueryPrivilegeByRoleRes();
            try
            {
                var ptcp = ServiceImpl.QueryPrivilegeByRole(req.Role_uniqueid);
                res.privileges_of_role = Mapper.MapGeneric<N4_RolePrivilege, RolePrivilegeInfo>(ptcp.ReturnValue);
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
