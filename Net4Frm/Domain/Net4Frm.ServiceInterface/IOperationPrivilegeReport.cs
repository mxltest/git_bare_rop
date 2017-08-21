using Net4Frm.Model;
using Net4Frm.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationPrivilegeReport
    {
        Ptcp<UserPrivilegeRes> QueryDataPrivelegeOfUser(String user_uniqueid);
    }
}
