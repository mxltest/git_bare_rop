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
    public class AddCalendarTemplateService : BaseService<IOperationWorkCalTemplate>
    {
        public AddCalendarTemplateRes Any(AddCalendarTemplateReq req)
        {

            AddCalendarTemplateRes res = new AddCalendarTemplateRes();
            try
            {
                var data = Mapper.Map<AddCalendarTemplateReq, WorkCalTemplate>(req);
                var ptcp = ServiceImpl.InsertWorkCalTemplate(data);
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
