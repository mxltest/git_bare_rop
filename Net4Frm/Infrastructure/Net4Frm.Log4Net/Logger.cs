using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Log4Net
{
    public static class Logger
    {
       private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

       public static void Info(ComplexFanLogMessage logInfo)
       {
           log.Info(logInfo);
       }
       public static void Error(ComplexFanLogMessage logInfo)
       {
           log.Error(logInfo);

       }
       public static void Fatal(ComplexFanLogMessage logInfo)
       {
           log.Fatal(logInfo);
       }
       public static void Warn(ComplexFanLogMessage logInfo)
       {
           log.Warn(logInfo);
       }
       public static void Debug(ComplexFanLogMessage logInfo)
       {
           log.Debug(logInfo);
       }
    }
}

