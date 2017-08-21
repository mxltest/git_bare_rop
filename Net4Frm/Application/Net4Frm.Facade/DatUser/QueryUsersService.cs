using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatUser
{
    public class QueryUsersService : BaseService<IOperationSysDatUser>
    {
        public QueryUsersRes Any(QueryUsersReq req)
        {
            QueryUsersRes res = new QueryUsersRes();
            try
            {
                var data_pager_info = Mapper.Map<QueryUsersReq, PageQueryInput>(req);
                var data_query_entity = Mapper.Map<UserInfo, N4_SysDatUser>(req.query_entity);
                var ptcp = ServiceImpl.QueryUsers(data_pager_info, data_query_entity);

                res.DoFlag = true;
                res.result_data = Mapper.MapGeneric<N4_SysDatUser, UserInfo>(ptcp);
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
