using Net4Frm.Log4Net;
using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationDataPrivilegeImpl : BaseService, IOperationDataPrivilege
    {
        #region 查询某角色的数据库权限列表API
        /// <summary>
        /// 查询某角色的数据库权限列表
        /// </summary>
        /// <param name="pageInput"></param>
        /// <param name="role_uniqueid"></param>
        /// <returns></returns>
        public Ptcp<IEnumerable<N4_DataPrivilege_ofRole>> QueryDataPrivelegeOfRole(PageQueryInput pageInput, String role_uniqueid)
        {
            Ptcp<IEnumerable<N4_DataPrivilege_ofRole>> ptcp = new Ptcp<IEnumerable<N4_DataPrivilege_ofRole>>();
            try
            {
                var results = DbSession.N4_DataPrivilege_ofRoleRepository.QueryPageBy(pageInput.current_page_index.Value, pageInput.pagesize.Value, new N4_DataPrivilege_ofRole { Role_uniqueid = role_uniqueid });
                ptcp.ReturnValue = results;

                ptcp.StatusFlag = PtcpState.Success;
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;

                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", "00000000", role_uniqueid, "", ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion

        #region 查询某人员的数据库权限列表API
        /// <summary>
        /// 查询某人员的数据库权限列表
        /// </summary>
        /// <param name="pageInput"></param>
        /// <param name="user_uniqueid"></param>
        /// <returns></returns>
        public Ptcp<IEnumerable<N4_DataPrivilege_ofUser>> QueryDataPrivelegeOfUser(PageQueryInput pageInput, String user_uniqueid)
        {
            Ptcp<IEnumerable<N4_DataPrivilege_ofUser>> ptcp = new Ptcp<IEnumerable<N4_DataPrivilege_ofUser>>();
            try
            {
                var results = DbSession.N4_DataPrivilege_ofUserRepository.QueryPageBy(pageInput.current_page_index.Value, pageInput.pagesize.Value, new N4_DataPrivilege_ofUser { User_uniqueid = user_uniqueid });
                ptcp.ReturnValue = results;
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

        #region 更新某角色的数据库权限列表API
        /// <summary>
        /// 更新某角色的数据库权限列表
        /// </summary>
        /// <param name="inserted"></param>
        /// <param name="deleted"></param>
        /// <param name="updated"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdateDataPrivelegeOfRoleOfAview(IEnumerable<N4_DataPrivilege_ofRole> inserted, IEnumerable<N4_DataPrivilege_ofRole> deleted, IEnumerable<N4_DataPrivilege_ofRole> updated)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {
                foreach (N4_DataPrivilege_ofRole deleteItem in deleted)
                {
                    DbSession.N4_DataPrivilege_ofRoleRepository.Update(new N4_DataPrivilege_ofRole { Is_deleted = true }, new N4_DataPrivilege_ofRole { Id = deleteItem.Id });
                }
                foreach (N4_DataPrivilege_ofRole insertItem in inserted)
                {
                    DbSession.N4_DataPrivilege_ofRoleRepository.Add(insertItem);
                }
                foreach (N4_DataPrivilege_ofRole updateItem in updated)
                {
                    DbSession.N4_DataPrivilege_ofRoleRepository.Update(new N4_DataPrivilege_ofRole { Authorize_columns = updateItem.Authorize_columns, Authorize_desc = updateItem.Authorize_desc }, new N4_DataPrivilege_ofRole { Id = updateItem.Id });
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

        #region 更新某人员的数据库权限列表API
        /// <summary>
        /// 更新某人员的数据库权限列表
        /// </summary>
        /// <param name="inserted"></param>
        /// <param name="deleted"></param>
        /// <param name="updated"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdateDataPrivelegeOfUserOfAview(IEnumerable<N4_DataPrivilege_ofUser> inserted, IEnumerable<N4_DataPrivilege_ofUser> deleted, IEnumerable<N4_DataPrivilege_ofUser> updated)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {
                foreach (N4_DataPrivilege_ofUser deleteItem in deleted)
                {
                    DbSession.N4_DataPrivilege_ofUserRepository.Update(new N4_DataPrivilege_ofUser { Is_deleted = true }, new N4_DataPrivilege_ofUser { Id = deleteItem.Id });
                }
                foreach (N4_DataPrivilege_ofUser insertItem in inserted)
                {
                    DbSession.N4_DataPrivilege_ofUserRepository.Add(insertItem);
                }
                foreach (N4_DataPrivilege_ofUser updateItem in updated)
                {
                    DbSession.N4_DataPrivilege_ofUserRepository.Update(new N4_DataPrivilege_ofUser { Authorize_columns = updateItem.Authorize_columns, Authorize_desc = updateItem.Authorize_desc }, new N4_DataPrivilege_ofUser { Id = updateItem.Id });
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
