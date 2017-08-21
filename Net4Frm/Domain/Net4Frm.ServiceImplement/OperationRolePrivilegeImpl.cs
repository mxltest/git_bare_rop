using Net4Frm.Log4Net;
using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationRolePrivilegeImpl : BaseService, IOperationRolePrivilege
    {
        #region 更新角色权限API
        /// <summary>
        /// 更新角色权限
        /// </summary>
        /// <param name="inserted_privileges"></param>
        /// <param name="deleted_privileges"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdatePrivilegeForRole(IEnumerable<N4_RolePrivilege> inserted_privileges, IEnumerable<N4_RolePrivilege> deleted_privileges)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {
                foreach (N4_RolePrivilege deleteItem in deleted_privileges) {
                    DbSession.N4_RolePrivilegeRepository.Update(new N4_RolePrivilege { Is_deleted = true }, new N4_RolePrivilege { Role_uniqueid = deleteItem.Role_uniqueid, Privilege_code = deleteItem.Privilege_code });
                }
                foreach (N4_RolePrivilege insertItem in inserted_privileges)
                {
                    DbSession.N4_RolePrivilegeRepository.Add(insertItem);
                }
                DbSession.SaveChange();

                ptcp.StatusFlag = PtcpState.Success;
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", "00000000", "", "", ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion

        #region 根据role_uniqueid查询对应角色的权限项列表API
        /// <summary>
        /// 根据role_uniqueid查询对应角色的权限项列表
        /// </summary>
        /// <param name="role_uniqueid"></param>
        /// <returns></returns>
        public Ptcp<IEnumerable<N4_RolePrivilege>> QueryPrivilegeByRole(String role_uniqueid) {
            Ptcp<IEnumerable<N4_RolePrivilege>> ptcp = new Ptcp<IEnumerable<N4_RolePrivilege>>();
            try
            {
                ptcp.ReturnValue = DbSession.N4_RolePrivilegeRepository.QueryBy(new N4_RolePrivilege { Role_uniqueid = role_uniqueid ,Is_deleted = false});
                ptcp.StatusFlag = PtcpState.Success;
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", "00000000", "", "", ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion
    }
}
