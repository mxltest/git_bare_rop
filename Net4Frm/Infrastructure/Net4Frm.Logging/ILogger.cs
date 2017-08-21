
namespace Net4Frm.Logging
{
    public interface ISystemLogger : IUserLogger
    {
        void PersistLogs();
        void InitLogger();
    }

    public interface IUserLogger
    {
        void Write(LoggerLevel level, string queryKeyWord, string action, string content, string address = null);
    }

    public interface ILogger : ISystemLogger
    {
    }
}
