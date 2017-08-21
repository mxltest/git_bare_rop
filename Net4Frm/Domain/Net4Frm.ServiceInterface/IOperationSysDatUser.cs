using Net4Frm.Model;
using Net4Frm.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationSysDatUser
    {
        Ptcp<ModelBase> InsertSysDatUserInfo(N4_SysDatUser datUser);
        Ptcp<ModelBase> UpdateSysDatUserInfo(N4_SysDatUser datUser);

        //IEnumerable<N4_SysDatUser> SearchSysDatUsers(N4_SysDatUser datUser);
        IEnumerable<N4_logToUserLoginout> SearchUserLoginOut(N4_logToUserLoginout login, int pageSize, int pageIndex, out long total);
        IEnumerable<N4_logToUserLoginout> SearchUserLoginException(N4_logToUserLoginout login, int pageSize, int pageIndex, out long total);
        IEnumerable<N4_logToUserOperation> SearchUserOperation(N4_logToUserOperation operation, int pageSize, int pageIndex, out long total);
        IEnumerable<N4_logToUserOperation> SearchUserOperationException(N4_logToUserOperation operation, int pageSize, int pageIndex, out long total);
        IEnumerable<N4_SysDatUser> QueryUsers(PageQueryInput pagerInfo, N4_SysDatUser query_entity);
        N4_SysDatUser QueryUserByUniqueid(String uniqueid);
        Ptcp<UserLoginRes> LogIn(String user_name, string pwd);
        Ptcp<ModelBase> RemoveUser(String uniqueid);



    }
}
