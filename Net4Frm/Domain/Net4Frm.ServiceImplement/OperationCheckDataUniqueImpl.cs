using Net4Frm.Model;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Net4Frm.Logging;
using Net4Frm.Log4Net;

namespace Net4Frm.ServiceImplement
{
    public class OperationCheckDataUniqueImpl : BaseService, IOperationCheckDataUnique
    {
        #region 表字段值唯一性判断API
        /// <summary>
        /// 表字段值唯一性判断API
        /// </summary>
        /// <param name="_tableName">表名</param>
        /// <param name="_columnName">列名</param>
        /// <param name="_value">列值</param>
        /// <param name="repeat_values"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> CheckDateUnique(string _tableName, string _columnName, string _value, out bool is_uniquevalue, out long counts)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            counts = 0;
            is_uniquevalue = true;
            try
            {
                if (_tableName == null || _columnName == null || _value == null)
                {
                    ptcp.Message = "请确保输入信息不为空！";
                    ptcp.StatusFlag = PtcpState.Failed;
                    return ptcp;
                }
               
                counts = DbSession.log_commonRepository.CheckField(_tableName, _columnName, _value);
                bool has_values = counts > 0;
                if (has_values)
                {
                    is_uniquevalue = false;
                }
                else
                {
                    is_uniquevalue = true;
                }
                ptcp.StatusFlag = PtcpState.Success;

            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;

                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", "00000000", "", "", ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion
    }
}
