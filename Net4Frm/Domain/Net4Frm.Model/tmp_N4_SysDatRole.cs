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
    
    public partial class tmp_N4_SysDatRole:ModelBase
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
}
