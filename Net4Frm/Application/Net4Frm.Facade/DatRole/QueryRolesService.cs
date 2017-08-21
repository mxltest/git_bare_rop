using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatRole
{
    public class QueryRolesService : BaseService<IOperationSysDatRole>
    {
        public QueryRolesRes Any(QueryRolesReq req)
        {
            QueryRolesRes res = new QueryRolesRes();
            try
            {
                var data = Mapper.Map<RoleInfo, N4_SysDatRole>(req.query_entity);
                var pager = Mapper.Map<QueryRolesReq, PageQueryInput>(req);
                var ptcp = ServiceImpl.QueryRoles(pager, data);
                //res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                //res.DoResult = ptcp.Message;
                res.result_data = Mapper.MapGeneric<N4_SysDatRole, RoleInfo>(ptcp);
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
