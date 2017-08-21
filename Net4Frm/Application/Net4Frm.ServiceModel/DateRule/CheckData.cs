using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.DateRule
{
    public class CheckData
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Value { get; set; }
    }
    public class CheckUniqueRes : BaseSearchResponse
    {
        public bool is_uniquevalue { get; set; }
        public long count { get; set; }
    }
    public class CheckUniqueReq : BaseSearchRequest
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Value { get; set; }
    }
}
