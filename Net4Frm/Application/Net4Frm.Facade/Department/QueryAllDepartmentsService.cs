using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Department
{
    /// <summary>
    /// 查询全部部门树
    /// </summary>
    public class QueryAllDepartmentsService : BaseService<IOperationDepartment>
    {
        public QueryAllDepartmentsRes Any(QueryAllDepartmentsReq req)
        {

            QueryAllDepartmentsRes res = new QueryAllDepartmentsRes();
            try
            {
                var ptcp = ServiceImpl.QueryAllDepartments();
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;
                res.departments = Mapper.MapGeneric<N4_Department, ServiceModel.Department.Department>(ptcp.ReturnValue);
            }
            catch(Exception ex)
            {
                res.DoResult = ex.Message;
                res.DoFlag = false;
            }
            return res;
        }
    }
}
