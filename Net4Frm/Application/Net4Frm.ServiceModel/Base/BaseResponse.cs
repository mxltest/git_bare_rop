using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.ServiceInterface.ServiceModel;

namespace Net4Frm.ServiceModel
{
    public class BaseResponse
    {
        public ResponseStatus ResponseStatus { get; set; }
        public bool DoFlag { get; set; }
        public string DoResult { get; set; }

        public BaseResponse()
        {
            ResponseStatus = new ResponseStatus()
                {

                };
        }
    }

    public class BaseSearchResponse : BaseResponse
    {
        public int? current_page_index { get; set; }
        public int? pagesize { get; set; }
        public long total_row_count { get; set; }

    }


}
