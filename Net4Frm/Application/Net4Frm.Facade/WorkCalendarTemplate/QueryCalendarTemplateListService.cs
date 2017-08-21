using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using Net4Frm.ServiceModel.WorkCalendarTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.WorkCalendarTemplate
{
    public class QueryCalendarTemplateListService : BaseService<IOperationWorkCalTemplate>
    {
        public QueryCalendarTemplateRes Any(QueryCalendarTemplateReq req)
        {
            QueryCalendarTemplateRes res = new QueryCalendarTemplateRes();
            try
            {
                var data_pager_info = Mapper.Map<QueryCalendarTemplateReq, PageQueryInput>(req);
                var data_query_entity = Mapper.Map<WorkCalTemplateInfo, WorkCalTemplate>(req.query_entity);
                var ptcp = ServiceImpl.QueryWorkCalTemplate(data_pager_info, data_query_entity);

                res.DoFlag = true;
                res.result_data = Mapper.MapGeneric<WorkCalTemplate, WorkCalTemplateInfo>(ptcp);
                res.total_row_count = 0;
                res.current_page_index = req.current_page_index;
                res.pagesize = req.pagesize;
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
