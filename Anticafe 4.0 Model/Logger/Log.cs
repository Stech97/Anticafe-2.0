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
        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Debug(String message)
        {
            _logger.Debug(message);
        }
        public void Info(String message)
        {
            _logger.Info(message);
        }
        public void Warn(String message)
        {
            _logger.Warn(message);
        }
        public void Errors(String message)
        {
            _logger.Error(message);
        }
        public void Fatal(String message)
        {
            _logger.Fatal(message);
        }
    }
}
