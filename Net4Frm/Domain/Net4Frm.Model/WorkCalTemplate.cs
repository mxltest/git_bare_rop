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
    
    public partial class WorkCalTemplate:ModelBase
    {
        public Nullable<int> Id { get; set; }
        public string WorkCalTempletNo { get; set; }
        public string WorkCalTempletName { get; set; }
        public string WorkCalCycleNo { get; set; }
        public Nullable<int> CycleDays { get; set; }
        public string Remark { get; set; }
        public string DataStatus { get; set; }
        public string Creator_nqid { get; set; }
        public string Creator_name { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Updator_nqid { get; set; }
        public string Updator_name { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string Submitter_nqid { get; set; }
        public string Submitter_name { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public string Approver_nqid { get; set; }
        public string Approver_name { get; set; }
        public Nullable<System.DateTime> ApproveTime { get; set; }
        public string Abandoner_nqid { get; set; }
        public string Abandoner_name { get; set; }
        public Nullable<System.DateTime> AbandonTime { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
}
