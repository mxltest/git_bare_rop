using Net4Frm.Log4Net;
using Net4Frm.Model;
using Net4Frm.Model.Base;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationDepartmentImpl : BaseService, IOperationDepartment
    {
        #region 新增部门API
        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> CreateDepartment(N4_Department department)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {

                bool CheckDepName = DbSession.N4_DepartmentRepository.QueryBy(new N4_Department { Organization_code = department.Organization_code, Is_deleted = false }).Count() == 0;
                if (CheckDepName)
                {
                    DbSession.N4_DepartmentRepository.Add(department);
                    DbSession.SaveChange();
                }
                else
                {
                    ptcp.StatusFlag = PtcpState.Failed;
                    ptcp.Message = "该部门编码已存在,请重新输入！";

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


        #region 更新部门信息API
        /// <summary>
        /// 更新部门信息
        /// </summary>
        /// <param name="datUser"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdateDepartment(N4_Department department)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            //日志
            LogMessage mes = new LogMessage();
            List<N4_Department> list = new List<N4_Department>();
            try
            {
                bool CheckDepName = DbSession.N4_DepartmentRepository.QueryBy(new N4_Department { Organization_code = department.Organization_code, Is_deleted = false }).Count() == 1;
                if (CheckDepName)
                {
                    list = DbSession.N4_DepartmentRepository.QueryBy(new N4_Department { Organization_uniqueid = department.Organization_uniqueid, Is_deleted = false }).ToList();
                    if (list.Count > 0)
                    {
                        mes.EntityID = list[0].Id.ToString();
                        mes.StringForOldEntity = "OldEntity_N4_Department";
                    }
                    DbSession.N4_DepartmentRepository.Update(department, new N4_Department { Organization_uniqueid = department.Organization_uniqueid });
                    DbSession.SaveChange();
                    mes.StringForNewEntity = "NewEntity_N4_Department";
                    ptcp.StatusFlag = PtcpState.Success;
                }
                else
                {
                    ptcp.StatusFlag = PtcpState.Failed;
                    ptcp.Message = "该部门已存在,请重新输入！";
                }
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", mes.EntityID, mes.StringForOldEntity, mes.StringForNewEntity, ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion

        #region 删除部门信息API
        /// <summary>
        ///根据organization_uniqueid删除部门信息
        /// </summary>
        /// <param name="organization_uniqueid"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> DeleteDepartment(String organization_uniqueid)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            try
            {
                DbSession.N4_DepartmentRepository.Update(new N4_Department { Is_deleted = true }, new N4_Department { Organization_uniqueid = organization_uniqueid });
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

        #region 查询全部部门信息API
        /// <summary>
        /// 查询全部部门信息
        /// </summary>
        /// <returns></returns>
        public Ptcp<IEnumerable<N4_Department>> QueryAllDepartments()
        {
            Ptcp<IEnumerable<N4_Department>> ptcp = new Ptcp<IEnumerable<N4_Department>>();
            try
            {
                ptcp.ReturnValue = DbSession.N4_DepartmentRepository.QueryBy(new N4_Department { Is_deleted = false });
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

        #region 根据organization_uniqueid查询部门信息 API
        /// <summary>
        /// 根据organization_uniqueid查询部门信息
        /// </summary>
        /// <param name="organization_uniqueid">部门全局id</param>
        /// <returns></returns>
        public Ptcp<N4_Department> QueryaDepartmentInfoByUniqueID(String organization_uniqueid)
        {
            Ptcp<N4_Department> ptcp = new Ptcp<N4_Department>();
            try
            {
                var results = DbSession.N4_DepartmentRepository.QueryBy(new N4_Department { Organization_uniqueid = organization_uniqueid, Is_deleted = false });
                if (results.Count() == 1)
                {
                    ptcp.ReturnValue = results.FirstOrDefault<N4_Department>();
                }
                else
                {
                    ptcp.StatusFlag = PtcpState.Failed;
                }

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
