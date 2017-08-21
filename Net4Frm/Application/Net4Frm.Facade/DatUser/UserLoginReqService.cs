using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatUser
{
    public class UserLoginReqService : BaseService<IOperationSysDatUser>
    {
        public UserLoginRes Any(UserLoginReq req)
        {
            UserLoginRes res = new UserLoginRes();
            try
            {
                var ptLog = ServiceImpl.LogIn(req.uid, req.pwd);
                if (ptLog.StatusFlag == PtcpState.Success)
                {
                    res.userinfo = Mapper.Map<N4_SysDatUser, UserInfo>(ptLog.ReturnValue.userinfo);
                    if (res.userinfo != null)
                    {
                        res.userinfo.Pwd = null;
                    }
                    res.privilege = Mapper.MapGeneric<N4_UserPrivilege, UserPrivilege>(ptLog.ReturnValue.privilege);
                    res.DoFlag = true;
                    res.DoResult = ptLog.Message;
                }
                else
                {
                    res.DoFlag = false;
                    res.DoResult = ptLog.Message;
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
