using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel
{
    public class BaseRequest
    {
        public int? Operator { get; set; }
        public string OperatorName { get; set; }

        public int? Current_Page_Index { get; set; }
        public int? PageSize { get; set; }
    }

    public class BaseSearchRequest
    {
        private int? _pageIndex;
        public int? current_page_index
        {
            get { return _pageIndex; }
            set { _pageIndex = (value < 1 ? 1 : value) ?? 1; }
        }

        private int? _pageSize;
        public int? pagesize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = (value >= 1000 ? 20 : value) ?? 20;
            }
        }
    }
}
