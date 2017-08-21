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
    public class UpdateWorkCalTemplateService : BaseService<IOperationWorkCalTemplate>
    {
        public UpdateCalendarTemplateRes Any(UpdateCalendarTemplateReq req)
        {
            UpdateCalendarTemplateRes res = new UpdateCalendarTemplateRes();
            try
            {
                var data = Mapper.Map<UpdateCalendarTemplateReq, WorkCalTemplate>(req);
                var ptcp = ServiceImpl.UpdateWorkCalTemplate(data);
                res.DoFlag = ptcp.StatusFlag == PtcpState.Success;
                res.DoResult = ptcp.Message;

            }
            catch (Exception ex)
            {
                res.DoResult = ex.Message;
                res.DoFlag = false;
            }
            return res;
        }

    }
}
