//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Net4Frm.Template4
{
    using System;
    using System.Collections.Generic;
    
    public partial class N4_SysDatUser
    {
        public int id { get; set; }
        public string uniqueid { get; set; }
        public string login_name { get; set; }
        public string user_name { get; set; }
        public string department_unique_id { get; set; }
        public string prd_department_name { get; set; }
        public string pwd { get; set; }
        public string ScanCode { get; set; }
        public Nullable<bool> IsAllowLogin { get; set; }
        public Nullable<System.DateTime> InValidTime { get; set; }
        public Nullable<bool> IsEmployee { get; set; }
        public string DataStatus { get; set; }
        public Nullable<bool> AbandonStatus { get; set; }
        public string Creator_uniqueid { get; set; }
        public string prd_creator_name { get; set; }
        public System.DateTime create_time { get; set; }
        public string last_updater_unique_id { get; set; }
        public string last_updater_name { get; set; }
        public Nullable<System.DateTime> last_update_time { get; set; }
        public string approver_unique_id { get; set; }
        public string approver_name { get; set; }
        public Nullable<System.DateTime> approve_time { get; set; }
        public string abandoner_unique_id { get; set; }
        public string abandoner_name { get; set; }
        public Nullable<System.DateTime> abandon_time { get; set; }
        public bool is_deleted { get; set; }
        public byte[] last_timestamp { get; set; }
    }
}
