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
    /// 删除部门
    /// </summary>
    public class DeleteDepartmentService : BaseService<IOperationDepartment>
    {
        public DeleteDepartmentRes Any(DeleteDepartmentReq req)
        {

            DeleteDepartmentRes res = new DeleteDepartmentRes();
            try
            {
                var ptcp = ServiceImpl.DeleteDepartment(req.Organization_uniqueid);
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;

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
