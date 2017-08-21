using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Privilege;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Privilege
{
    /// <summary>
    /// 查询某角色的数据权限列表
    /// </summary>
    public class QueryDataPrivelegeOfRoleService : BaseService<IOperationDataPrivilege>
    {
        public QueryDataPrivelegeOfRoleRes Any(QueryDataPrivelegeOfRoleReq req)
        {
            QueryDataPrivelegeOfRoleRes res = new QueryDataPrivelegeOfRoleRes();
            try
            {
                var input = Mapper.Map<QueryDataPrivelegeOfRoleReq, Net4Frm.Model.PageQueryInput>(req);
                var ptcp = ServiceImpl.QueryDataPrivelegeOfRole(input, req.query_entity.Role_uniqueid);
                res.result_data = Mapper.MapGeneric<N4_DataPrivilege_ofRole, DataPrivilege_ofRole>(ptcp.ReturnValue);
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;
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
