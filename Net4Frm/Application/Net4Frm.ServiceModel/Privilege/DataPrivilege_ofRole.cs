using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.Privilege
{
    public class DataPrivilege_ofRole
    {
        public Nullable<int> Id { get; set; }
        public string Role_uniqueid { get; set; }
        public string Prd_role_name { get; set; }
        public Nullable<int> Data_view_id { get; set; }
        public string Prd_data_view_name { get; set; }
        public string Prd_data_view_code { get; set; }
        public string Authorize_columns { get; set; }
        public string Authorize_desc { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public byte[] Last_timestamp { get; set; }
    }

    public class QueryDataPrivelegeOfRoleRes : BaseSearchResponse {
        public IEnumerable<DataPrivilege_ofRole> result_data { get; set; }
    }
    public class QueryDataPrivelegeOfRoleReq :BaseSearchRequest {
        public DataPrivilege_ofRole query_entity { get; set; }
    }
    public class UpdateDataPrivelegeOfRoleOfAviewRes : BaseResponse {

    }
    public class UpdateDataPrivelegeOfRoleOfAviewReq {
        public IEnumerable<DataPrivilege_ofRole> inserted { get; set; }
        public IEnumerable<DataPrivilege_ofRole> deleted { get; set; }
        public IEnumerable<DataPrivilege_ofRole> updated { get; set; }
    }
}
