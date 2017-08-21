using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatUser
{
    public class QueryLogOfUserLoginService : BaseService<IOperationSysDatUser>
    {
        public QueryLogOfUserLoginRes Any(QueryLogOfUserLoginReq req)
        {
            int pageIndex = req.Current_Page_Index ?? 1;
            int pageSize = req.PageSize ?? 20;
            
            try
            {
                N4_logToUserLoginout data = Mapper.Map<logToUserLoginout, N4_logToUserLoginout>(req.query_entity);
                long total=0;
                var resule = ServiceImpl.SearchUserLoginOut(data, pageSize , pageIndex, out total);
                
                return new QueryLogOfUserLoginRes
                {
                    DoFlag = true,
                    result_data = Mapper.MapGeneric<N4_logToUserLoginout, logToUserLoginout>(resule).ToList(),
                    total_row_count = total,
                    current_page_index=pageIndex,
                    pagesize=pageSize
                };
            }
            catch(Exception ex)
            {
                return new QueryLogOfUserLoginRes
                {
                    DoFlag = false,
                    DoResult=ex.Message
                };
            }
        
        }
    }
}
