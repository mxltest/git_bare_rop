using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Net4Frm.IRepository;
using Net4Frm.Repository;

namespace Net4Frm.RepositoryFactory
{
    public partial class DbSession : IDbSession
    {
        IUnitOfWork unitOfWork = new UnitOfWork();

        public void SaveChange()
        {
            this.unitOfWork.SaveChanges();
        }

        public IEnumerable<TResult> ExecuteSql<TResult>(string sql, object paras = null)
        {
            return unitOfWork.ExecuteSql<TResult>(sql, paras);
        }

        public int ExecuteSql(string sql, object paras = null)
        {
            return unitOfWork.ExecuteSql(sql, paras);
        }

        public void ExecuteSqlNoneQuery(string sql, object paras = null)
        {
            this.unitOfWork.ExecuteSqlNoneQuery(sql, paras);
        }
    }
}
