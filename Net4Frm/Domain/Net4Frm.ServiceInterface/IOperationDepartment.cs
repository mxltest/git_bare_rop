using Net4Frm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationDepartment
    {

        Ptcp<ModelBase> CreateDepartment(N4_Department department);
        Ptcp<ModelBase> UpdateDepartment(N4_Department department);
        Ptcp<ModelBase> DeleteDepartment(String organization_uniqueid);
        Ptcp<IEnumerable<N4_Department>> QueryAllDepartments();
        Ptcp<N4_Department> QueryaDepartmentInfoByUniqueID(String organization_uniqueid);
        
    }
}
