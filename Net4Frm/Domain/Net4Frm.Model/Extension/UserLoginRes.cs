using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Model.Extension
{
    public class UserLoginRes
    {
        public N4_SysDatUser userinfo { get; set; }
        public IEnumerable<N4_UserPrivilege> privilege { get; set; }
        public String token { get; set; }
    }
}
