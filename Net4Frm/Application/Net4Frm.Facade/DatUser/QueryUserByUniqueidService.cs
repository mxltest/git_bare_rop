using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.DatUser
{
    public class QueryUserByUniqueidService : BaseService<IOperationSysDatUser>
    {
        public QueryUserByUniqueidRes Any(QueryUserByUniqueidReq req)
        {
            QueryUserByUniqueidRes res = new QueryUserByUniqueidRes();

            var ptcp = ServiceImpl.QueryUserByUniqueid(req.Uniqueid);

            return new QueryUserByUniqueidRes
            {
                DoFlag = true,
                query_entity = Mapper.Map<N4_SysDatUser, UserInfo>(ptcp)
            };
        }
    }
}
