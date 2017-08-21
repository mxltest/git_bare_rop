
using System.Collections.Generic;
using Net4Frm.IRepository;
using Net4Frm.Model;
using System;

namespace Net4Frm.Repository
{
   
	
public partial class log_commonRepository : BaseRepository<log_common>, Ilog_commonRepository
{
		public log_commonRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="log_common";
		} 
		public log_commonRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(log_common model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Log_date!=null) 
		{
			list.Add(addFunc("Log_date",model.Log_date.ToString()));
		}

						if(model.Thread!=null) 
		{
			list.Add(addFunc("Thread",model.Thread.ToString()));
		}

						if(model.Log_level!=null) 
		{
			list.Add(addFunc("Log_level",model.Log_level.ToString()));
		}

						if(model.Logger!=null) 
		{
			list.Add(addFunc("Logger",model.Logger.ToString()));
		}

						if(model.Message!=null) 
		{
			list.Add(addFunc("Message",model.Message.ToString()));
		}

						if(model.Exception!=null) 
		{
			list.Add(addFunc("Exception",model.Exception.ToString()));
		}

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(addFunc("Entity_scheme_name",model.Entity_scheme_name.ToString()));
		}

						if(model.Entity_id!=null) 
		{
			list.Add(addFunc("Entity_id",model.Entity_id.ToString()));
		}

						if(model.String_for_old_entity!=null) 
		{
			list.Add(addFunc("String_for_old_entity",model.String_for_old_entity.ToString()));
		}

						if(model.String_for_new_entity!=null) 
		{
			list.Add(addFunc("String_for_new_entity",model.String_for_new_entity.ToString()));
		}

						if(model.Description!=null) 
		{
			list.Add(addFunc("Description",model.Description.ToString()));
		}

						if(model.Device_info!=null) 
		{
			list.Add(addFunc("Device_info",model.Device_info.ToString()));
		}

						if(model.Userid!=null) 
		{
			list.Add(addFunc("Userid",model.Userid.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(log_common model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Log_date!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_date.ToString(),addFunc("[Log_date]")));
		}
					

						if(model.Thread!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Thread.ToString(),addFunc("[Thread]")));
		}
					

						if(model.Log_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_level.ToString(),addFunc("[Log_level]")));
		}
					

						if(model.Logger!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Logger.ToString(),addFunc("[Logger]")));
		}
					

						if(model.Message!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Message.ToString(),addFunc("[Message]")));
		}
					

						if(model.Exception!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception.ToString(),addFunc("[Exception]")));
		}
					

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_scheme_name.ToString(),addFunc("[Entity_scheme_name]")));
		}
					

						if(model.Entity_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_id.ToString(),addFunc("[Entity_id]")));
		}
					

						if(model.String_for_old_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_old_entity.ToString(),addFunc("[String_for_old_entity]")));
		}
					

						if(model.String_for_new_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_new_entity.ToString(),addFunc("[String_for_new_entity]")));
		}
					

						if(model.Description!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description.ToString(),addFunc("[Description]")));
		}
					

						if(model.Device_info!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Device_info.ToString(),addFunc("[Device_info]")));
		}
					

						if(model.Userid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Userid.ToString(),addFunc("[Userid]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(log_common)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(log_common)item[0];		
	var where=	(log_common)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(log_common where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, log_common where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(log_common where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, log_common where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, log_common where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class log_common_fanRepository : BaseRepository<log_common_fan>, Ilog_common_fanRepository
{
		public log_common_fanRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="log_common_fan";
		} 
		public log_common_fanRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(log_common_fan model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Log_date!=null) 
		{
			list.Add(addFunc("Log_date",model.Log_date.ToString()));
		}

						if(model.Thread!=null) 
		{
			list.Add(addFunc("Thread",model.Thread.ToString()));
		}

						if(model.Log_level!=null) 
		{
			list.Add(addFunc("Log_level",model.Log_level.ToString()));
		}

						if(model.Logger!=null) 
		{
			list.Add(addFunc("Logger",model.Logger.ToString()));
		}

						if(model.Message!=null) 
		{
			list.Add(addFunc("Message",model.Message.ToString()));
		}

						if(model.Exception!=null) 
		{
			list.Add(addFunc("Exception",model.Exception.ToString()));
		}

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(addFunc("Entity_scheme_name",model.Entity_scheme_name.ToString()));
		}

						if(model.Entity_id!=null) 
		{
			list.Add(addFunc("Entity_id",model.Entity_id.ToString()));
		}

						if(model.String_for_old_entity!=null) 
		{
			list.Add(addFunc("String_for_old_entity",model.String_for_old_entity.ToString()));
		}

						if(model.String_for_new_entity!=null) 
		{
			list.Add(addFunc("String_for_new_entity",model.String_for_new_entity.ToString()));
		}

						if(model.Description!=null) 
		{
			list.Add(addFunc("Description",model.Description.ToString()));
		}

						if(model.Fan_class_name!=null) 
		{
			list.Add(addFunc("Fan_class_name",model.Fan_class_name.ToString()));
		}

						if(model.Fan_function_in_code!=null) 
		{
			list.Add(addFunc("Fan_function_in_code",model.Fan_function_in_code.ToString()));
		}

						if(model.Device_info!=null) 
		{
			list.Add(addFunc("Device_info",model.Device_info.ToString()));
		}

						if(model.Userid!=null) 
		{
			list.Add(addFunc("Userid",model.Userid.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(log_common_fan model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Log_date!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_date.ToString(),addFunc("[Log_date]")));
		}
					

						if(model.Thread!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Thread.ToString(),addFunc("[Thread]")));
		}
					

						if(model.Log_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_level.ToString(),addFunc("[Log_level]")));
		}
					

						if(model.Logger!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Logger.ToString(),addFunc("[Logger]")));
		}
					

						if(model.Message!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Message.ToString(),addFunc("[Message]")));
		}
					

						if(model.Exception!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception.ToString(),addFunc("[Exception]")));
		}
					

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_scheme_name.ToString(),addFunc("[Entity_scheme_name]")));
		}
					

						if(model.Entity_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_id.ToString(),addFunc("[Entity_id]")));
		}
					

						if(model.String_for_old_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_old_entity.ToString(),addFunc("[String_for_old_entity]")));
		}
					

						if(model.String_for_new_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_new_entity.ToString(),addFunc("[String_for_new_entity]")));
		}
					

						if(model.Description!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description.ToString(),addFunc("[Description]")));
		}
					

						if(model.Fan_class_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Fan_class_name.ToString(),addFunc("[Fan_class_name]")));
		}
					

						if(model.Fan_function_in_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Fan_function_in_code.ToString(),addFunc("[Fan_function_in_code]")));
		}
					

						if(model.Device_info!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Device_info.ToString(),addFunc("[Device_info]")));
		}
					

						if(model.Userid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Userid.ToString(),addFunc("[Userid]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(log_common_fan)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(log_common_fan)item[0];		
	var where=	(log_common_fan)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(log_common_fan where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, log_common_fan where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(log_common_fan where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, log_common_fan where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, log_common_fan where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_DataPrivilege_ofRoleRepository : BaseRepository<N4_DataPrivilege_ofRole>, IN4_DataPrivilege_ofRoleRepository
{
		public N4_DataPrivilege_ofRoleRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_DataPrivilege_ofRole";
		} 
		public N4_DataPrivilege_ofRoleRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_DataPrivilege_ofRole model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Role_uniqueid!=null) 
		{
			list.Add(addFunc("Role_uniqueid",model.Role_uniqueid.ToString()));
		}

						if(model.Prd_role_name!=null) 
		{
			list.Add(addFunc("Prd_role_name",model.Prd_role_name.ToString()));
		}

						if(model.Data_view_id!=null) 
		{
			list.Add(addFunc("Data_view_id",model.Data_view_id.ToString()));
		}

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(addFunc("Prd_data_view_name",model.Prd_data_view_name.ToString()));
		}

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(addFunc("Prd_data_view_code",model.Prd_data_view_code.ToString()));
		}

						if(model.Authorize_columns!=null) 
		{
			list.Add(addFunc("Authorize_columns",model.Authorize_columns.ToString()));
		}

						if(model.Authorize_desc!=null) 
		{
			list.Add(addFunc("Authorize_desc",model.Authorize_desc.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_DataPrivilege_ofRole model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Role_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_uniqueid.ToString(),addFunc("[Role_uniqueid]")));
		}
					

						if(model.Prd_role_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_role_name.ToString(),addFunc("[Prd_role_name]")));
		}
					

						if(model.Data_view_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_id.ToString(),addFunc("[Data_view_id]")));
		}
					

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_name.ToString(),addFunc("[Prd_data_view_name]")));
		}
					

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_code.ToString(),addFunc("[Prd_data_view_code]")));
		}
					

						if(model.Authorize_columns!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_columns.ToString(),addFunc("[Authorize_columns]")));
		}
					

						if(model.Authorize_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_desc.ToString(),addFunc("[Authorize_desc]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_DataPrivilege_ofRole)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_DataPrivilege_ofRole)item[0];		
	var where=	(N4_DataPrivilege_ofRole)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_DataPrivilege_ofRole where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_DataPrivilege_ofRole where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_DataPrivilege_ofRole where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_DataPrivilege_ofRole where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_DataPrivilege_ofRole where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_DataPrivilege_ofUserRepository : BaseRepository<N4_DataPrivilege_ofUser>, IN4_DataPrivilege_ofUserRepository
{
		public N4_DataPrivilege_ofUserRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_DataPrivilege_ofUser";
		} 
		public N4_DataPrivilege_ofUserRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_DataPrivilege_ofUser model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_uniqueid!=null) 
		{
			list.Add(addFunc("User_uniqueid",model.User_uniqueid.ToString()));
		}

						if(model.Prd_user_name!=null) 
		{
			list.Add(addFunc("Prd_user_name",model.Prd_user_name.ToString()));
		}

						if(model.Data_view_id!=null) 
		{
			list.Add(addFunc("Data_view_id",model.Data_view_id.ToString()));
		}

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(addFunc("Prd_data_view_name",model.Prd_data_view_name.ToString()));
		}

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(addFunc("Prd_data_view_code",model.Prd_data_view_code.ToString()));
		}

						if(model.Authorize_columns!=null) 
		{
			list.Add(addFunc("Authorize_columns",model.Authorize_columns.ToString()));
		}

						if(model.Authorize_desc!=null) 
		{
			list.Add(addFunc("Authorize_desc",model.Authorize_desc.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_DataPrivilege_ofUser model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_uniqueid.ToString(),addFunc("[User_uniqueid]")));
		}
					

						if(model.Prd_user_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_user_name.ToString(),addFunc("[Prd_user_name]")));
		}
					

						if(model.Data_view_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_id.ToString(),addFunc("[Data_view_id]")));
		}
					

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_name.ToString(),addFunc("[Prd_data_view_name]")));
		}
					

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_code.ToString(),addFunc("[Prd_data_view_code]")));
		}
					

						if(model.Authorize_columns!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_columns.ToString(),addFunc("[Authorize_columns]")));
		}
					

						if(model.Authorize_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_desc.ToString(),addFunc("[Authorize_desc]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_DataPrivilege_ofUser)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_DataPrivilege_ofUser)item[0];		
	var where=	(N4_DataPrivilege_ofUser)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_DataPrivilege_ofUser where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_DataPrivilege_ofUser where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_DataPrivilege_ofUser where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_DataPrivilege_ofUser where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_DataPrivilege_ofUser where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_DataPrivilege_TempleteRepository : BaseRepository<N4_DataPrivilege_Templete>, IN4_DataPrivilege_TempleteRepository
{
		public N4_DataPrivilege_TempleteRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_DataPrivilege_Templete";
		} 
		public N4_DataPrivilege_TempleteRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_DataPrivilege_Templete model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Data_view_name!=null) 
		{
			list.Add(addFunc("Data_view_name",model.Data_view_name.ToString()));
		}

						if(model.Data_view_code!=null) 
		{
			list.Add(addFunc("Data_view_code",model.Data_view_code.ToString()));
		}

						if(model.Columns_of_view!=null) 
		{
			list.Add(addFunc("Columns_of_view",model.Columns_of_view.ToString()));
		}

						if(model.Description_of_view!=null) 
		{
			list.Add(addFunc("Description_of_view",model.Description_of_view.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_DataPrivilege_Templete model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Data_view_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_name.ToString(),addFunc("[Data_view_name]")));
		}
					

						if(model.Data_view_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_code.ToString(),addFunc("[Data_view_code]")));
		}
					

						if(model.Columns_of_view!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Columns_of_view.ToString(),addFunc("[Columns_of_view]")));
		}
					

						if(model.Description_of_view!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description_of_view.ToString(),addFunc("[Description_of_view]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_DataPrivilege_Templete)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_DataPrivilege_Templete)item[0];		
	var where=	(N4_DataPrivilege_Templete)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_DataPrivilege_Templete where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_DataPrivilege_Templete where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_DataPrivilege_Templete where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_DataPrivilege_Templete where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_DataPrivilege_Templete where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_DepartmentRepository : BaseRepository<N4_Department>, IN4_DepartmentRepository
{
		public N4_DepartmentRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_Department";
		} 
		public N4_DepartmentRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_Department model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Organization_uniqueid!=null) 
		{
			list.Add(addFunc("Organization_uniqueid",model.Organization_uniqueid.ToString()));
		}

						if(model.Organization_code!=null) 
		{
			list.Add(addFunc("Organization_code",model.Organization_code.ToString()));
		}

						if(model.Name!=null) 
		{
			list.Add(addFunc("Name",model.Name.ToString()));
		}

						if(model.Brief_name!=null) 
		{
			list.Add(addFunc("Brief_name",model.Brief_name.ToString()));
		}

						if(model.Description!=null) 
		{
			list.Add(addFunc("Description",model.Description.ToString()));
		}

						if(model.Mnemonic_code!=null) 
		{
			list.Add(addFunc("Mnemonic_code",model.Mnemonic_code.ToString()));
		}

						if(model.Manager_uniqueid!=null) 
		{
			list.Add(addFunc("Manager_uniqueid",model.Manager_uniqueid.ToString()));
		}

						if(model.Prd_manager_name!=null) 
		{
			list.Add(addFunc("Prd_manager_name",model.Prd_manager_name.ToString()));
		}

						if(model.Parent_organization_uniqueid!=null) 
		{
			list.Add(addFunc("Parent_organization_uniqueid",model.Parent_organization_uniqueid.ToString()));
		}

						if(model.Parent_organization_name!=null) 
		{
			list.Add(addFunc("Parent_organization_name",model.Parent_organization_name.ToString()));
		}

						if(model.Remark!=null) 
		{
			list.Add(addFunc("Remark",model.Remark.ToString()));
		}

						if(model.Data_status!=null) 
		{
			list.Add(addFunc("Data_status",model.Data_status.ToString()));
		}

						if(model.Abandon_status!=null) 
		{
			list.Add(addFunc("Abandon_status",model.Abandon_status.ToString()));
		}

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(addFunc("Creator_uniqueid",model.Creator_uniqueid.ToString()));
		}

						if(model.Prd_creator_name!=null) 
		{
			list.Add(addFunc("Prd_creator_name",model.Prd_creator_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Updator!=null) 
		{
			list.Add(addFunc("Updator",model.Updator.ToString()));
		}

						if(model.Update_time!=null) 
		{
			list.Add(addFunc("Update_time",model.Update_time.ToString()));
		}

						if(model.Submitter!=null) 
		{
			list.Add(addFunc("Submitter",model.Submitter.ToString()));
		}

						if(model.Submit_time!=null) 
		{
			list.Add(addFunc("Submit_time",model.Submit_time.ToString()));
		}

						if(model.Approver!=null) 
		{
			list.Add(addFunc("Approver",model.Approver.ToString()));
		}

						if(model.Approve_time!=null) 
		{
			list.Add(addFunc("Approve_time",model.Approve_time.ToString()));
		}

						if(model.Abandoner!=null) 
		{
			list.Add(addFunc("Abandoner",model.Abandoner.ToString()));
		}

						if(model.Abandon_time!=null) 
		{
			list.Add(addFunc("Abandon_time",model.Abandon_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_Department model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Organization_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Organization_uniqueid.ToString(),addFunc("[Organization_uniqueid]")));
		}
					

						if(model.Organization_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Organization_code.ToString(),addFunc("[Organization_code]")));
		}
					

						if(model.Name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Name.ToString(),addFunc("[Name]")));
		}
					

						if(model.Brief_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Brief_name.ToString(),addFunc("[Brief_name]")));
		}
					

						if(model.Description!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description.ToString(),addFunc("[Description]")));
		}
					

						if(model.Mnemonic_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Mnemonic_code.ToString(),addFunc("[Mnemonic_code]")));
		}
					

						if(model.Manager_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Manager_uniqueid.ToString(),addFunc("[Manager_uniqueid]")));
		}
					

						if(model.Prd_manager_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_manager_name.ToString(),addFunc("[Prd_manager_name]")));
		}
					

						if(model.Parent_organization_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Parent_organization_uniqueid.ToString(),addFunc("[Parent_organization_uniqueid]")));
		}
					

						if(model.Parent_organization_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Parent_organization_name.ToString(),addFunc("[Parent_organization_name]")));
		}
					

						if(model.Remark!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Remark.ToString(),addFunc("[Remark]")));
		}
					

						if(model.Data_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_status.ToString(),addFunc("[Data_status]")));
		}
					

						if(model.Abandon_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_status.ToString(),addFunc("[Abandon_status]")));
		}
					

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_uniqueid.ToString(),addFunc("[Creator_uniqueid]")));
		}
					

						if(model.Prd_creator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_creator_name.ToString(),addFunc("[Prd_creator_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Updator!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator.ToString(),addFunc("[Updator]")));
		}
					

						if(model.Update_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Update_time.ToString(),addFunc("[Update_time]")));
		}
					

						if(model.Submitter!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter.ToString(),addFunc("[Submitter]")));
		}
					

						if(model.Submit_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submit_time.ToString(),addFunc("[Submit_time]")));
		}
					

						if(model.Approver!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver.ToString(),addFunc("[Approver]")));
		}
					

						if(model.Approve_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approve_time.ToString(),addFunc("[Approve_time]")));
		}
					

						if(model.Abandoner!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner.ToString(),addFunc("[Abandoner]")));
		}
					

						if(model.Abandon_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_time.ToString(),addFunc("[Abandon_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_Department)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_Department)item[0];		
	var where=	(N4_Department)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_Department where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_Department where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_Department where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_Department where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_Department where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_DepartmentPrivilegeRepository : BaseRepository<N4_DepartmentPrivilege>, IN4_DepartmentPrivilegeRepository
{
		public N4_DepartmentPrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_DepartmentPrivilege";
		} 
		public N4_DepartmentPrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_DepartmentPrivilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Department_uniqueid!=null) 
		{
			list.Add(addFunc("Department_uniqueid",model.Department_uniqueid.ToString()));
		}

						if(model.Privilege_code!=null) 
		{
			list.Add(addFunc("Privilege_code",model.Privilege_code.ToString()));
		}

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(addFunc("Prd_privilege_text",model.Prd_privilege_text.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_DepartmentPrivilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Department_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Department_uniqueid.ToString(),addFunc("[Department_uniqueid]")));
		}
					

						if(model.Privilege_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_code.ToString(),addFunc("[Privilege_code]")));
		}
					

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_privilege_text.ToString(),addFunc("[Prd_privilege_text]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_DepartmentPrivilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_DepartmentPrivilege)item[0];		
	var where=	(N4_DepartmentPrivilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_DepartmentPrivilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_DepartmentPrivilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_DepartmentPrivilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_DepartmentPrivilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_DepartmentPrivilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_LogRepository : BaseRepository<N4_Log>, IN4_LogRepository
{
		public N4_LogRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_Log";
		} 
		public N4_LogRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_Log model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Log_date!=null) 
		{
			list.Add(addFunc("Log_date",model.Log_date.ToString()));
		}

						if(model.Log_tag!=null) 
		{
			list.Add(addFunc("Log_tag",model.Log_tag.ToString()));
		}

						if(model.Thread!=null) 
		{
			list.Add(addFunc("Thread",model.Thread.ToString()));
		}

						if(model.Log_level!=null) 
		{
			list.Add(addFunc("Log_level",model.Log_level.ToString()));
		}

						if(model.Logger!=null) 
		{
			list.Add(addFunc("Logger",model.Logger.ToString()));
		}

						if(model.Message!=null) 
		{
			list.Add(addFunc("Message",model.Message.ToString()));
		}

						if(model.Exception!=null) 
		{
			list.Add(addFunc("Exception",model.Exception.ToString()));
		}

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(addFunc("Entity_scheme_name",model.Entity_scheme_name.ToString()));
		}

						if(model.Entity_id!=null) 
		{
			list.Add(addFunc("Entity_id",model.Entity_id.ToString()));
		}

						if(model.String_for_old_entity!=null) 
		{
			list.Add(addFunc("String_for_old_entity",model.String_for_old_entity.ToString()));
		}

						if(model.String_for_new_entity!=null) 
		{
			list.Add(addFunc("String_for_new_entity",model.String_for_new_entity.ToString()));
		}

						if(model.Description!=null) 
		{
			list.Add(addFunc("Description",model.Description.ToString()));
		}

						if(model.Fan_class_name!=null) 
		{
			list.Add(addFunc("Fan_class_name",model.Fan_class_name.ToString()));
		}

						if(model.Fan_function_in_code!=null) 
		{
			list.Add(addFunc("Fan_function_in_code",model.Fan_function_in_code.ToString()));
		}

						if(model.Device_info!=null) 
		{
			list.Add(addFunc("Device_info",model.Device_info.ToString()));
		}

						if(model.Userid!=null) 
		{
			list.Add(addFunc("Userid",model.Userid.ToString()));
		}

						if(model.Ip_addr!=null) 
		{
			list.Add(addFunc("Ip_addr",model.Ip_addr.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_Log model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Log_date!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_date.ToString(),addFunc("[Log_date]")));
		}
					

						if(model.Log_tag!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_tag.ToString(),addFunc("[Log_tag]")));
		}
					

						if(model.Thread!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Thread.ToString(),addFunc("[Thread]")));
		}
					

						if(model.Log_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_level.ToString(),addFunc("[Log_level]")));
		}
					

						if(model.Logger!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Logger.ToString(),addFunc("[Logger]")));
		}
					

						if(model.Message!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Message.ToString(),addFunc("[Message]")));
		}
					

						if(model.Exception!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception.ToString(),addFunc("[Exception]")));
		}
					

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_scheme_name.ToString(),addFunc("[Entity_scheme_name]")));
		}
					

						if(model.Entity_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_id.ToString(),addFunc("[Entity_id]")));
		}
					

						if(model.String_for_old_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_old_entity.ToString(),addFunc("[String_for_old_entity]")));
		}
					

						if(model.String_for_new_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_new_entity.ToString(),addFunc("[String_for_new_entity]")));
		}
					

						if(model.Description!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description.ToString(),addFunc("[Description]")));
		}
					

						if(model.Fan_class_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Fan_class_name.ToString(),addFunc("[Fan_class_name]")));
		}
					

						if(model.Fan_function_in_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Fan_function_in_code.ToString(),addFunc("[Fan_function_in_code]")));
		}
					

						if(model.Device_info!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Device_info.ToString(),addFunc("[Device_info]")));
		}
					

						if(model.Userid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Userid.ToString(),addFunc("[Userid]")));
		}
					

						if(model.Ip_addr!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Ip_addr.ToString(),addFunc("[Ip_addr]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_Log)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_Log)item[0];		
	var where=	(N4_Log)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_Log where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_Log where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_Log where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_Log where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_Log where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_logToUserLoginoutRepository : BaseRepository<N4_logToUserLoginout>, IN4_logToUserLoginoutRepository
{
		public N4_logToUserLoginoutRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_logToUserLoginout";
		} 
		public N4_logToUserLoginoutRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_logToUserLoginout model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_unique_id!=null) 
		{
			list.Add(addFunc("User_unique_id",model.User_unique_id.ToString()));
		}

						if(model.Prd_user_name!=null) 
		{
			list.Add(addFunc("Prd_user_name",model.Prd_user_name.ToString()));
		}

						if(model.Token!=null) 
		{
			list.Add(addFunc("Token",model.Token.ToString()));
		}

						if(model.Login_time!=null) 
		{
			list.Add(addFunc("Login_time",model.Login_time.ToString()));
		}

						if(model.Login_type!=null) 
		{
			list.Add(addFunc("Login_type",model.Login_type.ToString()));
		}

						if(model.Device_info!=null) 
		{
			list.Add(addFunc("Device_info",model.Device_info.ToString()));
		}

						if(model.Event_level!=null) 
		{
			list.Add(addFunc("Event_level",model.Event_level.ToString()));
		}

						if(model.Exception_desc!=null) 
		{
			list.Add(addFunc("Exception_desc",model.Exception_desc.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_logToUserLoginout model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_unique_id.ToString(),addFunc("[User_unique_id]")));
		}
					

						if(model.Prd_user_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_user_name.ToString(),addFunc("[Prd_user_name]")));
		}
					

						if(model.Token!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Token.ToString(),addFunc("[Token]")));
		}
					

						if(model.Login_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Login_time.ToString(),addFunc("[Login_time]")));
		}
					

						if(model.Login_type!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Login_type.ToString(),addFunc("[Login_type]")));
		}
					

						if(model.Device_info!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Device_info.ToString(),addFunc("[Device_info]")));
		}
					

						if(model.Event_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Event_level.ToString(),addFunc("[Event_level]")));
		}
					

						if(model.Exception_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception_desc.ToString(),addFunc("[Exception_desc]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_logToUserLoginout)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_logToUserLoginout)item[0];		
	var where=	(N4_logToUserLoginout)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_logToUserLoginout where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_logToUserLoginout where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_logToUserLoginout where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_logToUserLoginout where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_logToUserLoginout where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_logToUserOperationRepository : BaseRepository<N4_logToUserOperation>, IN4_logToUserOperationRepository
{
		public N4_logToUserOperationRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_logToUserOperation";
		} 
		public N4_logToUserOperationRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_logToUserOperation model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_unique_id!=null) 
		{
			list.Add(addFunc("User_unique_id",model.User_unique_id.ToString()));
		}

						if(model.Prd_user_name!=null) 
		{
			list.Add(addFunc("Prd_user_name",model.Prd_user_name.ToString()));
		}

						if(model.Column_path!=null) 
		{
			list.Add(addFunc("Column_path",model.Column_path.ToString()));
		}

						if(model.Operation_name!=null) 
		{
			list.Add(addFunc("Operation_name",model.Operation_name.ToString()));
		}

						if(model.Operation_desc!=null) 
		{
			list.Add(addFunc("Operation_desc",model.Operation_desc.ToString()));
		}

						if(model.Exception_desc!=null) 
		{
			list.Add(addFunc("Exception_desc",model.Exception_desc.ToString()));
		}

						if(model.Event_level!=null) 
		{
			list.Add(addFunc("Event_level",model.Event_level.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_logToUserOperation model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_unique_id.ToString(),addFunc("[User_unique_id]")));
		}
					

						if(model.Prd_user_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_user_name.ToString(),addFunc("[Prd_user_name]")));
		}
					

						if(model.Column_path!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_path.ToString(),addFunc("[Column_path]")));
		}
					

						if(model.Operation_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Operation_name.ToString(),addFunc("[Operation_name]")));
		}
					

						if(model.Operation_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Operation_desc.ToString(),addFunc("[Operation_desc]")));
		}
					

						if(model.Exception_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception_desc.ToString(),addFunc("[Exception_desc]")));
		}
					

						if(model.Event_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Event_level.ToString(),addFunc("[Event_level]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_logToUserOperation)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_logToUserOperation)item[0];		
	var where=	(N4_logToUserOperation)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_logToUserOperation where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_logToUserOperation where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_logToUserOperation where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_logToUserOperation where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_logToUserOperation where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_PrivilegeModel_ColumnRepository : BaseRepository<N4_PrivilegeModel_Column>, IN4_PrivilegeModel_ColumnRepository
{
		public N4_PrivilegeModel_ColumnRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_PrivilegeModel_Column";
		} 
		public N4_PrivilegeModel_ColumnRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_PrivilegeModel_Column model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Column_name!=null) 
		{
			list.Add(addFunc("Column_name",model.Column_name.ToString()));
		}

						if(model.Column_text!=null) 
		{
			list.Add(addFunc("Column_text",model.Column_text.ToString()));
		}

						if(model.Module_name!=null) 
		{
			list.Add(addFunc("Module_name",model.Module_name.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_PrivilegeModel_Column model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Column_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_name.ToString(),addFunc("[Column_name]")));
		}
					

						if(model.Column_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_text.ToString(),addFunc("[Column_text]")));
		}
					

						if(model.Module_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_name.ToString(),addFunc("[Module_name]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModel_Column)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModel_Column)item[0];		
	var where=	(N4_PrivilegeModel_Column)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_PrivilegeModel_Column where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_PrivilegeModel_Column where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_PrivilegeModel_Column where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_PrivilegeModel_Column where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_PrivilegeModel_Column where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_PrivilegeModel_ModuleRepository : BaseRepository<N4_PrivilegeModel_Module>, IN4_PrivilegeModel_ModuleRepository
{
		public N4_PrivilegeModel_ModuleRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_PrivilegeModel_Module";
		} 
		public N4_PrivilegeModel_ModuleRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_PrivilegeModel_Module model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Module_name!=null) 
		{
			list.Add(addFunc("Module_name",model.Module_name.ToString()));
		}

						if(model.Module_text!=null) 
		{
			list.Add(addFunc("Module_text",model.Module_text.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_PrivilegeModel_Module model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Module_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_name.ToString(),addFunc("[Module_name]")));
		}
					

						if(model.Module_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_text.ToString(),addFunc("[Module_text]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModel_Module)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModel_Module)item[0];		
	var where=	(N4_PrivilegeModel_Module)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_PrivilegeModel_Module where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_PrivilegeModel_Module where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_PrivilegeModel_Module where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_PrivilegeModel_Module where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_PrivilegeModel_Module where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_PrivilegeModel_PrivilegeRepository : BaseRepository<N4_PrivilegeModel_Privilege>, IN4_PrivilegeModel_PrivilegeRepository
{
		public N4_PrivilegeModel_PrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_PrivilegeModel_Privilege";
		} 
		public N4_PrivilegeModel_PrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_PrivilegeModel_Privilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Privilege_item_code!=null) 
		{
			list.Add(addFunc("Privilege_item_code",model.Privilege_item_code.ToString()));
		}

						if(model.Privilege_item_text!=null) 
		{
			list.Add(addFunc("Privilege_item_text",model.Privilege_item_text.ToString()));
		}

						if(model.Column_name!=null) 
		{
			list.Add(addFunc("Column_name",model.Column_name.ToString()));
		}

						if(model.Module_name!=null) 
		{
			list.Add(addFunc("Module_name",model.Module_name.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_PrivilegeModel_Privilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Privilege_item_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_item_code.ToString(),addFunc("[Privilege_item_code]")));
		}
					

						if(model.Privilege_item_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_item_text.ToString(),addFunc("[Privilege_item_text]")));
		}
					

						if(model.Column_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_name.ToString(),addFunc("[Column_name]")));
		}
					

						if(model.Module_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_name.ToString(),addFunc("[Module_name]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModel_Privilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModel_Privilege)item[0];		
	var where=	(N4_PrivilegeModel_Privilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_PrivilegeModel_Privilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_PrivilegeModel_Privilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_PrivilegeModel_Privilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_PrivilegeModel_Privilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_PrivilegeModel_Privilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_PrivilegeModelByJSONRepository : BaseRepository<N4_PrivilegeModelByJSON>, IN4_PrivilegeModelByJSONRepository
{
		public N4_PrivilegeModelByJSONRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_PrivilegeModelByJSON";
		} 
		public N4_PrivilegeModelByJSONRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_PrivilegeModelByJSON model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Model_name!=null) 
		{
			list.Add(addFunc("Model_name",model.Model_name.ToString()));
		}

						if(model.Json_string!=null) 
		{
			list.Add(addFunc("Json_string",model.Json_string.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_PrivilegeModelByJSON model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Model_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Model_name.ToString(),addFunc("[Model_name]")));
		}
					

						if(model.Json_string!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Json_string.ToString(),addFunc("[Json_string]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModelByJSON)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeModelByJSON)item[0];		
	var where=	(N4_PrivilegeModelByJSON)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_PrivilegeModelByJSON where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_PrivilegeModelByJSON where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_PrivilegeModelByJSON where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_PrivilegeModelByJSON where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_PrivilegeModelByJSON where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_PrivilegeTagAndFunctionRepository : BaseRepository<N4_PrivilegeTagAndFunction>, IN4_PrivilegeTagAndFunctionRepository
{
		public N4_PrivilegeTagAndFunctionRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_PrivilegeTagAndFunction";
		} 
		public N4_PrivilegeTagAndFunctionRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_PrivilegeTagAndFunction model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Privilege_tag!=null) 
		{
			list.Add(addFunc("Privilege_tag",model.Privilege_tag.ToString()));
		}

						if(model.Function_name!=null) 
		{
			list.Add(addFunc("Function_name",model.Function_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_PrivilegeTagAndFunction model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Privilege_tag!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_tag.ToString(),addFunc("[Privilege_tag]")));
		}
					

						if(model.Function_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Function_name.ToString(),addFunc("[Function_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeTagAndFunction)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_PrivilegeTagAndFunction)item[0];		
	var where=	(N4_PrivilegeTagAndFunction)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_PrivilegeTagAndFunction where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_PrivilegeTagAndFunction where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_PrivilegeTagAndFunction where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_PrivilegeTagAndFunction where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_PrivilegeTagAndFunction where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_RolePrivilegeRepository : BaseRepository<N4_RolePrivilege>, IN4_RolePrivilegeRepository
{
		public N4_RolePrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_RolePrivilege";
		} 
		public N4_RolePrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_RolePrivilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Role_uniqueid!=null) 
		{
			list.Add(addFunc("Role_uniqueid",model.Role_uniqueid.ToString()));
		}

						if(model.Privilege_code!=null) 
		{
			list.Add(addFunc("Privilege_code",model.Privilege_code.ToString()));
		}

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(addFunc("Prd_privilege_text",model.Prd_privilege_text.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_RolePrivilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Role_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_uniqueid.ToString(),addFunc("[Role_uniqueid]")));
		}
					

						if(model.Privilege_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_code.ToString(),addFunc("[Privilege_code]")));
		}
					

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_privilege_text.ToString(),addFunc("[Prd_privilege_text]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_RolePrivilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_RolePrivilege)item[0];		
	var where=	(N4_RolePrivilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_RolePrivilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_RolePrivilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_RolePrivilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_RolePrivilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_RolePrivilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_SysDatOriManageModeSetRepository : BaseRepository<N4_SysDatOriManageModeSet>, IN4_SysDatOriManageModeSetRepository
{
		public N4_SysDatOriManageModeSetRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_SysDatOriManageModeSet";
		} 
		public N4_SysDatOriManageModeSetRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_SysDatOriManageModeSet model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.UniqueId!=null) 
		{
			list.Add(addFunc("UniqueId",model.UniqueId.ToString()));
		}

						if(model.Mode!=null) 
		{
			list.Add(addFunc("Mode",model.Mode.ToString()));
		}

						if(model.Value!=null) 
		{
			list.Add(addFunc("Value",model.Value.ToString()));
		}

						if(model.Remark!=null) 
		{
			list.Add(addFunc("Remark",model.Remark.ToString()));
		}

						if(model.DataStatus!=null) 
		{
			list.Add(addFunc("DataStatus",model.DataStatus.ToString()));
		}

						if(model.AbandonStatus!=null) 
		{
			list.Add(addFunc("AbandonStatus",model.AbandonStatus.ToString()));
		}

						if(model.Creator!=null) 
		{
			list.Add(addFunc("Creator",model.Creator.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_updater!=null) 
		{
			list.Add(addFunc("Last_updater",model.Last_updater.ToString()));
		}

						if(model.Last_update_time!=null) 
		{
			list.Add(addFunc("Last_update_time",model.Last_update_time.ToString()));
		}

						if(model.Approver!=null) 
		{
			list.Add(addFunc("Approver",model.Approver.ToString()));
		}

						if(model.Approve_time!=null) 
		{
			list.Add(addFunc("Approve_time",model.Approve_time.ToString()));
		}

						if(model.Abandoner!=null) 
		{
			list.Add(addFunc("Abandoner",model.Abandoner.ToString()));
		}

						if(model.Abandon_time!=null) 
		{
			list.Add(addFunc("Abandon_time",model.Abandon_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_SysDatOriManageModeSet model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.UniqueId!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.UniqueId.ToString(),addFunc("[UniqueId]")));
		}
					

						if(model.Mode!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Mode.ToString(),addFunc("[Mode]")));
		}
					

						if(model.Value!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Value.ToString(),addFunc("[Value]")));
		}
					

						if(model.Remark!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Remark.ToString(),addFunc("[Remark]")));
		}
					

						if(model.DataStatus!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.DataStatus.ToString(),addFunc("[DataStatus]")));
		}
					

						if(model.AbandonStatus!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.AbandonStatus.ToString(),addFunc("[AbandonStatus]")));
		}
					

						if(model.Creator!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator.ToString(),addFunc("[Creator]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_updater!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_updater.ToString(),addFunc("[Last_updater]")));
		}
					

						if(model.Last_update_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_update_time.ToString(),addFunc("[Last_update_time]")));
		}
					

						if(model.Approver!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver.ToString(),addFunc("[Approver]")));
		}
					

						if(model.Approve_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approve_time.ToString(),addFunc("[Approve_time]")));
		}
					

						if(model.Abandoner!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner.ToString(),addFunc("[Abandoner]")));
		}
					

						if(model.Abandon_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_time.ToString(),addFunc("[Abandon_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_SysDatOriManageModeSet)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_SysDatOriManageModeSet)item[0];		
	var where=	(N4_SysDatOriManageModeSet)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_SysDatOriManageModeSet where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_SysDatOriManageModeSet where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_SysDatOriManageModeSet where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_SysDatOriManageModeSet where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_SysDatOriManageModeSet where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_SysDatRoleRepository : BaseRepository<N4_SysDatRole>, IN4_SysDatRoleRepository
{
		public N4_SysDatRoleRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_SysDatRole";
		} 
		public N4_SysDatRoleRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_SysDatRole model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Unique_id!=null) 
		{
			list.Add(addFunc("Unique_id",model.Unique_id.ToString()));
		}

						if(model.FCode!=null) 
		{
			list.Add(addFunc("FCode",model.FCode.ToString()));
		}

						if(model.FName!=null) 
		{
			list.Add(addFunc("FName",model.FName.ToString()));
		}

						if(model.Dir!=null) 
		{
			list.Add(addFunc("Dir",model.Dir.ToString()));
		}

						if(model.Role_desc!=null) 
		{
			list.Add(addFunc("Role_desc",model.Role_desc.ToString()));
		}

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(addFunc("Creator_uniqueid",model.Creator_uniqueid.ToString()));
		}

						if(model.Creator_name!=null) 
		{
			list.Add(addFunc("Creator_name",model.Creator_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Updator_uniqueid!=null) 
		{
			list.Add(addFunc("Updator_uniqueid",model.Updator_uniqueid.ToString()));
		}

						if(model.Updator_name!=null) 
		{
			list.Add(addFunc("Updator_name",model.Updator_name.ToString()));
		}

						if(model.Update_time!=null) 
		{
			list.Add(addFunc("Update_time",model.Update_time.ToString()));
		}

						if(model.Submitter_uniqueid!=null) 
		{
			list.Add(addFunc("Submitter_uniqueid",model.Submitter_uniqueid.ToString()));
		}

						if(model.Submitter_name!=null) 
		{
			list.Add(addFunc("Submitter_name",model.Submitter_name.ToString()));
		}

						if(model.Submit_time!=null) 
		{
			list.Add(addFunc("Submit_time",model.Submit_time.ToString()));
		}

						if(model.Approver_uniqueid!=null) 
		{
			list.Add(addFunc("Approver_uniqueid",model.Approver_uniqueid.ToString()));
		}

						if(model.Approver_name!=null) 
		{
			list.Add(addFunc("Approver_name",model.Approver_name.ToString()));
		}

						if(model.Approver_time!=null) 
		{
			list.Add(addFunc("Approver_time",model.Approver_time.ToString()));
		}

						if(model.Abandoner_uniqueid!=null) 
		{
			list.Add(addFunc("Abandoner_uniqueid",model.Abandoner_uniqueid.ToString()));
		}

						if(model.Abandoner_name!=null) 
		{
			list.Add(addFunc("Abandoner_name",model.Abandoner_name.ToString()));
		}

						if(model.Abandon_time!=null) 
		{
			list.Add(addFunc("Abandon_time",model.Abandon_time.ToString()));
		}

						if(model.Data_status!=null) 
		{
			list.Add(addFunc("Data_status",model.Data_status.ToString()));
		}

						if(model.Abandon_status!=null) 
		{
			list.Add(addFunc("Abandon_status",model.Abandon_status.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_SysDatRole model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Unique_id.ToString(),addFunc("[Unique_id]")));
		}
					

						if(model.FCode!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.FCode.ToString(),addFunc("[FCode]")));
		}
					

						if(model.FName!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.FName.ToString(),addFunc("[FName]")));
		}
					

						if(model.Dir!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Dir.ToString(),addFunc("[Dir]")));
		}
					

						if(model.Role_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_desc.ToString(),addFunc("[Role_desc]")));
		}
					

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_uniqueid.ToString(),addFunc("[Creator_uniqueid]")));
		}
					

						if(model.Creator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_name.ToString(),addFunc("[Creator_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Updator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator_uniqueid.ToString(),addFunc("[Updator_uniqueid]")));
		}
					

						if(model.Updator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator_name.ToString(),addFunc("[Updator_name]")));
		}
					

						if(model.Update_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Update_time.ToString(),addFunc("[Update_time]")));
		}
					

						if(model.Submitter_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter_uniqueid.ToString(),addFunc("[Submitter_uniqueid]")));
		}
					

						if(model.Submitter_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter_name.ToString(),addFunc("[Submitter_name]")));
		}
					

						if(model.Submit_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submit_time.ToString(),addFunc("[Submit_time]")));
		}
					

						if(model.Approver_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_uniqueid.ToString(),addFunc("[Approver_uniqueid]")));
		}
					

						if(model.Approver_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_name.ToString(),addFunc("[Approver_name]")));
		}
					

						if(model.Approver_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_time.ToString(),addFunc("[Approver_time]")));
		}
					

						if(model.Abandoner_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_uniqueid.ToString(),addFunc("[Abandoner_uniqueid]")));
		}
					

						if(model.Abandoner_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_name.ToString(),addFunc("[Abandoner_name]")));
		}
					

						if(model.Abandon_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_time.ToString(),addFunc("[Abandon_time]")));
		}
					

						if(model.Data_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_status.ToString(),addFunc("[Data_status]")));
		}
					

						if(model.Abandon_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_status.ToString(),addFunc("[Abandon_status]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_SysDatRole)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_SysDatRole)item[0];		
	var where=	(N4_SysDatRole)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_SysDatRole where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_SysDatRole where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_SysDatRole where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_SysDatRole where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_SysDatRole where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_SysDatUserRepository : BaseRepository<N4_SysDatUser>, IN4_SysDatUserRepository
{
		public N4_SysDatUserRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_SysDatUser";
		} 
		public N4_SysDatUserRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_SysDatUser model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Uniqueid!=null) 
		{
			list.Add(addFunc("Uniqueid",model.Uniqueid.ToString()));
		}

						if(model.Login_name!=null) 
		{
			list.Add(addFunc("Login_name",model.Login_name.ToString()));
		}

						if(model.User_name!=null) 
		{
			list.Add(addFunc("User_name",model.User_name.ToString()));
		}

						if(model.Department_unique_id!=null) 
		{
			list.Add(addFunc("Department_unique_id",model.Department_unique_id.ToString()));
		}

						if(model.Prd_department_name!=null) 
		{
			list.Add(addFunc("Prd_department_name",model.Prd_department_name.ToString()));
		}

						if(model.Pwd!=null) 
		{
			list.Add(addFunc("Pwd",model.Pwd.ToString()));
		}

						if(model.ScanCode!=null) 
		{
			list.Add(addFunc("ScanCode",model.ScanCode.ToString()));
		}

						if(model.IsAllowLogin!=null) 
		{
			list.Add(addFunc("IsAllowLogin",model.IsAllowLogin.ToString()));
		}

						if(model.InValidTime!=null) 
		{
			list.Add(addFunc("InValidTime",model.InValidTime.ToString()));
		}

						if(model.IsEmployee!=null) 
		{
			list.Add(addFunc("IsEmployee",model.IsEmployee.ToString()));
		}

						if(model.DataStatus!=null) 
		{
			list.Add(addFunc("DataStatus",model.DataStatus.ToString()));
		}

						if(model.AbandonStatus!=null) 
		{
			list.Add(addFunc("AbandonStatus",model.AbandonStatus.ToString()));
		}

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(addFunc("Creator_uniqueid",model.Creator_uniqueid.ToString()));
		}

						if(model.Prd_creator_name!=null) 
		{
			list.Add(addFunc("Prd_creator_name",model.Prd_creator_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_updater_unique_id!=null) 
		{
			list.Add(addFunc("Last_updater_unique_id",model.Last_updater_unique_id.ToString()));
		}

						if(model.Last_updater_name!=null) 
		{
			list.Add(addFunc("Last_updater_name",model.Last_updater_name.ToString()));
		}

						if(model.Last_update_time!=null) 
		{
			list.Add(addFunc("Last_update_time",model.Last_update_time.ToString()));
		}

						if(model.Approver_unique_id!=null) 
		{
			list.Add(addFunc("Approver_unique_id",model.Approver_unique_id.ToString()));
		}

						if(model.Approver_name!=null) 
		{
			list.Add(addFunc("Approver_name",model.Approver_name.ToString()));
		}

						if(model.Approve_time!=null) 
		{
			list.Add(addFunc("Approve_time",model.Approve_time.ToString()));
		}

						if(model.Abandoner_unique_id!=null) 
		{
			list.Add(addFunc("Abandoner_unique_id",model.Abandoner_unique_id.ToString()));
		}

						if(model.Abandoner_name!=null) 
		{
			list.Add(addFunc("Abandoner_name",model.Abandoner_name.ToString()));
		}

						if(model.Abandon_time!=null) 
		{
			list.Add(addFunc("Abandon_time",model.Abandon_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_SysDatUser model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Uniqueid.ToString(),addFunc("[Uniqueid]")));
		}
					

						if(model.Login_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Login_name.ToString(),addFunc("[Login_name]")));
		}
					

						if(model.User_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_name.ToString(),addFunc("[User_name]")));
		}
					

						if(model.Department_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Department_unique_id.ToString(),addFunc("[Department_unique_id]")));
		}
					

						if(model.Prd_department_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_department_name.ToString(),addFunc("[Prd_department_name]")));
		}
					

						if(model.Pwd!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Pwd.ToString(),addFunc("[Pwd]")));
		}
					

						if(model.ScanCode!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.ScanCode.ToString(),addFunc("[ScanCode]")));
		}
					

						if(model.IsAllowLogin!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.IsAllowLogin.ToString(),addFunc("[IsAllowLogin]")));
		}
					

						if(model.InValidTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.InValidTime.ToString(),addFunc("[InValidTime]")));
		}
					

						if(model.IsEmployee!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.IsEmployee.ToString(),addFunc("[IsEmployee]")));
		}
					

						if(model.DataStatus!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.DataStatus.ToString(),addFunc("[DataStatus]")));
		}
					

						if(model.AbandonStatus!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.AbandonStatus.ToString(),addFunc("[AbandonStatus]")));
		}
					

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_uniqueid.ToString(),addFunc("[Creator_uniqueid]")));
		}
					

						if(model.Prd_creator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_creator_name.ToString(),addFunc("[Prd_creator_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_updater_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_updater_unique_id.ToString(),addFunc("[Last_updater_unique_id]")));
		}
					

						if(model.Last_updater_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_updater_name.ToString(),addFunc("[Last_updater_name]")));
		}
					

						if(model.Last_update_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_update_time.ToString(),addFunc("[Last_update_time]")));
		}
					

						if(model.Approver_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_unique_id.ToString(),addFunc("[Approver_unique_id]")));
		}
					

						if(model.Approver_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_name.ToString(),addFunc("[Approver_name]")));
		}
					

						if(model.Approve_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approve_time.ToString(),addFunc("[Approve_time]")));
		}
					

						if(model.Abandoner_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_unique_id.ToString(),addFunc("[Abandoner_unique_id]")));
		}
					

						if(model.Abandoner_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_name.ToString(),addFunc("[Abandoner_name]")));
		}
					

						if(model.Abandon_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_time.ToString(),addFunc("[Abandon_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_SysDatUser)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_SysDatUser)item[0];		
	var where=	(N4_SysDatUser)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_SysDatUser where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_SysDatUser where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_SysDatUser where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_SysDatUser where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_SysDatUser where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_UserPrivilegeRepository : BaseRepository<N4_UserPrivilege>, IN4_UserPrivilegeRepository
{
		public N4_UserPrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_UserPrivilege";
		} 
		public N4_UserPrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_UserPrivilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_uniqueid!=null) 
		{
			list.Add(addFunc("User_uniqueid",model.User_uniqueid.ToString()));
		}

						if(model.Privilege_code!=null) 
		{
			list.Add(addFunc("Privilege_code",model.Privilege_code.ToString()));
		}

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(addFunc("Prd_privilege_text",model.Prd_privilege_text.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_UserPrivilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_uniqueid.ToString(),addFunc("[User_uniqueid]")));
		}
					

						if(model.Privilege_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_code.ToString(),addFunc("[Privilege_code]")));
		}
					

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_privilege_text.ToString(),addFunc("[Prd_privilege_text]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_UserPrivilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_UserPrivilege)item[0];		
	var where=	(N4_UserPrivilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_UserPrivilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_UserPrivilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_UserPrivilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_UserPrivilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_UserPrivilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class N4_UserRoleAndDepartRepository : BaseRepository<N4_UserRoleAndDepart>, IN4_UserRoleAndDepartRepository
{
		public N4_UserRoleAndDepartRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="N4_UserRoleAndDepart";
		} 
		public N4_UserRoleAndDepartRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(N4_UserRoleAndDepart model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_uniqueid!=null) 
		{
			list.Add(addFunc("User_uniqueid",model.User_uniqueid.ToString()));
		}

						if(model.Role_uniqueid!=null) 
		{
			list.Add(addFunc("Role_uniqueid",model.Role_uniqueid.ToString()));
		}

						if(model.Depart_uniqueid!=null) 
		{
			list.Add(addFunc("Depart_uniqueid",model.Depart_uniqueid.ToString()));
		}

						if(model.InvalidTime!=null) 
		{
			list.Add(addFunc("InvalidTime",model.InvalidTime.ToString()));
		}

						if(model.Factory!=null) 
		{
			list.Add(addFunc("Factory",model.Factory.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(N4_UserRoleAndDepart model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_uniqueid.ToString(),addFunc("[User_uniqueid]")));
		}
					

						if(model.Role_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_uniqueid.ToString(),addFunc("[Role_uniqueid]")));
		}
					

						if(model.Depart_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Depart_uniqueid.ToString(),addFunc("[Depart_uniqueid]")));
		}
					

						if(model.InvalidTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.InvalidTime.ToString(),addFunc("[InvalidTime]")));
		}
					

						if(model.Factory!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Factory.ToString(),addFunc("[Factory]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(N4_UserRoleAndDepart)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(N4_UserRoleAndDepart)item[0];		
	var where=	(N4_UserRoleAndDepart)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(N4_UserRoleAndDepart where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, N4_UserRoleAndDepart where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(N4_UserRoleAndDepart where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, N4_UserRoleAndDepart where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, N4_UserRoleAndDepart where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_DataPrivilege_ofRoleRepository : BaseRepository<tmp_N4_DataPrivilege_ofRole>, Itmp_N4_DataPrivilege_ofRoleRepository
{
		public tmp_N4_DataPrivilege_ofRoleRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_DataPrivilege_ofRole";
		} 
		public tmp_N4_DataPrivilege_ofRoleRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_DataPrivilege_ofRole model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Role_uniqueid!=null) 
		{
			list.Add(addFunc("Role_uniqueid",model.Role_uniqueid.ToString()));
		}

						if(model.Prd_role_name!=null) 
		{
			list.Add(addFunc("Prd_role_name",model.Prd_role_name.ToString()));
		}

						if(model.Data_view_id!=null) 
		{
			list.Add(addFunc("Data_view_id",model.Data_view_id.ToString()));
		}

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(addFunc("Prd_data_view_name",model.Prd_data_view_name.ToString()));
		}

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(addFunc("Prd_data_view_code",model.Prd_data_view_code.ToString()));
		}

						if(model.Authorize_columns!=null) 
		{
			list.Add(addFunc("Authorize_columns",model.Authorize_columns.ToString()));
		}

						if(model.Authorize_desc!=null) 
		{
			list.Add(addFunc("Authorize_desc",model.Authorize_desc.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_DataPrivilege_ofRole model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Role_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_uniqueid.ToString(),addFunc("[Role_uniqueid]")));
		}
					

						if(model.Prd_role_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_role_name.ToString(),addFunc("[Prd_role_name]")));
		}
					

						if(model.Data_view_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_id.ToString(),addFunc("[Data_view_id]")));
		}
					

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_name.ToString(),addFunc("[Prd_data_view_name]")));
		}
					

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_code.ToString(),addFunc("[Prd_data_view_code]")));
		}
					

						if(model.Authorize_columns!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_columns.ToString(),addFunc("[Authorize_columns]")));
		}
					

						if(model.Authorize_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_desc.ToString(),addFunc("[Authorize_desc]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_DataPrivilege_ofRole)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_DataPrivilege_ofRole)item[0];		
	var where=	(tmp_N4_DataPrivilege_ofRole)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_DataPrivilege_ofRole where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_DataPrivilege_ofRole where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_DataPrivilege_ofRole where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_DataPrivilege_ofRole where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_DataPrivilege_ofRole where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_DataPrivilege_ofUserRepository : BaseRepository<tmp_N4_DataPrivilege_ofUser>, Itmp_N4_DataPrivilege_ofUserRepository
{
		public tmp_N4_DataPrivilege_ofUserRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_DataPrivilege_ofUser";
		} 
		public tmp_N4_DataPrivilege_ofUserRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_DataPrivilege_ofUser model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_uniqueid!=null) 
		{
			list.Add(addFunc("User_uniqueid",model.User_uniqueid.ToString()));
		}

						if(model.Prd_user_name!=null) 
		{
			list.Add(addFunc("Prd_user_name",model.Prd_user_name.ToString()));
		}

						if(model.Data_view_id!=null) 
		{
			list.Add(addFunc("Data_view_id",model.Data_view_id.ToString()));
		}

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(addFunc("Prd_data_view_name",model.Prd_data_view_name.ToString()));
		}

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(addFunc("Prd_data_view_code",model.Prd_data_view_code.ToString()));
		}

						if(model.Authorize_columns!=null) 
		{
			list.Add(addFunc("Authorize_columns",model.Authorize_columns.ToString()));
		}

						if(model.Authorize_desc!=null) 
		{
			list.Add(addFunc("Authorize_desc",model.Authorize_desc.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_DataPrivilege_ofUser model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_uniqueid.ToString(),addFunc("[User_uniqueid]")));
		}
					

						if(model.Prd_user_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_user_name.ToString(),addFunc("[Prd_user_name]")));
		}
					

						if(model.Data_view_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_id.ToString(),addFunc("[Data_view_id]")));
		}
					

						if(model.Prd_data_view_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_name.ToString(),addFunc("[Prd_data_view_name]")));
		}
					

						if(model.Prd_data_view_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_data_view_code.ToString(),addFunc("[Prd_data_view_code]")));
		}
					

						if(model.Authorize_columns!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_columns.ToString(),addFunc("[Authorize_columns]")));
		}
					

						if(model.Authorize_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Authorize_desc.ToString(),addFunc("[Authorize_desc]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_DataPrivilege_ofUser)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_DataPrivilege_ofUser)item[0];		
	var where=	(tmp_N4_DataPrivilege_ofUser)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_DataPrivilege_ofUser where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_DataPrivilege_ofUser where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_DataPrivilege_ofUser where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_DataPrivilege_ofUser where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_DataPrivilege_ofUser where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_DataPrivilege_TempleteRepository : BaseRepository<tmp_N4_DataPrivilege_Templete>, Itmp_N4_DataPrivilege_TempleteRepository
{
		public tmp_N4_DataPrivilege_TempleteRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_DataPrivilege_Templete";
		} 
		public tmp_N4_DataPrivilege_TempleteRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_DataPrivilege_Templete model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Data_view_name!=null) 
		{
			list.Add(addFunc("Data_view_name",model.Data_view_name.ToString()));
		}

						if(model.Data_view_code!=null) 
		{
			list.Add(addFunc("Data_view_code",model.Data_view_code.ToString()));
		}

						if(model.Columns_of_view!=null) 
		{
			list.Add(addFunc("Columns_of_view",model.Columns_of_view.ToString()));
		}

						if(model.Description_of_view!=null) 
		{
			list.Add(addFunc("Description_of_view",model.Description_of_view.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_DataPrivilege_Templete model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Data_view_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_name.ToString(),addFunc("[Data_view_name]")));
		}
					

						if(model.Data_view_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_view_code.ToString(),addFunc("[Data_view_code]")));
		}
					

						if(model.Columns_of_view!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Columns_of_view.ToString(),addFunc("[Columns_of_view]")));
		}
					

						if(model.Description_of_view!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description_of_view.ToString(),addFunc("[Description_of_view]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_DataPrivilege_Templete)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_DataPrivilege_Templete)item[0];		
	var where=	(tmp_N4_DataPrivilege_Templete)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_DataPrivilege_Templete where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_DataPrivilege_Templete where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_DataPrivilege_Templete where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_DataPrivilege_Templete where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_DataPrivilege_Templete where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_DepartmentRepository : BaseRepository<tmp_N4_Department>, Itmp_N4_DepartmentRepository
{
		public tmp_N4_DepartmentRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_Department";
		} 
		public tmp_N4_DepartmentRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_Department model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Organization_uniqueid!=null) 
		{
			list.Add(addFunc("Organization_uniqueid",model.Organization_uniqueid.ToString()));
		}

						if(model.Organization_code!=null) 
		{
			list.Add(addFunc("Organization_code",model.Organization_code.ToString()));
		}

						if(model.Name!=null) 
		{
			list.Add(addFunc("Name",model.Name.ToString()));
		}

						if(model.Brief_name!=null) 
		{
			list.Add(addFunc("Brief_name",model.Brief_name.ToString()));
		}

						if(model.Description!=null) 
		{
			list.Add(addFunc("Description",model.Description.ToString()));
		}

						if(model.Mnemonic_code!=null) 
		{
			list.Add(addFunc("Mnemonic_code",model.Mnemonic_code.ToString()));
		}

						if(model.Manager_uniqueid!=null) 
		{
			list.Add(addFunc("Manager_uniqueid",model.Manager_uniqueid.ToString()));
		}

						if(model.Prd_manager_name!=null) 
		{
			list.Add(addFunc("Prd_manager_name",model.Prd_manager_name.ToString()));
		}

						if(model.Parent_organization_uniqueid!=null) 
		{
			list.Add(addFunc("Parent_organization_uniqueid",model.Parent_organization_uniqueid.ToString()));
		}

						if(model.Parent_organization_name!=null) 
		{
			list.Add(addFunc("Parent_organization_name",model.Parent_organization_name.ToString()));
		}

						if(model.Remark!=null) 
		{
			list.Add(addFunc("Remark",model.Remark.ToString()));
		}

						if(model.Data_status!=null) 
		{
			list.Add(addFunc("Data_status",model.Data_status.ToString()));
		}

						if(model.Abandon_status!=null) 
		{
			list.Add(addFunc("Abandon_status",model.Abandon_status.ToString()));
		}

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(addFunc("Creator_uniqueid",model.Creator_uniqueid.ToString()));
		}

						if(model.Prd_creator_name!=null) 
		{
			list.Add(addFunc("Prd_creator_name",model.Prd_creator_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Updator!=null) 
		{
			list.Add(addFunc("Updator",model.Updator.ToString()));
		}

						if(model.Update_time!=null) 
		{
			list.Add(addFunc("Update_time",model.Update_time.ToString()));
		}

						if(model.Submitter!=null) 
		{
			list.Add(addFunc("Submitter",model.Submitter.ToString()));
		}

						if(model.Submit_time!=null) 
		{
			list.Add(addFunc("Submit_time",model.Submit_time.ToString()));
		}

						if(model.Approver!=null) 
		{
			list.Add(addFunc("Approver",model.Approver.ToString()));
		}

						if(model.Approve_time!=null) 
		{
			list.Add(addFunc("Approve_time",model.Approve_time.ToString()));
		}

						if(model.Abandoner!=null) 
		{
			list.Add(addFunc("Abandoner",model.Abandoner.ToString()));
		}

						if(model.Abandon_time!=null) 
		{
			list.Add(addFunc("Abandon_time",model.Abandon_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_Department model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Organization_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Organization_uniqueid.ToString(),addFunc("[Organization_uniqueid]")));
		}
					

						if(model.Organization_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Organization_code.ToString(),addFunc("[Organization_code]")));
		}
					

						if(model.Name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Name.ToString(),addFunc("[Name]")));
		}
					

						if(model.Brief_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Brief_name.ToString(),addFunc("[Brief_name]")));
		}
					

						if(model.Description!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description.ToString(),addFunc("[Description]")));
		}
					

						if(model.Mnemonic_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Mnemonic_code.ToString(),addFunc("[Mnemonic_code]")));
		}
					

						if(model.Manager_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Manager_uniqueid.ToString(),addFunc("[Manager_uniqueid]")));
		}
					

						if(model.Prd_manager_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_manager_name.ToString(),addFunc("[Prd_manager_name]")));
		}
					

						if(model.Parent_organization_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Parent_organization_uniqueid.ToString(),addFunc("[Parent_organization_uniqueid]")));
		}
					

						if(model.Parent_organization_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Parent_organization_name.ToString(),addFunc("[Parent_organization_name]")));
		}
					

						if(model.Remark!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Remark.ToString(),addFunc("[Remark]")));
		}
					

						if(model.Data_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_status.ToString(),addFunc("[Data_status]")));
		}
					

						if(model.Abandon_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_status.ToString(),addFunc("[Abandon_status]")));
		}
					

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_uniqueid.ToString(),addFunc("[Creator_uniqueid]")));
		}
					

						if(model.Prd_creator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_creator_name.ToString(),addFunc("[Prd_creator_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Updator!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator.ToString(),addFunc("[Updator]")));
		}
					

						if(model.Update_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Update_time.ToString(),addFunc("[Update_time]")));
		}
					

						if(model.Submitter!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter.ToString(),addFunc("[Submitter]")));
		}
					

						if(model.Submit_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submit_time.ToString(),addFunc("[Submit_time]")));
		}
					

						if(model.Approver!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver.ToString(),addFunc("[Approver]")));
		}
					

						if(model.Approve_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approve_time.ToString(),addFunc("[Approve_time]")));
		}
					

						if(model.Abandoner!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner.ToString(),addFunc("[Abandoner]")));
		}
					

						if(model.Abandon_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_time.ToString(),addFunc("[Abandon_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_Department)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_Department)item[0];		
	var where=	(tmp_N4_Department)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_Department where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_Department where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_Department where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_Department where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_Department where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_DepartmentPrivilegeRepository : BaseRepository<tmp_N4_DepartmentPrivilege>, Itmp_N4_DepartmentPrivilegeRepository
{
		public tmp_N4_DepartmentPrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_DepartmentPrivilege";
		} 
		public tmp_N4_DepartmentPrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_DepartmentPrivilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Department_uniqueid!=null) 
		{
			list.Add(addFunc("Department_uniqueid",model.Department_uniqueid.ToString()));
		}

						if(model.Privilege_code!=null) 
		{
			list.Add(addFunc("Privilege_code",model.Privilege_code.ToString()));
		}

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(addFunc("Prd_privilege_text",model.Prd_privilege_text.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_DepartmentPrivilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Department_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Department_uniqueid.ToString(),addFunc("[Department_uniqueid]")));
		}
					

						if(model.Privilege_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_code.ToString(),addFunc("[Privilege_code]")));
		}
					

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_privilege_text.ToString(),addFunc("[Prd_privilege_text]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_DepartmentPrivilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_DepartmentPrivilege)item[0];		
	var where=	(tmp_N4_DepartmentPrivilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_DepartmentPrivilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_DepartmentPrivilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_DepartmentPrivilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_DepartmentPrivilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_DepartmentPrivilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_LogRepository : BaseRepository<tmp_N4_Log>, Itmp_N4_LogRepository
{
		public tmp_N4_LogRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_Log";
		} 
		public tmp_N4_LogRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_Log model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Log_date!=null) 
		{
			list.Add(addFunc("Log_date",model.Log_date.ToString()));
		}

						if(model.Log_tag!=null) 
		{
			list.Add(addFunc("Log_tag",model.Log_tag.ToString()));
		}

						if(model.Thread!=null) 
		{
			list.Add(addFunc("Thread",model.Thread.ToString()));
		}

						if(model.Log_level!=null) 
		{
			list.Add(addFunc("Log_level",model.Log_level.ToString()));
		}

						if(model.Logger!=null) 
		{
			list.Add(addFunc("Logger",model.Logger.ToString()));
		}

						if(model.Message!=null) 
		{
			list.Add(addFunc("Message",model.Message.ToString()));
		}

						if(model.Exception!=null) 
		{
			list.Add(addFunc("Exception",model.Exception.ToString()));
		}

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(addFunc("Entity_scheme_name",model.Entity_scheme_name.ToString()));
		}

						if(model.Entity_id!=null) 
		{
			list.Add(addFunc("Entity_id",model.Entity_id.ToString()));
		}

						if(model.String_for_old_entity!=null) 
		{
			list.Add(addFunc("String_for_old_entity",model.String_for_old_entity.ToString()));
		}

						if(model.String_for_new_entity!=null) 
		{
			list.Add(addFunc("String_for_new_entity",model.String_for_new_entity.ToString()));
		}

						if(model.Description!=null) 
		{
			list.Add(addFunc("Description",model.Description.ToString()));
		}

						if(model.Fan_class_name!=null) 
		{
			list.Add(addFunc("Fan_class_name",model.Fan_class_name.ToString()));
		}

						if(model.Fan_function_in_code!=null) 
		{
			list.Add(addFunc("Fan_function_in_code",model.Fan_function_in_code.ToString()));
		}

						if(model.Device_info!=null) 
		{
			list.Add(addFunc("Device_info",model.Device_info.ToString()));
		}

						if(model.Userid!=null) 
		{
			list.Add(addFunc("Userid",model.Userid.ToString()));
		}

						if(model.Ip_addr!=null) 
		{
			list.Add(addFunc("Ip_addr",model.Ip_addr.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_Log model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Log_date!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_date.ToString(),addFunc("[Log_date]")));
		}
					

						if(model.Log_tag!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_tag.ToString(),addFunc("[Log_tag]")));
		}
					

						if(model.Thread!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Thread.ToString(),addFunc("[Thread]")));
		}
					

						if(model.Log_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Log_level.ToString(),addFunc("[Log_level]")));
		}
					

						if(model.Logger!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Logger.ToString(),addFunc("[Logger]")));
		}
					

						if(model.Message!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Message.ToString(),addFunc("[Message]")));
		}
					

						if(model.Exception!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception.ToString(),addFunc("[Exception]")));
		}
					

						if(model.Entity_scheme_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_scheme_name.ToString(),addFunc("[Entity_scheme_name]")));
		}
					

						if(model.Entity_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Entity_id.ToString(),addFunc("[Entity_id]")));
		}
					

						if(model.String_for_old_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_old_entity.ToString(),addFunc("[String_for_old_entity]")));
		}
					

						if(model.String_for_new_entity!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.String_for_new_entity.ToString(),addFunc("[String_for_new_entity]")));
		}
					

						if(model.Description!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Description.ToString(),addFunc("[Description]")));
		}
					

						if(model.Fan_class_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Fan_class_name.ToString(),addFunc("[Fan_class_name]")));
		}
					

						if(model.Fan_function_in_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Fan_function_in_code.ToString(),addFunc("[Fan_function_in_code]")));
		}
					

						if(model.Device_info!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Device_info.ToString(),addFunc("[Device_info]")));
		}
					

						if(model.Userid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Userid.ToString(),addFunc("[Userid]")));
		}
					

						if(model.Ip_addr!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Ip_addr.ToString(),addFunc("[Ip_addr]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_Log)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_Log)item[0];		
	var where=	(tmp_N4_Log)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_Log where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_Log where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_Log where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_Log where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_Log where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_logToUserLoginoutRepository : BaseRepository<tmp_N4_logToUserLoginout>, Itmp_N4_logToUserLoginoutRepository
{
		public tmp_N4_logToUserLoginoutRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_logToUserLoginout";
		} 
		public tmp_N4_logToUserLoginoutRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_logToUserLoginout model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_unique_id!=null) 
		{
			list.Add(addFunc("User_unique_id",model.User_unique_id.ToString()));
		}

						if(model.Prd_user_name!=null) 
		{
			list.Add(addFunc("Prd_user_name",model.Prd_user_name.ToString()));
		}

						if(model.Token!=null) 
		{
			list.Add(addFunc("Token",model.Token.ToString()));
		}

						if(model.Login_time!=null) 
		{
			list.Add(addFunc("Login_time",model.Login_time.ToString()));
		}

						if(model.Login_type!=null) 
		{
			list.Add(addFunc("Login_type",model.Login_type.ToString()));
		}

						if(model.Device_info!=null) 
		{
			list.Add(addFunc("Device_info",model.Device_info.ToString()));
		}

						if(model.Event_level!=null) 
		{
			list.Add(addFunc("Event_level",model.Event_level.ToString()));
		}

						if(model.Exception_desc!=null) 
		{
			list.Add(addFunc("Exception_desc",model.Exception_desc.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_logToUserLoginout model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_unique_id.ToString(),addFunc("[User_unique_id]")));
		}
					

						if(model.Prd_user_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_user_name.ToString(),addFunc("[Prd_user_name]")));
		}
					

						if(model.Token!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Token.ToString(),addFunc("[Token]")));
		}
					

						if(model.Login_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Login_time.ToString(),addFunc("[Login_time]")));
		}
					

						if(model.Login_type!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Login_type.ToString(),addFunc("[Login_type]")));
		}
					

						if(model.Device_info!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Device_info.ToString(),addFunc("[Device_info]")));
		}
					

						if(model.Event_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Event_level.ToString(),addFunc("[Event_level]")));
		}
					

						if(model.Exception_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception_desc.ToString(),addFunc("[Exception_desc]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_logToUserLoginout)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_logToUserLoginout)item[0];		
	var where=	(tmp_N4_logToUserLoginout)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_logToUserLoginout where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_logToUserLoginout where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_logToUserLoginout where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_logToUserLoginout where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_logToUserLoginout where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_logToUserOperationRepository : BaseRepository<tmp_N4_logToUserOperation>, Itmp_N4_logToUserOperationRepository
{
		public tmp_N4_logToUserOperationRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_logToUserOperation";
		} 
		public tmp_N4_logToUserOperationRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_logToUserOperation model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_unique_id!=null) 
		{
			list.Add(addFunc("User_unique_id",model.User_unique_id.ToString()));
		}

						if(model.Prd_user_name!=null) 
		{
			list.Add(addFunc("Prd_user_name",model.Prd_user_name.ToString()));
		}

						if(model.Column_path!=null) 
		{
			list.Add(addFunc("Column_path",model.Column_path.ToString()));
		}

						if(model.Login_token!=null) 
		{
			list.Add(addFunc("Login_token",model.Login_token.ToString()));
		}

						if(model.Operation_desc!=null) 
		{
			list.Add(addFunc("Operation_desc",model.Operation_desc.ToString()));
		}

						if(model.Exception_desc!=null) 
		{
			list.Add(addFunc("Exception_desc",model.Exception_desc.ToString()));
		}

						if(model.Event_level!=null) 
		{
			list.Add(addFunc("Event_level",model.Event_level.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_logToUserOperation model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_unique_id.ToString(),addFunc("[User_unique_id]")));
		}
					

						if(model.Prd_user_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_user_name.ToString(),addFunc("[Prd_user_name]")));
		}
					

						if(model.Column_path!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_path.ToString(),addFunc("[Column_path]")));
		}
					

						if(model.Login_token!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Login_token.ToString(),addFunc("[Login_token]")));
		}
					

						if(model.Operation_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Operation_desc.ToString(),addFunc("[Operation_desc]")));
		}
					

						if(model.Exception_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Exception_desc.ToString(),addFunc("[Exception_desc]")));
		}
					

						if(model.Event_level!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Event_level.ToString(),addFunc("[Event_level]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_logToUserOperation)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_logToUserOperation)item[0];		
	var where=	(tmp_N4_logToUserOperation)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_logToUserOperation where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_logToUserOperation where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_logToUserOperation where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_logToUserOperation where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_logToUserOperation where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_PrivilegeModel_ColumnRepository : BaseRepository<tmp_N4_PrivilegeModel_Column>, Itmp_N4_PrivilegeModel_ColumnRepository
{
		public tmp_N4_PrivilegeModel_ColumnRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_PrivilegeModel_Column";
		} 
		public tmp_N4_PrivilegeModel_ColumnRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_PrivilegeModel_Column model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Column_name!=null) 
		{
			list.Add(addFunc("Column_name",model.Column_name.ToString()));
		}

						if(model.Column_text!=null) 
		{
			list.Add(addFunc("Column_text",model.Column_text.ToString()));
		}

						if(model.Module_name!=null) 
		{
			list.Add(addFunc("Module_name",model.Module_name.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_PrivilegeModel_Column model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Column_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_name.ToString(),addFunc("[Column_name]")));
		}
					

						if(model.Column_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_text.ToString(),addFunc("[Column_text]")));
		}
					

						if(model.Module_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_name.ToString(),addFunc("[Module_name]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModel_Column)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModel_Column)item[0];		
	var where=	(tmp_N4_PrivilegeModel_Column)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_PrivilegeModel_Column where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_PrivilegeModel_Column where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_PrivilegeModel_Column where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_PrivilegeModel_Column where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_PrivilegeModel_Column where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_PrivilegeModel_ModuleRepository : BaseRepository<tmp_N4_PrivilegeModel_Module>, Itmp_N4_PrivilegeModel_ModuleRepository
{
		public tmp_N4_PrivilegeModel_ModuleRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_PrivilegeModel_Module";
		} 
		public tmp_N4_PrivilegeModel_ModuleRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_PrivilegeModel_Module model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Module_name!=null) 
		{
			list.Add(addFunc("Module_name",model.Module_name.ToString()));
		}

						if(model.Module_text!=null) 
		{
			list.Add(addFunc("Module_text",model.Module_text.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_PrivilegeModel_Module model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Module_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_name.ToString(),addFunc("[Module_name]")));
		}
					

						if(model.Module_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_text.ToString(),addFunc("[Module_text]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModel_Module)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModel_Module)item[0];		
	var where=	(tmp_N4_PrivilegeModel_Module)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_PrivilegeModel_Module where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_PrivilegeModel_Module where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_PrivilegeModel_Module where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_PrivilegeModel_Module where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_PrivilegeModel_Module where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_PrivilegeModel_PrivilegeRepository : BaseRepository<tmp_N4_PrivilegeModel_Privilege>, Itmp_N4_PrivilegeModel_PrivilegeRepository
{
		public tmp_N4_PrivilegeModel_PrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_PrivilegeModel_Privilege";
		} 
		public tmp_N4_PrivilegeModel_PrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_PrivilegeModel_Privilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Privilege_item_code!=null) 
		{
			list.Add(addFunc("Privilege_item_code",model.Privilege_item_code.ToString()));
		}

						if(model.Privilege_item_text!=null) 
		{
			list.Add(addFunc("Privilege_item_text",model.Privilege_item_text.ToString()));
		}

						if(model.Column_name!=null) 
		{
			list.Add(addFunc("Column_name",model.Column_name.ToString()));
		}

						if(model.Module_name!=null) 
		{
			list.Add(addFunc("Module_name",model.Module_name.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_PrivilegeModel_Privilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Privilege_item_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_item_code.ToString(),addFunc("[Privilege_item_code]")));
		}
					

						if(model.Privilege_item_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_item_text.ToString(),addFunc("[Privilege_item_text]")));
		}
					

						if(model.Column_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Column_name.ToString(),addFunc("[Column_name]")));
		}
					

						if(model.Module_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Module_name.ToString(),addFunc("[Module_name]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModel_Privilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModel_Privilege)item[0];		
	var where=	(tmp_N4_PrivilegeModel_Privilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_PrivilegeModel_Privilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_PrivilegeModel_Privilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_PrivilegeModel_Privilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_PrivilegeModel_Privilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_PrivilegeModel_Privilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_PrivilegeModelByJSONRepository : BaseRepository<tmp_N4_PrivilegeModelByJSON>, Itmp_N4_PrivilegeModelByJSONRepository
{
		public tmp_N4_PrivilegeModelByJSONRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_PrivilegeModelByJSON";
		} 
		public tmp_N4_PrivilegeModelByJSONRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_PrivilegeModelByJSON model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Model_name!=null) 
		{
			list.Add(addFunc("Model_name",model.Model_name.ToString()));
		}

						if(model.Json_string!=null) 
		{
			list.Add(addFunc("Json_string",model.Json_string.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_PrivilegeModelByJSON model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Model_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Model_name.ToString(),addFunc("[Model_name]")));
		}
					

						if(model.Json_string!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Json_string.ToString(),addFunc("[Json_string]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModelByJSON)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeModelByJSON)item[0];		
	var where=	(tmp_N4_PrivilegeModelByJSON)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_PrivilegeModelByJSON where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_PrivilegeModelByJSON where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_PrivilegeModelByJSON where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_PrivilegeModelByJSON where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_PrivilegeModelByJSON where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_PrivilegeTagAndFunctionRepository : BaseRepository<tmp_N4_PrivilegeTagAndFunction>, Itmp_N4_PrivilegeTagAndFunctionRepository
{
		public tmp_N4_PrivilegeTagAndFunctionRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_PrivilegeTagAndFunction";
		} 
		public tmp_N4_PrivilegeTagAndFunctionRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_PrivilegeTagAndFunction model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Privilege_tag!=null) 
		{
			list.Add(addFunc("Privilege_tag",model.Privilege_tag.ToString()));
		}

						if(model.Function_name!=null) 
		{
			list.Add(addFunc("Function_name",model.Function_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_PrivilegeTagAndFunction model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Privilege_tag!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_tag.ToString(),addFunc("[Privilege_tag]")));
		}
					

						if(model.Function_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Function_name.ToString(),addFunc("[Function_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeTagAndFunction)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_PrivilegeTagAndFunction)item[0];		
	var where=	(tmp_N4_PrivilegeTagAndFunction)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_PrivilegeTagAndFunction where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_PrivilegeTagAndFunction where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_PrivilegeTagAndFunction where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_PrivilegeTagAndFunction where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_PrivilegeTagAndFunction where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_RolePrivilegeRepository : BaseRepository<tmp_N4_RolePrivilege>, Itmp_N4_RolePrivilegeRepository
{
		public tmp_N4_RolePrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_RolePrivilege";
		} 
		public tmp_N4_RolePrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_RolePrivilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Role_uniqueid!=null) 
		{
			list.Add(addFunc("Role_uniqueid",model.Role_uniqueid.ToString()));
		}

						if(model.Privilege_code!=null) 
		{
			list.Add(addFunc("Privilege_code",model.Privilege_code.ToString()));
		}

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(addFunc("Prd_privilege_text",model.Prd_privilege_text.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_RolePrivilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Role_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_uniqueid.ToString(),addFunc("[Role_uniqueid]")));
		}
					

						if(model.Privilege_code!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_code.ToString(),addFunc("[Privilege_code]")));
		}
					

						if(model.Prd_privilege_text!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_privilege_text.ToString(),addFunc("[Prd_privilege_text]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_RolePrivilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_RolePrivilege)item[0];		
	var where=	(tmp_N4_RolePrivilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_RolePrivilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_RolePrivilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_RolePrivilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_RolePrivilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_RolePrivilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_SysDatRoleRepository : BaseRepository<tmp_N4_SysDatRole>, Itmp_N4_SysDatRoleRepository
{
		public tmp_N4_SysDatRoleRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_SysDatRole";
		} 
		public tmp_N4_SysDatRoleRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_SysDatRole model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Unique_id!=null) 
		{
			list.Add(addFunc("Unique_id",model.Unique_id.ToString()));
		}

						if(model.FCode!=null) 
		{
			list.Add(addFunc("FCode",model.FCode.ToString()));
		}

						if(model.FName!=null) 
		{
			list.Add(addFunc("FName",model.FName.ToString()));
		}

						if(model.Dir!=null) 
		{
			list.Add(addFunc("Dir",model.Dir.ToString()));
		}

						if(model.Role_desc!=null) 
		{
			list.Add(addFunc("Role_desc",model.Role_desc.ToString()));
		}

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(addFunc("Creator_uniqueid",model.Creator_uniqueid.ToString()));
		}

						if(model.Creator_name!=null) 
		{
			list.Add(addFunc("Creator_name",model.Creator_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Updator_uniqueid!=null) 
		{
			list.Add(addFunc("Updator_uniqueid",model.Updator_uniqueid.ToString()));
		}

						if(model.Updator_name!=null) 
		{
			list.Add(addFunc("Updator_name",model.Updator_name.ToString()));
		}

						if(model.Update_time!=null) 
		{
			list.Add(addFunc("Update_time",model.Update_time.ToString()));
		}

						if(model.Submitter_uniqueid!=null) 
		{
			list.Add(addFunc("Submitter_uniqueid",model.Submitter_uniqueid.ToString()));
		}

						if(model.Submitter_name!=null) 
		{
			list.Add(addFunc("Submitter_name",model.Submitter_name.ToString()));
		}

						if(model.Submit_time!=null) 
		{
			list.Add(addFunc("Submit_time",model.Submit_time.ToString()));
		}

						if(model.Approver_uniqueid!=null) 
		{
			list.Add(addFunc("Approver_uniqueid",model.Approver_uniqueid.ToString()));
		}

						if(model.Approver_name!=null) 
		{
			list.Add(addFunc("Approver_name",model.Approver_name.ToString()));
		}

						if(model.Approver_time!=null) 
		{
			list.Add(addFunc("Approver_time",model.Approver_time.ToString()));
		}

						if(model.Abandoner_uniqueid!=null) 
		{
			list.Add(addFunc("Abandoner_uniqueid",model.Abandoner_uniqueid.ToString()));
		}

						if(model.Abandoner_name!=null) 
		{
			list.Add(addFunc("Abandoner_name",model.Abandoner_name.ToString()));
		}

						if(model.Abandon_time!=null) 
		{
			list.Add(addFunc("Abandon_time",model.Abandon_time.ToString()));
		}

						if(model.Data_status!=null) 
		{
			list.Add(addFunc("Data_status",model.Data_status.ToString()));
		}

						if(model.Abandon_status!=null) 
		{
			list.Add(addFunc("Abandon_status",model.Abandon_status.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_SysDatRole model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Unique_id.ToString(),addFunc("[Unique_id]")));
		}
					

						if(model.FCode!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.FCode.ToString(),addFunc("[FCode]")));
		}
					

						if(model.FName!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.FName.ToString(),addFunc("[FName]")));
		}
					

						if(model.Dir!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Dir.ToString(),addFunc("[Dir]")));
		}
					

						if(model.Role_desc!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_desc.ToString(),addFunc("[Role_desc]")));
		}
					

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_uniqueid.ToString(),addFunc("[Creator_uniqueid]")));
		}
					

						if(model.Creator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_name.ToString(),addFunc("[Creator_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Updator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator_uniqueid.ToString(),addFunc("[Updator_uniqueid]")));
		}
					

						if(model.Updator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator_name.ToString(),addFunc("[Updator_name]")));
		}
					

						if(model.Update_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Update_time.ToString(),addFunc("[Update_time]")));
		}
					

						if(model.Submitter_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter_uniqueid.ToString(),addFunc("[Submitter_uniqueid]")));
		}
					

						if(model.Submitter_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter_name.ToString(),addFunc("[Submitter_name]")));
		}
					

						if(model.Submit_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submit_time.ToString(),addFunc("[Submit_time]")));
		}
					

						if(model.Approver_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_uniqueid.ToString(),addFunc("[Approver_uniqueid]")));
		}
					

						if(model.Approver_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_name.ToString(),addFunc("[Approver_name]")));
		}
					

						if(model.Approver_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_time.ToString(),addFunc("[Approver_time]")));
		}
					

						if(model.Abandoner_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_uniqueid.ToString(),addFunc("[Abandoner_uniqueid]")));
		}
					

						if(model.Abandoner_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_name.ToString(),addFunc("[Abandoner_name]")));
		}
					

						if(model.Abandon_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_time.ToString(),addFunc("[Abandon_time]")));
		}
					

						if(model.Data_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Data_status.ToString(),addFunc("[Data_status]")));
		}
					

						if(model.Abandon_status!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_status.ToString(),addFunc("[Abandon_status]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_SysDatRole)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_SysDatRole)item[0];		
	var where=	(tmp_N4_SysDatRole)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_SysDatRole where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_SysDatRole where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_SysDatRole where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_SysDatRole where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_SysDatRole where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_SysDatUserRepository : BaseRepository<tmp_N4_SysDatUser>, Itmp_N4_SysDatUserRepository
{
		public tmp_N4_SysDatUserRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_SysDatUser";
		} 
		public tmp_N4_SysDatUserRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_SysDatUser model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.Uniqueid!=null) 
		{
			list.Add(addFunc("Uniqueid",model.Uniqueid.ToString()));
		}

						if(model.Login_name!=null) 
		{
			list.Add(addFunc("Login_name",model.Login_name.ToString()));
		}

						if(model.User_name!=null) 
		{
			list.Add(addFunc("User_name",model.User_name.ToString()));
		}

						if(model.Department_unique_id!=null) 
		{
			list.Add(addFunc("Department_unique_id",model.Department_unique_id.ToString()));
		}

						if(model.Prd_department_name!=null) 
		{
			list.Add(addFunc("Prd_department_name",model.Prd_department_name.ToString()));
		}

						if(model.Pwd!=null) 
		{
			list.Add(addFunc("Pwd",model.Pwd.ToString()));
		}

						if(model.ScanCode!=null) 
		{
			list.Add(addFunc("ScanCode",model.ScanCode.ToString()));
		}

						if(model.IsAllowLogin!=null) 
		{
			list.Add(addFunc("IsAllowLogin",model.IsAllowLogin.ToString()));
		}

						if(model.InValidTime!=null) 
		{
			list.Add(addFunc("InValidTime",model.InValidTime.ToString()));
		}

						if(model.IsEmployee!=null) 
		{
			list.Add(addFunc("IsEmployee",model.IsEmployee.ToString()));
		}

						if(model.DataStatus!=null) 
		{
			list.Add(addFunc("DataStatus",model.DataStatus.ToString()));
		}

						if(model.AbandonStatus!=null) 
		{
			list.Add(addFunc("AbandonStatus",model.AbandonStatus.ToString()));
		}

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(addFunc("Creator_uniqueid",model.Creator_uniqueid.ToString()));
		}

						if(model.Prd_creator_name!=null) 
		{
			list.Add(addFunc("Prd_creator_name",model.Prd_creator_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Last_updater_unique_id!=null) 
		{
			list.Add(addFunc("Last_updater_unique_id",model.Last_updater_unique_id.ToString()));
		}

						if(model.Last_updater_name!=null) 
		{
			list.Add(addFunc("Last_updater_name",model.Last_updater_name.ToString()));
		}

						if(model.Last_update_time!=null) 
		{
			list.Add(addFunc("Last_update_time",model.Last_update_time.ToString()));
		}

						if(model.Approver_unique_id!=null) 
		{
			list.Add(addFunc("Approver_unique_id",model.Approver_unique_id.ToString()));
		}

						if(model.Approver_name!=null) 
		{
			list.Add(addFunc("Approver_name",model.Approver_name.ToString()));
		}

						if(model.Approve_time!=null) 
		{
			list.Add(addFunc("Approve_time",model.Approve_time.ToString()));
		}

						if(model.Abandoner_unique_id!=null) 
		{
			list.Add(addFunc("Abandoner_unique_id",model.Abandoner_unique_id.ToString()));
		}

						if(model.Abandoner_name!=null) 
		{
			list.Add(addFunc("Abandoner_name",model.Abandoner_name.ToString()));
		}

						if(model.Abandon_time!=null) 
		{
			list.Add(addFunc("Abandon_time",model.Abandon_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_SysDatUser model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.Uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Uniqueid.ToString(),addFunc("[Uniqueid]")));
		}
					

						if(model.Login_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Login_name.ToString(),addFunc("[Login_name]")));
		}
					

						if(model.User_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_name.ToString(),addFunc("[User_name]")));
		}
					

						if(model.Department_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Department_unique_id.ToString(),addFunc("[Department_unique_id]")));
		}
					

						if(model.Prd_department_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_department_name.ToString(),addFunc("[Prd_department_name]")));
		}
					

						if(model.Pwd!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Pwd.ToString(),addFunc("[Pwd]")));
		}
					

						if(model.ScanCode!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.ScanCode.ToString(),addFunc("[ScanCode]")));
		}
					

						if(model.IsAllowLogin!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.IsAllowLogin.ToString(),addFunc("[IsAllowLogin]")));
		}
					

						if(model.InValidTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.InValidTime.ToString(),addFunc("[InValidTime]")));
		}
					

						if(model.IsEmployee!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.IsEmployee.ToString(),addFunc("[IsEmployee]")));
		}
					

						if(model.DataStatus!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.DataStatus.ToString(),addFunc("[DataStatus]")));
		}
					

						if(model.AbandonStatus!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.AbandonStatus.ToString(),addFunc("[AbandonStatus]")));
		}
					

						if(model.Creator_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_uniqueid.ToString(),addFunc("[Creator_uniqueid]")));
		}
					

						if(model.Prd_creator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Prd_creator_name.ToString(),addFunc("[Prd_creator_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Last_updater_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_updater_unique_id.ToString(),addFunc("[Last_updater_unique_id]")));
		}
					

						if(model.Last_updater_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_updater_name.ToString(),addFunc("[Last_updater_name]")));
		}
					

						if(model.Last_update_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_update_time.ToString(),addFunc("[Last_update_time]")));
		}
					

						if(model.Approver_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_unique_id.ToString(),addFunc("[Approver_unique_id]")));
		}
					

						if(model.Approver_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_name.ToString(),addFunc("[Approver_name]")));
		}
					

						if(model.Approve_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approve_time.ToString(),addFunc("[Approve_time]")));
		}
					

						if(model.Abandoner_unique_id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_unique_id.ToString(),addFunc("[Abandoner_unique_id]")));
		}
					

						if(model.Abandoner_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_name.ToString(),addFunc("[Abandoner_name]")));
		}
					

						if(model.Abandon_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandon_time.ToString(),addFunc("[Abandon_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_SysDatUser)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_SysDatUser)item[0];		
	var where=	(tmp_N4_SysDatUser)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_SysDatUser where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_SysDatUser where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_SysDatUser where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_SysDatUser where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_SysDatUser where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_UserPrivilegeRepository : BaseRepository<tmp_N4_UserPrivilege>, Itmp_N4_UserPrivilegeRepository
{
		public tmp_N4_UserPrivilegeRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_UserPrivilege";
		} 
		public tmp_N4_UserPrivilegeRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_UserPrivilege model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_uniqueid!=null) 
		{
			list.Add(addFunc("User_uniqueid",model.User_uniqueid.ToString()));
		}

						if(model.Privilege_name!=null) 
		{
			list.Add(addFunc("Privilege_name",model.Privilege_name.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_UserPrivilege model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_uniqueid.ToString(),addFunc("[User_uniqueid]")));
		}
					

						if(model.Privilege_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Privilege_name.ToString(),addFunc("[Privilege_name]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_UserPrivilege)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_UserPrivilege)item[0];		
	var where=	(tmp_N4_UserPrivilege)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_UserPrivilege where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_UserPrivilege where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_UserPrivilege where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_UserPrivilege where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_UserPrivilege where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class tmp_N4_UserRoleAndDepartRepository : BaseRepository<tmp_N4_UserRoleAndDepart>, Itmp_N4_UserRoleAndDepartRepository
{
		public tmp_N4_UserRoleAndDepartRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="tmp_N4_UserRoleAndDepart";
		} 
		public tmp_N4_UserRoleAndDepartRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(tmp_N4_UserRoleAndDepart model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.User_uniqueid!=null) 
		{
			list.Add(addFunc("User_uniqueid",model.User_uniqueid.ToString()));
		}

						if(model.Role_uniqueid!=null) 
		{
			list.Add(addFunc("Role_uniqueid",model.Role_uniqueid.ToString()));
		}

						if(model.Depart_uniqueid!=null) 
		{
			list.Add(addFunc("Depart_uniqueid",model.Depart_uniqueid.ToString()));
		}

						if(model.InvalidTime!=null) 
		{
			list.Add(addFunc("InvalidTime",model.InvalidTime.ToString()));
		}

						if(model.Factory!=null) 
		{
			list.Add(addFunc("Factory",model.Factory.ToString()));
		}

						if(model.Create_time!=null) 
		{
			list.Add(addFunc("Create_time",model.Create_time.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(tmp_N4_UserRoleAndDepart model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.User_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.User_uniqueid.ToString(),addFunc("[User_uniqueid]")));
		}
					

						if(model.Role_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Role_uniqueid.ToString(),addFunc("[Role_uniqueid]")));
		}
					

						if(model.Depart_uniqueid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Depart_uniqueid.ToString(),addFunc("[Depart_uniqueid]")));
		}
					

						if(model.InvalidTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.InvalidTime.ToString(),addFunc("[InvalidTime]")));
		}
					

						if(model.Factory!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Factory.ToString(),addFunc("[Factory]")));
		}
					

						if(model.Create_time!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Create_time.ToString(),addFunc("[Create_time]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(tmp_N4_UserRoleAndDepart)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(tmp_N4_UserRoleAndDepart)item[0];		
	var where=	(tmp_N4_UserRoleAndDepart)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(tmp_N4_UserRoleAndDepart where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, tmp_N4_UserRoleAndDepart where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(tmp_N4_UserRoleAndDepart where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, tmp_N4_UserRoleAndDepart where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, tmp_N4_UserRoleAndDepart where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
public partial class WorkCalTemplateRepository : BaseRepository<WorkCalTemplate>, IWorkCalTemplateRepository
{
		public WorkCalTemplateRepository(IUnitOfWork unitOfWork)
        : base(unitOfWork)
		{
			_tableName="WorkCalTemplate";
		} 
		public WorkCalTemplateRepository(IUnitOfWork unitOfWork,string tableName)
        : base(unitOfWork)
		{
			_tableName=tableName;
		}  
		private string _tableName;
	
	protected override string GetSqlFromModel(WorkCalTemplate model,Func<string,string,string> addFunc,Func<string,string> joinFunc)
	{
		if(null==model)
		{
			return string.Empty;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(addFunc("Id",model.Id.ToString()));
		}

						if(model.WorkCalTempletNo!=null) 
		{
			list.Add(addFunc("WorkCalTempletNo",model.WorkCalTempletNo.ToString()));
		}

						if(model.WorkCalTempletName!=null) 
		{
			list.Add(addFunc("WorkCalTempletName",model.WorkCalTempletName.ToString()));
		}

						if(model.WorkCalCycleNo!=null) 
		{
			list.Add(addFunc("WorkCalCycleNo",model.WorkCalCycleNo.ToString()));
		}

						if(model.CycleDays!=null) 
		{
			list.Add(addFunc("CycleDays",model.CycleDays.ToString()));
		}

						if(model.Remark!=null) 
		{
			list.Add(addFunc("Remark",model.Remark.ToString()));
		}

						if(model.DataStatus!=null) 
		{
			list.Add(addFunc("DataStatus",model.DataStatus.ToString()));
		}

						if(model.Creator_nqid!=null) 
		{
			list.Add(addFunc("Creator_nqid",model.Creator_nqid.ToString()));
		}

						if(model.Creator_name!=null) 
		{
			list.Add(addFunc("Creator_name",model.Creator_name.ToString()));
		}

						if(model.CreateTime!=null) 
		{
			list.Add(addFunc("CreateTime",model.CreateTime.ToString()));
		}

						if(model.Updator_nqid!=null) 
		{
			list.Add(addFunc("Updator_nqid",model.Updator_nqid.ToString()));
		}

						if(model.Updator_name!=null) 
		{
			list.Add(addFunc("Updator_name",model.Updator_name.ToString()));
		}

						if(model.UpdateTime!=null) 
		{
			list.Add(addFunc("UpdateTime",model.UpdateTime.ToString()));
		}

						if(model.Submitter_nqid!=null) 
		{
			list.Add(addFunc("Submitter_nqid",model.Submitter_nqid.ToString()));
		}

						if(model.Submitter_name!=null) 
		{
			list.Add(addFunc("Submitter_name",model.Submitter_name.ToString()));
		}

						if(model.SubmitTime!=null) 
		{
			list.Add(addFunc("SubmitTime",model.SubmitTime.ToString()));
		}

						if(model.Approver_nqid!=null) 
		{
			list.Add(addFunc("Approver_nqid",model.Approver_nqid.ToString()));
		}

						if(model.Approver_name!=null) 
		{
			list.Add(addFunc("Approver_name",model.Approver_name.ToString()));
		}

						if(model.ApproveTime!=null) 
		{
			list.Add(addFunc("ApproveTime",model.ApproveTime.ToString()));
		}

						if(model.Abandoner_nqid!=null) 
		{
			list.Add(addFunc("Abandoner_nqid",model.Abandoner_nqid.ToString()));
		}

						if(model.Abandoner_name!=null) 
		{
			list.Add(addFunc("Abandoner_name",model.Abandoner_name.ToString()));
		}

						if(model.AbandonTime!=null) 
		{
			list.Add(addFunc("AbandonTime",model.AbandonTime.ToString()));
		}

						if(model.Is_deleted!=null) 
		{
			list.Add(addFunc("Is_deleted",model.Is_deleted.ToString()));
		}

						if(model.Last_timestamp!=null) 
		{
			list.Add(addFunc("Last_timestamp",model.Last_timestamp.ToString()));
		}

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

	protected override string GetWhereSqlFromModel(WorkCalTemplate model,Func<string,string> joinFunc,Func<string,string> addFunc=null)
	{
		if(null==model)
		{
			return string.Empty;
		}
		if(addFunc==null)
		{
			addFunc=(s)=>s;
		}
		List<string> list=new List<string>();
				if(model.Id!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Id.ToString(),addFunc("[Id]")));
		}
					

						if(model.WorkCalTempletNo!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.WorkCalTempletNo.ToString(),addFunc("[WorkCalTempletNo]")));
		}
					

						if(model.WorkCalTempletName!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.WorkCalTempletName.ToString(),addFunc("[WorkCalTempletName]")));
		}
					

						if(model.WorkCalCycleNo!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.WorkCalCycleNo.ToString(),addFunc("[WorkCalCycleNo]")));
		}
					

						if(model.CycleDays!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.CycleDays.ToString(),addFunc("[CycleDays]")));
		}
					

						if(model.Remark!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Remark.ToString(),addFunc("[Remark]")));
		}
					

						if(model.DataStatus!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.DataStatus.ToString(),addFunc("[DataStatus]")));
		}
					

						if(model.Creator_nqid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_nqid.ToString(),addFunc("[Creator_nqid]")));
		}
					

						if(model.Creator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Creator_name.ToString(),addFunc("[Creator_name]")));
		}
					

						if(model.CreateTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.CreateTime.ToString(),addFunc("[CreateTime]")));
		}
					

						if(model.Updator_nqid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator_nqid.ToString(),addFunc("[Updator_nqid]")));
		}
					

						if(model.Updator_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Updator_name.ToString(),addFunc("[Updator_name]")));
		}
					

						if(model.UpdateTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.UpdateTime.ToString(),addFunc("[UpdateTime]")));
		}
					

						if(model.Submitter_nqid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter_nqid.ToString(),addFunc("[Submitter_nqid]")));
		}
					

						if(model.Submitter_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Submitter_name.ToString(),addFunc("[Submitter_name]")));
		}
					

						if(model.SubmitTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.SubmitTime.ToString(),addFunc("[SubmitTime]")));
		}
					

						if(model.Approver_nqid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_nqid.ToString(),addFunc("[Approver_nqid]")));
		}
					

						if(model.Approver_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Approver_name.ToString(),addFunc("[Approver_name]")));
		}
					

						if(model.ApproveTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.ApproveTime.ToString(),addFunc("[ApproveTime]")));
		}
					

						if(model.Abandoner_nqid!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_nqid.ToString(),addFunc("[Abandoner_nqid]")));
		}
					

						if(model.Abandoner_name!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Abandoner_name.ToString(),addFunc("[Abandoner_name]")));
		}
					

						if(model.AbandonTime!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.AbandonTime.ToString(),addFunc("[AbandonTime]")));
		}
					

						if(model.Is_deleted!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Is_deleted.ToString(),addFunc("[Is_deleted]")));
		}
					

						if(model.Last_timestamp!=null) 
		{
			list.Add(string.Format("{1}='{0}'",model.Last_timestamp.ToString(),addFunc("[Last_timestamp]")));
		}
					

					
		return string.Join(joinFunc(string.Empty),list.ToArray());
	}

