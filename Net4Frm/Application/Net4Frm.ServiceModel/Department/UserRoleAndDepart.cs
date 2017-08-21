using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.Department
{
    public class UserRoleAndDepart
    {
        public Nullable<int> Id { get; set; }
        public string User_uniqueid { get; set; }
        public string Role_uniqueid { get; set; }
        public string Depart_uniqueid { get; set; }
        public Nullable<System.DateTime> InvalidTime { get; set; }
        public string Factory { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
    public class UserInfo
    {
        public Nullable<int> Id { get; set; }
        public string Uniqueid { get; set; }
        public string Login_name { get; set; }
        public string User_name { get; set; }
        public string Department_unique_id { get; set; }
        public string Prd_department_name { get; set; }
        public string ScanCode { get; set; }
        public Nullable<bool> IsAllowLogin { get; set; }
        public Nullable<System.DateTime> InValidTime { get; set; }
        public Nullable<bool> IsEmployee { get; set; }
        public string DataStatus { get; set; }
        public Nullable<bool> AbandonStatus { get; set; }
        public string Creator_uniqueid { get; set; }
        public string Prd_creator_name { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public string Last_updater_unique_id { get; set; }
        public string Last_updater_name { get; set; }
        public Nullable<System.DateTime> Last_update_time { get; set; }
        public string Approver_unique_id { get; set; }
        public string Approver_name { get; set; }
        public Nullable<System.DateTime> Approve_time { get; set; }
        public string Abandoner_unique_id { get; set; }
        public string Abandoner_name { get; set; }
        public Nullable<System.DateTime> Abandon_time { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
    public class QueryUsersByRoleRes : BaseSearchResponse{
        public IEnumerable<UserInfo> result_data { get; set; }
    }
    
    public class QueryUsersByRoleReq : BaseSearchRequest
    {
        public QueryUsersByRoleReq_entity query_entity { get; set; }
        
    }

    public class QueryUsersByRoleReq_entity {
        public string Role_uniqueid { get; set; }
    }

    public class UpdateUsersToRoleRes : BaseResponse { }
    public class UpdateUsersToRoleReq {
        public IEnumerable<UserRoleAndDepart> inserted_users { get; set; }
        public IEnumerable<UserPrivilege> inserted_userprivilege { get; set; }
        public IEnumerable<UserRoleAndDepart> deleted_users { get; set; }
    }
}
