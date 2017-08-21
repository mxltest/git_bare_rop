using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.WorkCalendarTemplate
{
    public class WorkCalTemplateInfo
    {
        public Nullable<int> Id { get; set; }
        public string WorkCalTempletNo { get; set; }
        public string WorkCalTempletName { get; set; }
        public string WorkCalCycleNo { get; set; }
        public Nullable<int> CycleDays { get; set; }
        public string Remark { get; set; }
        public string DataStatus { get; set; }
        public string Creator_nqid { get; set; }
        public string Creator_name { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Updator_nqid { get; set; }
        public string Updator_name { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string Submitter_nqid { get; set; }
        public string Submitter_name { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public string Approver_nqid { get; set; }
        public string Approver_name { get; set; }
        public Nullable<System.DateTime> ApproveTime { get; set; }
        public string Abandoner_nqid { get; set; }
        public string Abandoner_name { get; set; }
        public Nullable<System.DateTime> AbandonTime { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
    public class AddCalendarTemplateRes : BaseResponse { }
    public class AddCalendarTemplateReq : WorkCalTemplateInfo { }

    public class QueryCalendarTemplateReq : BaseSearchRequest
    {
        public WorkCalTemplateInfo query_entity { get; set; }
    }
    public class QueryCalendarTemplateRes : BaseSearchResponse
    {
        public IEnumerable<WorkCalTemplateInfo> result_data { get; set; }
    }

    public class UpdateCalendarTemplateReq : WorkCalTemplateInfo { }
    public class UpdateCalendarTemplateRes : BaseResponse { }

    public class DeleteCalendarTemplateReq
    {
        public string WorkCalTempletNo { get; set; }
    }
    public class DeleteCalendarTemplateRes : BaseResponse
    {

    }
}
