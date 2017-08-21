using Net4Frm.Log4Net;
using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationSysDatRoleImpl : BaseService, IOperationSysDatRole
    {
        #region 添加角色信息API
        /// <summary>
        /// 添加角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> InsertSysDatRoleInfo(N4_SysDatRole role)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {
                bool checkFName = DbSession.N4_SysDatRoleRepository.QueryBy(new N4_SysDatRole { FCode = role.FCode, Is_deleted = false }).Count() == 0;
                if (checkFName)
                {
                    DbSession.N4_SysDatRoleRepository.Add(role);
                    DbSession.SaveChange();
                    ptcp.StatusFlag = PtcpState.Success;
                }
                else
                {
                    ptcp.StatusFlag = PtcpState.Failed;
                    ptcp.Message = "该角色已存在,请重新输入！";
                }
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

        #region 添加多个角色信息API
        /// <summary>
        /// 添加多个角色
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> InsertSysDatRoleInfos(IEnumerable<N4_SysDatRole> roles)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {
                foreach (var role in roles)
                {
                    bool checkFName = DbSession.N4_SysDatRoleRepository.QueryBy(new N4_SysDatRole { FCode = role.FCode, Is_deleted = false }).Count() == 0;
                    if (checkFName)
                    {
                        DbSession.N4_SysDatRoleRepository.Add(role);
                        DbSession.SaveChange();
                        ptcp.StatusFlag = PtcpState.Success;
                    }
                    else
                    {
                        ptcp.StatusFlag = PtcpState.Failed;
                        ptcp.Message = "该角色编号已存在,请重新输入！";
                    }
                }
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

        #region 修改角色信息API
        /// <summary>
        /// 修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdateSysDatRoleInfo(N4_SysDatRole role)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {
                  bool checkFName = DbSession.N4_SysDatRoleRepository.QueryBy(new N4_SysDatRole { FCode = role.FCode, Is_deleted = false }).Count() == 1;
                  if (checkFName)
                  {
                      DbSession.N4_SysDatRoleRepository.Update(role, new N4_SysDatRole { Unique_id = role.Unique_id });
                      DbSession.SaveChange();
                      ptcp.StatusFlag = PtcpState.Success;
                  }
                  else
                  {
                      ptcp.StatusFlag = PtcpState.Failed;
                      ptcp.Message = "该角色编号已存在,请重新输入！";
                  }
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

        #region 查询角色信息API
        /// <summary>
        /// 查询角色信息
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public IEnumerable<N4_SysDatRole> QueryRoles(PageQueryInput pager, N4_SysDatRole role)
        {
            return DbSession.N4_SysDatRoleRepository.QueryPageBy(pager.current_page_index.Value, pager.pagesize.Value, new N4_SysDatRole { Is_deleted = false });
        }
        #endregion
    }
}
