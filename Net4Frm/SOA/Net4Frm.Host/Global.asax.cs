using System.Threading;
using Net4Frm.Logging;
using Net4Frm.ServiceContainer;
using Net4Frm.ServiceContainer.External;
using System;
using Net4Frm.Logging.External;
using Net4Frm.Log4Net;

using log4net.Config;


namespace Net4Frm.Host
{
    public class Global : System.Web.HttpApplication
    {

        private readonly IContainer _container = ContainerFactory.GetContainer();
        private readonly ISystemLogger _logger = LoggerIoc.GetLogger();
        protected void Application_Start(object sender, EventArgs e)
        {

            try
            {
                XmlConfigurator.Configure();   
                //启动服务
                var appHost = new AppHost();
                appHost.Init();
                //启动容器初始化
                _container.InitContainer();
            }
            catch (Exception exception)
            {
                
                 _logger.Write(LoggerLevel.Fault, this.GetType().FullName, "appHost初始化失败", exception.ToString());
            }
            Thread logThread = new Thread(_logger.InitLogger) { IsBackground = true };
            logThread.Start();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();

            //记录异常
            
            _logger.Write(LoggerLevel.Fault, "999", "Application_Error", exception.ToString());

            Server.ClearError();

            Response.Write("页面出错啦！~~");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}