using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatRole
{
    public class UpdateRoleInfoService : BaseService<IOperationSysDatRole>
    {
        public UpdateRoleInfoRes Any(UpdateRoleInfoReq req)
        {
            UpdateRoleInfoRes res = new UpdateRoleInfoRes();
            try
            {
                var data = Mapper.Map<UpdateRoleInfoReq, N4_SysDatRole>(req);
                var ptcp = ServiceImpl.UpdateSysDatRoleInfo(data);
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
