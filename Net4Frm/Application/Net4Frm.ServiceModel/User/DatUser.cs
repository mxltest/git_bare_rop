using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceModel.User
{
    public class UserInfo
    {
        public Nullable<int> Id { get; set; }
        public string Uniqueid { get; set; }
        public string Login_name { get; set; }
        public string User_name { get; set; }
        public string Department_unique_id { get; set; }
        public string Prd_department_name { get; set; }
        public string Pwd { get; set; }
        public string ScanCode { get; set; }
        public Nullable<bool> IsAllowLogin { get; set; }
        public Nullable<System.DateTime> InValidTime { get; set; }
        public Nullable<bool> IsEmployee { get; set; }
        public string DataStatus { get; set; }
        public Nullable<bool> AbandonStatus { get; set; }
        public string Creator_uniqueid { get; set; }
        public string Prd_creator_name { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public string Last_updater_unique_id { get; set; }
        public string Last_updater_name { get; set; }
        public Nullable<System.DateTime> Last_update_time { get; set; }
        public string Approver_unique_id { get; set; }
        public string Approver_name { get; set; }
        public Nullable<System.DateTime> Approve_time { get; set; }
        public string Abandoner_unique_id { get; set; }
        public string Abandoner_name { get; set; }
        public Nullable<System.DateTime> Abandon_time { get; set; }
        public Nullable<bool> Is_deleted { get; set; }
        public byte[] Last_timestamp { get; set; }
    }

    public class AddUserRes : BaseResponse
    {

    }

    public class AddUserReq : UserInfo { }

    public class UpdateUserReq : UserInfo { }
    public class UpdateUserRes : BaseResponse { }

    public class UserInfosRes : BaseResponse
    {
        public IEnumerable<UserInfo> Infos { get; set; }
    }
    public class QueryUsersReq : BaseSearchRequest
    {
        public UserInfo query_entity { get; set; }
    }
    public class QueryUsersRes : BaseSearchResponse
    {
        public IEnumerable<UserInfo> result_data { get; set; }
    }

    public class QueryUserByUniqueidReq
    {
        public string Uniqueid { get; set; }
    }



    public class QueryUserByUniqueidRes : BaseResponse
    {
        public UserInfo query_entity { get; set; }
    }

    #region 用户登录
    /// <summary>
    /// 用户登录
    /// </summary>
    public class UserLoginReq
    {
        public string uid { get; set; }
        public string pwd { get; set; }
    }

    public class UserLoginRes : BaseResponse
    {
        public UserInfo userinfo { get; set; }
        public IEnumerable<UserPrivilege> privilege { get; set; }
        public String token { get; set; }
    }
    #endregion

    public class RemoveUserReq
    {
        public string Uniqueid { get; set; }
    }
    public class RemoveUserRes : BaseResponse
    {

    }

    #region 获取用户登录/登出日志
    /// <summary>
    /// 获取用户登录/登出日志
    /// </summary>
    public class QueryLogOfUserLoginReq : BaseRequest
    {
        public logToUserLoginout query_entity { get; set; }
    }

    public class QueryLogOfUserLoginRes : BaseSearchResponse
    {
        public List<logToUserLoginout> result_data { get; set; }
    }
    #endregion

    #region 用户登录异常日志
    /// <summary>
    /// 用户登录异常日志
    /// </summary>
    public class QueryLogOfUserLoginExceptionReq : BaseRequest
    {
        public logToUserLoginout query_entity { get; set; }
    }

    public class QueryLogOfUserLoginExceptionRes : BaseSearchResponse
    {
        public List<logToUserLoginout> result_data { get; set; }
    }
    #endregion

    public class logToUserLoginout
    {
        public Nullable<int> Id { get; set; }
        public string User_unique_id { get; set; }
        public string Prd_user_name { get; set; }
        public string Token { get; set; }
        public Nullable<System.DateTime> Login_time { get; set; }
        public string Login_type { get; set; }
        public string Device_info { get; set; }
        public string Event_level { get; set; }
        public string Exception_desc { get; set; }
        public byte[] Last_timestamp { get; set; }
    }

    #region 用户操作日志
    /// <summary>
    /// 用户操作日志
    /// </summary>
    public class QueryLogOfUserOperationReq : BaseRequest
    {
        public logToUserOperation query_entity { get; set; }
    }
    public class QueryLogOfUserOperationRes : BaseSearchResponse
    {
        public List<logToUserOperation> result_data { get; set; }
    }
    #endregion

    #region 用户异常操作日志
    /// <summary>
    /// 用户异常操作日志
    /// </summary>
    public class QueryLogOfUserOperationExceptionReq : BaseRequest
    {
        public logToUserOperation query_entity { get; set; }
    }
    public class QueryLogOfUserOperationExceptionRes : BaseSearchResponse
    {
        public List<logToUserOperation> result_data { get; set; }
    }

    #endregion
    public class logToUserOperation
    {
        public Nullable<int> Id { get; set; }
        public string User_unique_id { get; set; }
        public string Prd_user_name { get; set; }
        public string Column_path { get; set; }
        public string Operation_name { get; set; }
        public string Operation_desc { get; set; }
        public string Exception_desc { get; set; }
        public string Event_level { get; set; }
        public Nullable<System.DateTime> Create_time { get; set; }
        public byte[] Last_timestamp { get; set; }
    }
}
