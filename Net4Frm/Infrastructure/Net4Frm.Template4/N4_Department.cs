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
    
    public partial class N4_Department
    {
        public int id { get; set; }
        public string organization_uniqueid { get; set; }
        public string organization_code { get; set; }
        public string name { get; set; }
        public string brief_name { get; set; }
        public string description { get; set; }
        public string mnemonic_code { get; set; }
        public string manager_uniqueid { get; set; }
        public string prd_manager_name { get; set; }
        public string parent_organization_uniqueid { get; set; }
        public string parent_organization_name { get; set; }
        public string remark { get; set; }
        public Nullable<int> data_status { get; set; }
        public Nullable<bool> abandon_status { get; set; }
        public string creator_uniqueid { get; set; }
        public string prd_creator_name { get; set; }
        public System.DateTime create_time { get; set; }
        public string updator { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public string submitter { get; set; }
        public Nullable<System.DateTime> submit_time { get; set; }
        public string approver { get; set; }
        public Nullable<System.DateTime> approve_time { get; set; }
        public string abandoner { get; set; }
        public Nullable<System.DateTime> abandon_time { get; set; }
        public bool is_deleted { get; set; }
        public byte[] last_timestamp { get; set; }
    }
}
