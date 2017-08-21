using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Model.Extension
{
    public class UserPrivilegeRes
    {
        public N4_SysDatUser userinfo { get; set; }
        public IEnumerable<N4_SysDatRole> roles { get; set; }
        public IEnumerable<N4_RolePrivilege> function_privilege { get; set; }


    }
}
