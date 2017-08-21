using Net4Frm.Log4Net;
using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationUserRoleAndDepartImpl : BaseService, IOperationUserRoleAndDepart
    {
        #region 查询指定角色的用户列表API
        /// <summary>
        /// 查询指定角色的用户列表
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="role_uniqueid"></param>
        /// <returns></returns>
        public Ptcp<IEnumerable<N4_SysDatUser>> QueryUsersByRole(PageQueryInput pager, String role_uniqueid)
        {
            Ptcp<IEnumerable<N4_SysDatUser>> ptcp = new Ptcp<IEnumerable<N4_SysDatUser>>();
            List<N4_UserRoleAndDepart> list = new List<N4_UserRoleAndDepart>();
            List<N4_SysDatUser> userlist = new List<N4_SysDatUser>();
            try
            {
                list = DbSession.N4_UserRoleAndDepartRepository.QueryBy( new N4_UserRoleAndDepart { Role_uniqueid = role_uniqueid }).ToList();
                foreach (var item in list)
                {
                    ptcp.ReturnValue = DbSession.N4_SysDatUserRepository.QueryPageBy(pager.current_page_index.Value, pager.pagesize.Value, new N4_SysDatUser { Uniqueid = item.User_uniqueid, Is_deleted = false }).ToList();
                    foreach (var user_item in ptcp.ReturnValue)
                    {
                        userlist.Add(user_item);
                    }
                }
                ptcp.ReturnValue = userlist;
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

        #region 更新属于指定角色的用户列表API
        /// <summary>
        /// 更新属于指定角色的用户列表
        /// </summary>
        /// <param name="inserted_users"></param>
        /// <param name="deleted_users"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdateUsersToRole(IEnumerable<N4_UserRoleAndDepart> inserted_users, IEnumerable<N4_UserRoleAndDepart> deleted_users)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            List<N4_UserRoleAndDepart> ilist = new List<N4_UserRoleAndDepart>();
            List<N4_RolePrivilege> listRoPr = new List<N4_RolePrivilege>();
            try
            {
                foreach (N4_UserRoleAndDepart deleteItem in deleted_users)
                {
                    DbSession.N4_UserRoleAndDepartRepository.Update(new N4_UserRoleAndDepart { Is_deleted = true }, new N4_UserRoleAndDepart { Role_uniqueid = deleteItem.Role_uniqueid, User_uniqueid = deleteItem.User_uniqueid });
                }
                foreach (N4_UserRoleAndDepart insertItem in inserted_users)
                {
                    DbSession.N4_UserRoleAndDepartRepository.Add(insertItem);
                }
                var UserPrivileg = inserted_users.FirstOrDefault();

                //1.根据用户,获得相关角色信息
                ilist = DbSession.N4_UserRoleAndDepartRepository.QueryBy(new N4_UserRoleAndDepart { User_uniqueid = UserPrivileg.User_uniqueid, Is_deleted = false }).ToList();

                //2.1 根据角色获取权限列表
                foreach (var item in ilist)
                {
                    List<N4_RolePrivilege> listRoP = new List<N4_RolePrivilege>();
                    listRoP = DbSession.N4_RolePrivilegeRepository.QueryBy(new N4_RolePrivilege { Role_uniqueid = item.Role_uniqueid, Is_deleted = false }).ToList();
                    foreach (var itemP in listRoP)
                    {
                        listRoPr.Add(itemP);
                    }
                }
                //2.2 更新用户的权限    
                if (listRoPr.Count > 0)
                {
                    foreach (var item in listRoPr)
                    {
                        //2.2.1 判断用户是否存在对应权限
                        bool hasUser = DbSession.N4_UserPrivilegeRepository.QueryBy(new N4_UserPrivilege { Privilege_code = item.Privilege_code, User_uniqueid = UserPrivileg.User_uniqueid, Is_deleted = false }).Count() > 0;

                        //存在相应权限,更新用户权限
                        if (hasUser == true)
                        {
                            DbSession.N4_UserPrivilegeRepository.Update(new N4_UserPrivilege { Is_deleted = true }, new N4_UserPrivilege { User_uniqueid = UserPrivileg.User_uniqueid, Privilege_code = item.Privilege_code, Prd_privilege_text = item.Prd_privilege_text });
                        }
                        //不存在相应权限,新增用户权限
                        else
                        {
                            N4_UserPrivilege inseruserpri = new N4_UserPrivilege();
                            inseruserpri.Privilege_code = item.Privilege_code;
                            inseruserpri.Prd_privilege_text = item.Prd_privilege_text;
                            inseruserpri.User_uniqueid = UserPrivileg.User_uniqueid;
                            DbSession.N4_UserPrivilegeRepository.Add(inseruserpri);
                        }
                    }
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
    }
}
