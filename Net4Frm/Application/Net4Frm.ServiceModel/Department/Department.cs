using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.Department
{
    public class Department
    {
        public Nullable<int> Id { get; set; }
        public string Organization_uniqueid { get; set; }
        public string Organization_code { get; set; }
        public string Name { get; set; }
        public string Brief_name { get; set; }
        public string Description { get; set; }
        public string Mnemonic_code { get; set; }
        public string Manager_uniqueid { get; set; }
        public string Prd_manager_name { get; set; }
        public string Parent_organization_uniqueid { get; set; }
        public string Parent_organization_name { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Data_status { get; set; }
        public Nullable<bool> Abandon_status { get; set; }
        public string Creator_uniqueid { get; set; }
        public string Prd_creator_name { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public string Updator { get; set; }
        public Nullable<System.DateTime> Update_time { get; set; }
        public string Submitter { get; set; }
        public Nullable<System.DateTime> Submit_time { get; set; }
        public string Approver { get; set; }
        public Nullable<System.DateTime> Approve_time { get; set; }
        public string Abandoner { get; set; }
        public Nullable<System.DateTime> Abandon_time { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }

    public class CreateDepartmentRes : BaseResponse { }
    public class CreateDepartmentReq : Department{ }

    public class UpdateDepartmentRes : BaseResponse { }
    public class UpdateDepartmentReq : Department { }

    public class DeleteDepartmentRes : BaseResponse { }
    public class DeleteDepartmentReq {
        public string Organization_uniqueid { get; set; }
    }
    public class QueryAllDepartmentsRes : BaseResponse {
        public IEnumerable<Department> departments { get; set; }
    }
    public class QueryAllDepartmentsReq { }
    public class QueryaDepartmentInfoByUniqueIDRes : BaseResponse {
        public Department department_info { get; set; }
    }
    public class QueryaDepartmentInfoByUniqueIDReq {
        public string Organization_uniqueid { get; set; }
    }
}
