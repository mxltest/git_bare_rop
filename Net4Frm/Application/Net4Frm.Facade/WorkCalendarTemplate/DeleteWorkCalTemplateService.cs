using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.User;
using Net4Frm.ServiceModel.WorkCalendarTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Facade.WorkCalendarTemplate
{
    public class DeleteWorkCalTemplateService : BaseService<IOperationWorkCalTemplate>
    {
        public DeleteCalendarTemplateRes Any(DeleteCalendarTemplateReq req)
        {
            DeleteCalendarTemplateRes res = new DeleteCalendarTemplateRes();

            var ptcp = ServiceImpl.DeleteWorkCalTemplate(req.WorkCalTempletNo);

            res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
            res.DoResult = ptcp.Message;
            return res;
        }
    }
}
