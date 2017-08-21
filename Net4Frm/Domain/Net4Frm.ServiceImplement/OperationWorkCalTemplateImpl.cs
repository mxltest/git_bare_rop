using Net4Frm.Log4Net;
using Net4Frm.Model;
using Net4Frm.Model.Base;
using Net4Frm.Model.Extension;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationWorkCalTemplateImpl : BaseService, IOperationWorkCalTemplate
    {
        #region 新增工作日历模板列表API
        /// <summary>
        /// 新增工作日历模板
        /// </summary>
        /// <param name="datTemplate"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> InsertWorkCalTemplate(WorkCalTemplate datTemplate)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            LogMessage mes = new LogMessage();
            try
            {
                mes.StringForOldEntity = "OldEntity_WorkCalTempletNo";
                 bool checkUsrName = DbSession.WorkCalTemplateRepository.QueryBy(new WorkCalTemplate { WorkCalTempletNo = datTemplate.WorkCalTempletNo, Is_deleted = false }).Count() == 0;
                 if (checkUsrName)
                 {
                     DbSession.WorkCalTemplateRepository.Add(datTemplate);
                     DbSession.SaveChange();
                 }
                 else
                 {
                     ptcp.StatusFlag = PtcpState.Failed;
                     mes.StringForNewEntity = "NewEntity_WorkCalTempletNo";
                 }
                ptcp.StatusFlag = PtcpState.Success;
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", "00000000", mes.StringForOldEntity, mes.StringForNewEntity, ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion

        #region 查询工作日历模板列表API
        /// <summary>
        /// 工作日历模板列表
        /// </summary>
        /// <param name="pagerInfo"></param>
        /// <param name="query_entity"></param>
        /// <returns></returns>
        public IEnumerable<WorkCalTemplate> QueryWorkCalTemplate(PageQueryInput pagerInfo, WorkCalTemplate query_entity)
        {
            query_entity.Is_deleted = false;
            return DbSession.WorkCalTemplateRepository.QueryPageBy(pagerInfo.current_page_index.Value, pagerInfo.pagesize.Value, query_entity);
        }
        #endregion


        #region 更新工作日历模板信息API
        /// <summary>
        /// 更新工作日历模板信息
        /// </summary>
        /// <param name="datUser"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdateWorkCalTemplate(WorkCalTemplate datTemplate)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            //日志
            LogMessage mes = new LogMessage();
            List<WorkCalTemplate> list = new List<WorkCalTemplate>();
            try
            {
                bool checkUsrName = DbSession.WorkCalTemplateRepository.QueryBy(new WorkCalTemplate { WorkCalTempletNo = datTemplate.WorkCalTempletNo, Is_deleted = false }).Count() == 1;
                if (checkUsrName)
                {
                    list = DbSession.WorkCalTemplateRepository.QueryBy(new WorkCalTemplate { WorkCalTempletNo = datTemplate.WorkCalTempletNo, Is_deleted = false }).ToList();
                    if (list.Count > 0)
                    {
                        mes.EntityID = list[0].Id.ToString();
                        mes.StringForOldEntity = "OldEntity_WorkCalTemplate";
                    }
                    DbSession.WorkCalTemplateRepository.Update(datTemplate, new WorkCalTemplate { WorkCalTempletNo = datTemplate.WorkCalTempletNo });
                    DbSession.SaveChange();
                    mes.StringForNewEntity = "NewEntity_WorkCalTemplate";
                    ptcp.StatusFlag = PtcpState.Success;
                }
                else
                {
                    ptcp.StatusFlag = PtcpState.Failed;
                    ptcp.Message = "该工作日历模板已存在,请重新输入！";
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

        #region 删除用户API
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uniqueid"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> DeleteWorkCalTemplate(String WorkCalTempletNo)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            //日志
            LogMessage mes = new LogMessage();
            List<WorkCalTemplate> list = new List<WorkCalTemplate>();
            try
            {
                list = DbSession.WorkCalTemplateRepository.QueryBy(new WorkCalTemplate { WorkCalTempletNo = WorkCalTempletNo, Is_deleted = false }).ToList();
                if (list.Count > 0)
                {
                    mes.EntityID = list[0].Id.ToString();
                    mes.StringForOldEntity = "OldEntity_WorkCalTemplate";
                }
                DbSession.WorkCalTemplateRepository.Update(new WorkCalTemplate { Is_deleted = true }, new WorkCalTemplate { WorkCalTempletNo = WorkCalTempletNo });
                DbSession.SaveChange();
                ptcp.StatusFlag = PtcpState.Success;
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
    }
}
