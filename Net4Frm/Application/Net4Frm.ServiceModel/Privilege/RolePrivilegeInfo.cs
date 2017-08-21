using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.Privilege
{

    public class UpdatePrivilegeForRoleRes : BaseResponse
    {
 
    }

    public class UpdatePrivilegeForRoleReq : RolePrivilegeInfo {
        public IEnumerable<RolePrivilegeInfo> inserted_privileges { get; set; }
        public IEnumerable<RolePrivilegeInfo> deleted_privileges { get; set; }
    }

    public class QueryPrivilegeByRoleReq {
        public string Role_uniqueid { get; set; }
    }
    public class QueryPrivilegeByRoleRes : BaseResponse
    {
        public IEnumerable<RolePrivilegeInfo> privileges_of_role { get; set; }
    }
}
