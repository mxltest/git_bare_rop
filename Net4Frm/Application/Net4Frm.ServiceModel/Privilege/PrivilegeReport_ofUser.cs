using System;
using System.Collections.Generic;
using Net4Frm.ServiceModel.User;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.Privilege
{

    public class RoleInfo_PrivilegeReport_ofUser
    {
        public Nullable<int> Id { get; set; }
        public string Unique_id { get; set; }
        public string FCode { get; set; }
        public string FName { get; set; }
        public string Dir { get; set; }
        public string Role_desc { get; set; }
        public string Creator_uniqueid { get; set; }
        public string Creator_name { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public string Updator_uniqueid { get; set; }
        public string Updator_name { get; set; }
        public Nullable<System.DateTime> Update_time { get; set; }
        public string Submitter_uniqueid { get; set; }
        public string Submitter_name { get; set; }
        public Nullable<System.DateTime> Submit_time { get; set; }
        public string Approver_uniqueid { get; set; }
        public string Approver_name { get; set; }
        public Nullable<System.DateTime> Approver_time { get; set; }
        public string Abandoner_uniqueid { get; set; }
        public string Abandoner_name { get; set; }
        public Nullable<System.DateTime> Abandon_time { get; set; }
        public string Data_status { get; set; }
        public Nullable<bool> Abandon_status { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
    public class RolePrivilegeInfo
    {
        public Nullable<int> Id { get; set; }
        public string Role_uniqueid { get; set; }
        public string Privilege_code { get; set; }
        public string Prd_privilege_text { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
    public class queryPrivilegeReportForUserReq
    {
        public string user_uniqueid { get; set; }
    }
    public class queryPrivilegeReportForUserReqRes : BaseResponse
    {
        public UserInfo userinfo { get; set; }
        public IEnumerable<RolePrivilegeInfo> function_privilege { get; set; }
        public IEnumerable<RoleInfo_PrivilegeReport_ofUser> roles { get; set; }
        
    }


}
