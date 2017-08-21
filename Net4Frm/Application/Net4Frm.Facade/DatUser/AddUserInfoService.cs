using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatUser
{
    public class AddUserInfoService : BaseService<IOperationSysDatUser>
    {
        public AddUserRes Any(AddUserReq req)
        {
            
            AddUserRes res = new AddUserRes();
            try
            {
                var data = Mapper.Map<AddUserReq, N4_SysDatUser>(req);
                var ptcp = ServiceImpl.InsertSysDatUserInfo(data);
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;

            }
            catch(Exception ex)
            {
                res.DoResult = ex.Message;
                res.DoFlag = false;
            }
            return res;
        }
    }
}
