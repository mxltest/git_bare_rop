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
    
    public partial class tmp_N4_Log:ModelBase
    {
        public Nullable<int> Id { get; set; }
        public Nullable<System.DateTime> Log_date { get; set; }
        public string Log_tag { get; set; }
        public Nullable<int> Thread { get; set; }
        public string Log_level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string Entity_scheme_name { get; set; }
        public string Entity_id { get; set; }
        public string String_for_old_entity { get; set; }
        public string String_for_new_entity { get; set; }
        public string Description { get; set; }
        public string Fan_class_name { get; set; }
        public string Fan_function_in_code { get; set; }
        public string Device_info { get; set; }
        public string Userid { get; set; }
        public string Ip_addr { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
}
