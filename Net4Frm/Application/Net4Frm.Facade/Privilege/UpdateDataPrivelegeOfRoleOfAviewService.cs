using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Privilege;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Privilege
{
    /// <summary>
    ///  更新某角色的数据权限列表 
    /// </summary>
    public class UpdateDataPrivelegeOfRoleOfAviewService : BaseService<IOperationDataPrivilege>
    {
        public UpdateDataPrivelegeOfRoleOfAviewRes Any(UpdateDataPrivelegeOfRoleOfAviewReq req)
        {
            UpdateDataPrivelegeOfRoleOfAviewRes res = new UpdateDataPrivelegeOfRoleOfAviewRes();
            try
            {
                var inserted = Mapper.MapGeneric<DataPrivilege_ofRole, N4_DataPrivilege_ofRole>(req.inserted);
                var deleted = Mapper.MapGeneric<DataPrivilege_ofRole, N4_DataPrivilege_ofRole>(req.deleted);
                var updated = Mapper.MapGeneric<DataPrivilege_ofRole, N4_DataPrivilege_ofRole>(req.updated);
                var ptcp = ServiceImpl.UpdateDataPrivelegeOfRoleOfAview(inserted, deleted, updated);
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
