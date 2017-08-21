using Net4Frm.Model;
using Net4Frm.Model.Extension;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationPrivilegeReportImpl : BaseService, IOperationPrivilegeReport
    {
        #region 查询某用户的权限报表数据API
        /// <summary>
        /// 查询某用户的权限报表数据
        /// </summary>
        /// <param name="pageInput"></param>
        /// <param name="user_uniqueid"></param>
        /// <returns></returns>
        public Ptcp<UserPrivilegeRes> QueryDataPrivelegeOfUser(String user_uniqueid)
        {
            Ptcp<UserPrivilegeRes> ptcp = new Ptcp<UserPrivilegeRes>();
            UserPrivilegeRes res = new UserPrivilegeRes();
            List<N4_UserRoleAndDepart> ilist = new List<N4_UserRoleAndDepart>();
            List<string> list = new List<string>();
            try
            {
                //1.根据uniqueid获取用户信息
                res.userinfo = DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { Uniqueid = user_uniqueid, Is_deleted = false }).FirstOrDefault();
                //2.根据uniqueid获取用户角色关系信息
                ilist = DbSession.N4_UserRoleAndDepartRepository.QueryBy(new N4_UserRoleAndDepart { User_uniqueid = user_uniqueid, Is_deleted = false }).ToList();
                foreach (var v in ilist)
                {
                    //3.查找角色表信息
                    res.roles = DbSession.N4_SysDatRoleRepository.QueryBy(new N4_SysDatRole { Unique_id = v.Role_uniqueid, Is_deleted = false }).ToList();
                    //4.查找角色权限项信息
                    res.function_privilege = DbSession.N4_RolePrivilegeRepository.QueryBy(new N4_RolePrivilege { Role_uniqueid = v.Role_uniqueid, Is_deleted = false }).ToList();
                }
                //var results = DbSession.N4_DataPrivilege_ofUserRepository.QueryPageBy( new N4_DataPrivilege_ofUser { User_uniqueid = user_uniqueid });
                ptcp.ReturnValue = res;

                ptcp.StatusFlag = PtcpState.Success;
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
            }
            return ptcp;
        }
        #endregion
    }
}
