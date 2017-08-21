using Net4Frm.Log4Net;
using Net4Frm.Model;
using Net4Frm.Model.Base;
using Net4Frm.Model.Extension;
using Net4Frm.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.ServiceImplement
{
    public class OperationSysDatUserImpl : BaseService, IOperationSysDatUser
    {
        #region 新增用户API
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="datUser"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> InsertSysDatUserInfo(N4_SysDatUser datUser)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            LogMessage mes = new LogMessage();
            try
            {
                mes.StringForOldEntity = "OldEntity_N4_SysDatUser";
                bool checkUsrName = DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { User_name = datUser.User_name, Is_deleted = false }).Count() == 0;
                if (checkUsrName)
                {
                    DbSession.N4_SysDatUserRepository.Add(datUser);
                    DbSession.SaveChange();
                    mes.StringForNewEntity = "NewEntity_N4_SysDatUser";
                }
                else
                {
                    ptcp.StatusFlag = PtcpState.Failed;
                }
                ptcp.StatusFlag = PtcpState.Success;
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", "00000000" ,mes.StringForOldEntity, mes.StringForNewEntity, ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion

        #region 更新用户信息API
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="datUser"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> UpdateSysDatUserInfo(N4_SysDatUser datUser)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            //日志
            LogMessage mes = new LogMessage();
            List<N4_SysDatUser> list = new List<N4_SysDatUser>();
            try
            {
                  bool checkUsrName = DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { User_name = datUser.User_name, Is_deleted = false }).Count() == 1;
                  if (checkUsrName)
                  {
                      list = DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { Uniqueid = datUser.Uniqueid, Is_deleted = false }).ToList();
                      if (list.Count > 0)
                      {
                          mes.EntityID = list[0].Id.ToString();
                          mes.StringForOldEntity = "OldEntity_N4_SysDatUser";
                      }
                      DbSession.N4_SysDatUserRepository.Update(datUser, new N4_SysDatUser { Uniqueid = datUser.Uniqueid });
                      DbSession.SaveChange();
                      mes.StringForNewEntity = "NewEntity_N4_SysDatUser";
                      ptcp.StatusFlag = PtcpState.Success;
                  }
                  else
                  {
                      ptcp.StatusFlag = PtcpState.Failed;
                      ptcp.Message = "该用户已存在,请重新输入！";
                  }
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", mes.EntityID, mes.StringForOldEntity, mes.StringForNewEntity, ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion

        #region 查询用户信息列表API
        /// <summary>
        /// 查询用户信息列 表
        /// </summary>
        /// <param name="pagerInfo"></param>
        /// <param name="query_entity"></param>
        /// <returns></returns>
        public IEnumerable<N4_SysDatUser> QueryUsers(PageQueryInput pagerInfo, N4_SysDatUser query_entity)
        {
            query_entity.Is_deleted = false;
            return DbSession.N4_SysDatUserRepository.QueryPageBy(pagerInfo.current_page_index.Value, pagerInfo.pagesize.Value, query_entity);
        }
        #endregion

        #region 根据uniqueid查询用户API
        /// <summary>
        /// 根据uniqueid查询用户
        /// </summary>
        /// <param name="uniqueid"></param>
        /// <returns></returns>
        public N4_SysDatUser QueryUserByUniqueid(String uniqueid)
        {
            return DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { Uniqueid = uniqueid, Is_deleted = false }).FirstOrDefault();
        }
        #endregion

        #region 用户登录API
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="login_name">用户名</param>
        /// <param name="pwd">用户密码</param>
        /// <returns></returns>
        public Ptcp<UserLoginRes> LogIn(String login_name, string pwd)
        {

            Ptcp<UserLoginRes> ptcp = new Ptcp<UserLoginRes>();
            UserLoginRes res = new UserLoginRes();
            N4_logToUserLoginout logToUserLogin = new N4_logToUserLoginout();
            try
            {
                //1.验证账号密码的正确性
                bool hasUser = DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { Login_name = login_name, Pwd = pwd, Is_deleted = false }).Count() == 1;
                //2.1 如果正确，那么继续返回登陆的信息
                if (hasUser == true)
                {
                    res.userinfo = DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { Login_name = login_name, Pwd = pwd, Is_deleted = false }).FirstOrDefault();
                    res.privilege = DbSession.N4_UserPrivilegeRepository.QueryBy(new N4_UserPrivilege { User_uniqueid = res.userinfo.Uniqueid, Is_deleted = false });
                    ptcp.ReturnValue = res;
                    logToUserLogin.Event_level = Net4Frm.Model.Text.ELogin_Event_level.正常.ToString();
                }
                //2.2 如果错误，那么返回账号密码不一致，登录失败
                else
                {
                    ptcp.StatusFlag = PtcpState.Failed;
                    ptcp.Message = "账号密码不一致，登陆失败！";
                    logToUserLogin.Event_level = Net4Frm.Model.Text.ELogin_Event_level.异常.ToString();
                    logToUserLogin.Exception_desc = ptcp.Message;
                }
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", "00000000", "", "", ex.Message, "", "", "", ""));
                logToUserLogin.Event_level = Net4Frm.Model.Text.ELogin_Event_level.异常.ToString();
                logToUserLogin.Exception_desc = ex.Message;
            }
            finally {
                logToUserLogin.Login_type = Net4Frm.Model.Text.ELogin_Type.登录.ToString();
                logToUserLogin.Prd_user_name = login_name;
                logToUserLogin.Token = (Guid.NewGuid()).ToString("D");
                if (res.userinfo != null) {
                    logToUserLogin.User_unique_id = res.userinfo.Uniqueid;
                }
                DbSession.N4_logToUserLoginoutRepository.Add(logToUserLogin);
                DbSession.SaveChange();

                res.token = "";
            }
            return ptcp;
        }
        #endregion

        #region 删除用户API
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uniqueid"></param>
        /// <returns></returns>
        public Ptcp<ModelBase> RemoveUser(String uniqueid)
        {
            Ptcp<ModelBase> ptcp = new Ptcp<ModelBase>();
            //日志
            LogMessage mes = new LogMessage();
            List<N4_SysDatUser> list = new List<N4_SysDatUser>();
            try
            {
                list = DbSession.N4_SysDatUserRepository.QueryBy(new N4_SysDatUser { Uniqueid = uniqueid, Is_deleted = false }).ToList();
                if (list.Count > 0)
                {
                   mes.EntityID= list[0].Id.ToString();
                   mes.StringForOldEntity = "OldEntity_N4_SysDatUser";
                }
                DbSession.N4_SysDatUserRepository.Update(new N4_SysDatUser { Is_deleted = true }, new N4_SysDatUser { Uniqueid = uniqueid });
                DbSession.SaveChange();
                ptcp.StatusFlag = PtcpState.Success;
            }
            catch (Exception ex)
            {
                ptcp.StatusFlag = PtcpState.Failed;
                ptcp.Message = ex.Message;
                Logger.Error(new ComplexFanLogMessage("Net4Frm.ServiceImplement", mes.EntityID, mes.StringForOldEntity, mes.StringForNewEntity, ex.Message, "", "", "", ""));
            }
            return ptcp;
        }
        #endregion

        #region 获取用户登录登出日志API
        /// <summary>
        /// 获取用户登录登出日志
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public IEnumerable<N4_logToUserLoginout> SearchUserLoginOut(N4_logToUserLoginout login, int pageSize, int pageIndex, out long total)
        {
            total = 0;
            total = DbSession.N4_logToUserLoginoutRepository.QueryCountBy(login);
            return DbSession.N4_logToUserLoginoutRepository.QueryPageBy(pageIndex, pageSize, new N4_logToUserLoginout { Event_level = "正常"});
        }
        #endregion

        #region 用户登录异常日志API
        /// <summary>
        /// 获取用户登录登出日志
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public IEnumerable<N4_logToUserLoginout> SearchUserLoginException(N4_logToUserLoginout login, int pageSize, int pageIndex, out long total)
        {
            total = 0;
            total = DbSession.N4_logToUserLoginoutRepository.QueryCountBy(login);
            return DbSession.N4_logToUserLoginoutRepository.QueryPageBy(pageIndex, pageSize, new N4_logToUserLoginout { Event_level = "异常"});
        }
        #endregion

        #region  获取用户操作的日志API
        /// <summary>
        /// 获取用户操作的日志
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public IEnumerable<N4_logToUserOperation> SearchUserOperation(N4_logToUserOperation operation, int pageSize, int pageIndex, out long total)
        {
            total = 0;
            total = DbSession.N4_logToUserOperationRepository.QueryCountBy(operation);
            return DbSession.N4_logToUserOperationRepository.QueryPageBy(pageSize, pageIndex, operation);
        }
        #endregion

        #region  获取用户异常操作的日志API
        /// <summary>
        /// 获取用户异常操作的日志
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public IEnumerable<N4_logToUserOperation> SearchUserOperationException(N4_logToUserOperation operation, int pageSize, int pageIndex, out long total)
        {
            total = 0;
            total = DbSession.N4_logToUserOperationRepository.QueryCountBy(operation);
            return DbSession.N4_logToUserOperationRepository.QueryPageBy(pageSize, pageIndex, operation);
        }
        #endregion
    }
}
