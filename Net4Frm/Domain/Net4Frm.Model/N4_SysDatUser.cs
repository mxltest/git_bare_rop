//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Net4Frm.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class N4_SysDatUser:ModelBase
    {
        public Nullable<int> Id { get; set; }
        public string Uniqueid { get; set; }
        public string Login_name { get; set; }
        public string User_name { get; set; }
        public string Department_unique_id { get; set; }
        public string Prd_department_name { get; set; }
        public string Pwd { get; set; }
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
}
