using Net4Frm.Model;
using Net4Frm.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
   public interface IOperationWorkCalTemplate
    {
       Ptcp<ModelBase> InsertWorkCalTemplate(WorkCalTemplate datTemplate);
       IEnumerable<WorkCalTemplate> QueryWorkCalTemplate(PageQueryInput pagerInfo, WorkCalTemplate query_entity);
       Ptcp<ModelBase> UpdateWorkCalTemplate(WorkCalTemplate datTemplate);
       Ptcp<ModelBase> DeleteWorkCalTemplate(String WorkCalTempletNo);
    }
}
