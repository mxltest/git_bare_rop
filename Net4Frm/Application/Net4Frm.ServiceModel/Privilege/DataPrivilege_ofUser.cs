using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.Privilege
{
    public class DataPrivilege_ofUser
    {
        public Nullable<int> Id { get; set; }
        public string User_uniqueid { get; set; }
        public string Prd_user_name { get; set; }
        public Nullable<int> Data_view_id { get; set; }
        public string Prd_data_view_name { get; set; }
        public string Prd_data_view_code { get; set; }
        public string Authorize_columns { get; set; }
        public string Authorize_desc { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public byte[] Last_timestamp { get; set; }
    }

    public class QueryDataPrivelegeOfUserRes : BaseSearchResponse {
        public IEnumerable<DataPrivilege_ofUser> result_data { get; set; }
    }
    public class QueryDataPrivelegeOfUserReq : BaseSearchRequest {
        public DataPrivilege_ofUser query_entity { get; set; }
    }
    public class UpdateDataPrivelegeOfUserOfAviewRes : BaseResponse
    {

    }
    public class UpdateDataPrivelegeOfUserOfAviewReq
    {
        public IEnumerable<DataPrivilege_ofUser> inserted { get; set; }
        public IEnumerable<DataPrivilege_ofUser> deleted { get; set; }
        public IEnumerable<DataPrivilege_ofUser> updated { get; set; }
    }
}