public override string PersistNewItem(params ModelBase[] item)
{
	var data=(WorkCalTemplate)item[0];
string sql = string.Format("insert into [{2}]({0}) values({1})",
                                this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]",name),s=>","),
								this.GetSqlFromModel(data,(name,value)=>string.Format("'{0}'",value),s=>","),_tableName);
    return sql;
}

public override string PersistUpdatedItem(params ModelBase[] item)
{
	var data=(WorkCalTemplate)item[0];		
	var where=	(WorkCalTemplate)item[1];
string sql = string.Format("update [{2}] set {0} where {1}",  
						this.GetSqlFromModel(data,(name,value)=>string.Format("[{0}]='{1}'",name,value),s=>","),
						this.GetWhereSqlFromModel(where,s=>" and "),_tableName);
    return sql;
}      

protected override string QueryBySql(WorkCalTemplate where = null, string order = null)
{
	string whereStr = string.Empty;
	if (null != where)
	{
		string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
		if (!string.IsNullOrEmpty(whereSql))
		{
			whereStr = string.Format("where {0}", whereSql);
		}
	}
    string sql = string.Format("select * from [{2}] {0} {1}", whereStr, order,_tableName);
    return sql;
}

protected override string QueryPageBySql(int pageIndex = 1, int pageSize = 20, WorkCalTemplate where = null, string order = null)
{
    string whereStr = string.Empty;
    if (null != where)
    {
        whereStr =this.GetWhereSqlFromModel(where, s => " and ");
    }
    string sql =
        string.Format(
            @"SELECT  t.*
			FROM    ( SELECT    * ,
								ROW_NUMBER() OVER ({0}) AS Rn
					  FROM [{4}] {1}
					) AS t
			WHERE   t.Rn BETWEEN {2} AND {3}",
            string.IsNullOrEmpty(order)?"ORDER BY GETDATE()":order,
            (string.IsNullOrEmpty(whereStr) ? string.Empty : string.Format("where {0}", whereStr)),
			(pageIndex-1)*pageSize+1,
			pageSize*pageIndex,_tableName);

    return sql;
}

        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QueryCountBySql(WorkCalTemplate where = null)
        {
            //TODO:Where不能为空

            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select count(1) from [{1}] {0} ", whereStr,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询指定列的数据之和
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        protected override string QuerySumBySql(string columnName, WorkCalTemplate where = null)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException(string.Format("查询指定列数据汇总失败，失败详情：指定列名不能为空"));

            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select SUM({1}) from [{2}] {0} ", whereStr, columnName,_tableName);
            return sql;
        }

        /// <summary>
        /// 查询top条数据
        /// </summary>
        /// <param name="top"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected override string QueryTopBySql(int? top, WorkCalTemplate where = null, string order = null)
        {
            if (null == top)
            {
                throw new ArgumentNullException(string.Format("查询指定TOP数据失败，失败详情：TOP不能为空"));
            }
            string whereStr = string.Empty;
            if (null != where)
            {
                string whereSql = this.GetWhereSqlFromModel(where, s => " and ");
                if (!string.IsNullOrEmpty(whereSql))
                {
                    whereStr = string.Format("where {0}", whereSql);
                }
            }
            string sql = string.Format("select top ({2}) * from [{3}] {0} {1}", whereStr, order,
                                       Math.Abs((int)top),_tableName);

            return sql;
        }


public override void AddDataTable(System.Data.DataTable dataTable)
        {
            base.AddDataTable(dataTable,_tableName);
        }

}
	
}