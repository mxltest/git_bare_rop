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
    
    public partial class N4_RolePrivilege:ModelBase
    {
        public Nullable<int> Id { get; set; }
        public string Role_uniqueid { get; set; }
        public string Privilege_code { get; set; }
        public string Prd_privilege_text { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
}
