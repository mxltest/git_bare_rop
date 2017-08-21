using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.Department
{
    public class UpdateDepartmentService : BaseService<IOperationDepartment>
    {
        public UpdateDepartmentRes Any(UpdateDepartmentReq req)
       {
           UpdateDepartmentRes res = new UpdateDepartmentRes();
           try
           {
               var data = Mapper.Map<UpdateDepartmentReq, N4_Department>(req);
               var ptcp = ServiceImpl.UpdateDepartment(data);
               res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
               res.DoResult = ptcp.Message;

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
