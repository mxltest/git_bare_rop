using Net4Frm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceInterface
{
    public interface IOperationCheckDataUnique
    {
        Ptcp<ModelBase> CheckDateUnique(String _tableName, String _columnName, String _value, out bool is_uniquevalue, out long counts);
    }
}
