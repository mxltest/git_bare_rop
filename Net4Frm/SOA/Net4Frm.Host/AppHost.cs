using System;
using Funq;
using Net4Frm.Common;
using Net4Frm.Facade;
using Net4Frm.Logging;
using ServiceStack.WebHost.Endpoints;
using Net4Frm.Logging.External;
using Net4Frm.Log4Net;

namespace Net4Frm.Host
{
    /// <summary>
    /// An example of a AppHost to have your services running inside a web server.
    /// </summary>
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("WEBSERVICE", typeof(INoticeService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            //Permit modern browsers (e.g. Firefox) to allow sending of any REST HTTP Method
            base.SetConfig(new EndpointHostConfig
            {
                GlobalResponseHeaders =
                    {
                        { "Access-Control-Allow-Origin", "*" },
                        { "Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS" },
                    },
            });

            //请求过滤器
            this.RequestFilters.Add((req, res, reqDto) =>
                {
                    //验证权限 

                    //记录来源ip，时间，原始内容
                    //string reqKey = req.Headers.Get("RequestIdentity");
                    string reqIp = req.UserHostAddress;
                    string reqMethod = req.OperationName;
                    string reqcontent = Serializer.SerializerToString(reqDto);
                    //记录信息
                    Logger.Info(new ComplexFanLogMessage("", "00000000", reqcontent, "", "", "", reqMethod, "", reqIp));
                    //LoggerIoc.GetLogger().Write(LoggerLevel.Info, "00000000", reqMethod, reqcontent, reqIp);

                });

            //响应过滤器
            this.ResponseFilters.Add((req, res, resDto) =>
                {
                   //记录响应时间 和 响应 内容
                    string resContent = Serializer.SerializerToString(resDto);
                    Logger.Info(new ComplexFanLogMessage("", "11111111", "", resContent, "", "", req.OperationName, "", ""));
                    //LoggerIoc.GetLogger().Write(LoggerLevel.Info, "11111111", string.Empty, resContent);
                });
        }

    }

}