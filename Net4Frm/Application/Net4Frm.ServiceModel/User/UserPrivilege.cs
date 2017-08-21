using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.User
{
    public class UserPrivilege
    {
        public Nullable<int> Id { get; set; }
        public string User_uniqueid { get; set; }
        public string Privilege_text { get; set; }
        public string Privilege_code { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
}
