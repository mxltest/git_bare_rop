using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatUser
{
    public class QueryLogOfUserOperationService : BaseService<IOperationSysDatUser>
    {
        #region 获取用户操作日志
        /// <summary>
        /// 获取用户操作日志
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public QueryLogOfUserOperationRes Any(QueryLogOfUserOperationReq req)
        {
            int pageIndex = req.Current_Page_Index ?? 1;
            int pageSize = req.PageSize ?? 20;

            try
            {
                N4_logToUserOperation data = Mapper.Map<logToUserOperation, N4_logToUserOperation>(req.query_entity);
                long total = 0;
                var resule = ServiceImpl.SearchUserOperation(data,pageIndex, pageSize, out total);
                return new QueryLogOfUserOperationRes
                {
                    DoFlag = true,
                    result_data = Mapper.MapGeneric<N4_logToUserOperation, logToUserOperation>(resule).ToList(),
                    total_row_count = total,
                    current_page_index = pageIndex,
                    pagesize = pageSize
                };
            }
            catch (Exception ex)
            {
                return new QueryLogOfUserOperationRes
                {
                    DoFlag = false,
                    DoResult = ex.Message
                };
            }

        }
        #endregion


    }
}
