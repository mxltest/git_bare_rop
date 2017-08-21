using System.Collections.Generic;
using System.Data;
using Net4Frm.Model;

namespace Net4Frm.IRepository
{
    public interface IUnitOfWork
    {
        void RegisterAdded(IUnitOfWorkRepository repository, params ModelBase[] items);
        void RegisterChanged(IUnitOfWorkRepository repository, params ModelBase[] items);
        void RegisterDataTable(DataTable dataTable, string tableName);

        void SaveChanges();

        IEnumerable<TResult> ExecuteSql<TResult>(string sql, object paras);
        int ExecuteSql(string sql, object paras);
        void ExecuteSqlNoneQuery(string sql, object paras);
    }
}
