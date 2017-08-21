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
    /// 新增部门
    /// </summary>
    public class CreateDepartmentService : BaseService<IOperationDepartment>
    {
        public CreateDepartmentRes Any(CreateDepartmentReq req)
        {

            CreateDepartmentRes res = new CreateDepartmentRes();
            try
            {
                var data = Mapper.Map<CreateDepartmentReq, N4_Department>(req);
                var ptcp = ServiceImpl.CreateDepartment(data);
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
