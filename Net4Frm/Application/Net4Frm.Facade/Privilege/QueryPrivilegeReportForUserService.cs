using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Privilege;
using Net4Frm.ServiceModel.User;
using Net4Frm.ServiceModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Privilege
{
    public class QueryPrivilegeReportForUserService : BaseService<IOperationPrivilegeReport>
    {
        public queryPrivilegeReportForUserReqRes Any(queryPrivilegeReportForUserReq req)
        {
            queryPrivilegeReportForUserReqRes res = new queryPrivilegeReportForUserReqRes();
            try
            {
                var ptcp = ServiceImpl.QueryDataPrivelegeOfUser(req.user_uniqueid);
                if (ptcp.StatusFlag == PtcpState.Success)
                {
                    res.userinfo = Mapper.Map<N4_SysDatUser, UserInfo>(ptcp.ReturnValue.userinfo);
                    res.roles = Mapper.MapGeneric<N4_SysDatRole, RoleInfo_PrivilegeReport_ofUser>(ptcp.ReturnValue.roles);
                    res.function_privilege = Mapper.MapGeneric<N4_RolePrivilege, RolePrivilegeInfo>(ptcp.ReturnValue.function_privilege);
                    res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                    res.DoResult = ptcp.Message;
                }
                else
                {
                    res.DoFlag = false;
                    res.DoResult = ptcp.Message;
                }
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
