using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using Net4Frm.ServiceModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Net4Frm.ServiceModel.DateRule;

namespace Net4Frm.Facade.CheckData
{
    public class CheckDataService : BaseService<IOperationCheckDataUnique>
    {
        public CheckUniqueRes Any(CheckUniqueReq req)
        {
            CheckUniqueRes res = new CheckUniqueRes();
            try
            {
                bool is_uniquevalues = true;
                long counts=0;
                var ptcp = ServiceImpl.CheckDateUnique(req.TableName, req.ColumnName, req.Value, out  is_uniquevalues, out counts);
                res.count = counts;
                res.is_uniquevalue = is_uniquevalues;
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
