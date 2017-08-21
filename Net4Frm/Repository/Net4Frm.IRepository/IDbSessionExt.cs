using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.IRepository
{
    public partial interface IDbSession
    {
        void SaveChange();

        int ExecuteSql(string sql, object paras = null);
        IEnumerable<TResult> ExecuteSql<TResult>(string sql, object paras = null);
        void ExecuteSqlNoneQuery(string sql, object paras = null);
    }
}
