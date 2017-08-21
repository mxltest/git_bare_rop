using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Department
{
    public class QueryUsersByRoleService : BaseService<IOperationUserRoleAndDepart>
    {

        /// <summary>
        /// 查询指定角色的用户列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public QueryUsersByRoleRes Any(QueryUsersByRoleReq req)
        {
            QueryUsersByRoleRes res = new QueryUsersByRoleRes();
            try
            {
                var pager = Mapper.Map<QueryUsersByRoleReq, PageQueryInput>(req);
                var ptcp = ServiceImpl.QueryUsersByRole(pager , req.query_entity.Role_uniqueid);
                res.result_data = Mapper.MapGeneric<N4_SysDatUser, UserInfo>(ptcp.ReturnValue);
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;
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
