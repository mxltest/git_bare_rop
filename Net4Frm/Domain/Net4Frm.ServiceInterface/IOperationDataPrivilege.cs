using Net4Frm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationDataPrivilege
    {
        Ptcp<IEnumerable<N4_DataPrivilege_ofRole>> QueryDataPrivelegeOfRole(PageQueryInput pageInput, String role_uniqueid);
        Ptcp<IEnumerable<N4_DataPrivilege_ofUser>> QueryDataPrivelegeOfUser(PageQueryInput pageInput, String user_uniqueid);
        Ptcp<ModelBase> UpdateDataPrivelegeOfRoleOfAview(IEnumerable<N4_DataPrivilege_ofRole> inserted, IEnumerable<N4_DataPrivilege_ofRole> deleted, IEnumerable<N4_DataPrivilege_ofRole> updated);
        Ptcp<ModelBase> UpdateDataPrivelegeOfUserOfAview(IEnumerable<N4_DataPrivilege_ofUser> inserted, IEnumerable<N4_DataPrivilege_ofUser> deleted, IEnumerable<N4_DataPrivilege_ofUser> updated);
    }
}
