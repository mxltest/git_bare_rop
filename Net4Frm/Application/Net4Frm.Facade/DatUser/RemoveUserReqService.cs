using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatUser
{
    public class RemoveUserReqService : BaseService<IOperationSysDatUser>
    {
        public RemoveUserRes Any(RemoveUserReq req)
        {
            RemoveUserRes res = new RemoveUserRes();

            var ptcp = ServiceImpl.RemoveUser(req.Uniqueid);

            res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
            res.DoResult = ptcp.Message;
            return res;
        }
    }
}
