using NLog;
using System;
using NLog.Config;

namespace Anticafe.Model
{
     public class Log : ILog
     {
        private readonly ILogger _logger;

        public Log()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("Logger/NLog.config");
            _logger = LogManager.GetCurrentClassLogger();            
        }
        public void Trace(String TraceMessage)
        {
            _logger.Trace(TraceMessage);
        }

        public void Debug(String DebugMessage)
        {
            _logger.Debug(DebugMessage);
        }
        public void Info(String InfoMessage)
        {
            _logger.Info(InfoMessage);
        }
        public void Warn(String WarmMessage)
        {
            _logger.Warn(WarmMessage);
        }
        public void Errors(String ErorrsMessage)
        {
            _logger.Error(ErorrsMessage);
        }
        public void Fatal(String FatalMessage)
        {
            _logger.Fatal(FatalMessage);
        }
    }
}
