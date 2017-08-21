using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Department;
using Net4Frm.ServiceModel.Privilege;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Department
{
    public class UpdateUsersToRoleService : BaseService<IOperationUserRoleAndDepart>
    {
        public UpdateUsersToRoleRes Any(UpdateUsersToRoleReq req)
        {
            UpdateUsersToRoleRes res = new UpdateUsersToRoleRes();
            try
            {
                var inserted = Mapper.MapGeneric<UserRoleAndDepart, N4_UserRoleAndDepart>(req.inserted_users);
                var deleted = Mapper.MapGeneric<UserRoleAndDepart, N4_UserRoleAndDepart>(req.deleted_users);
                var ptcp = ServiceImpl.UpdateUsersToRole(inserted, deleted);
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
