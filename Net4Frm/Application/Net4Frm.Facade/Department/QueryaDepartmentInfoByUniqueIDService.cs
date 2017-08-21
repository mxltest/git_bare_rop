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
    /// 根据部门全局ID查询部门信息
    /// </summary>
    public class QueryaDepartmentInfoByUniqueIDService : BaseService<IOperationDepartment>
    {
        public QueryaDepartmentInfoByUniqueIDRes Any(QueryaDepartmentInfoByUniqueIDReq req)
        {

            QueryaDepartmentInfoByUniqueIDRes res = new QueryaDepartmentInfoByUniqueIDRes();
            try
            {
                var ptcp = ServiceImpl.QueryaDepartmentInfoByUniqueID(req.Organization_uniqueid);
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;
                res.department_info = Mapper.Map<N4_Department, ServiceModel.Department.Department>(ptcp.ReturnValue);
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
