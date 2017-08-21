using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatRole
{
    public class AddRoleInfoService : BaseService<IOperationSysDatRole>
    {
        public AddRoleInfoRes Any(AddRoleInfoReq req)
        {
            AddRoleInfoRes res = new AddRoleInfoRes();
            try
            {
                var data = Mapper.Map<AddRoleInfoReq, N4_SysDatRole>(req);
                var ptcp = ServiceImpl.InsertSysDatRoleInfo(data);
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
