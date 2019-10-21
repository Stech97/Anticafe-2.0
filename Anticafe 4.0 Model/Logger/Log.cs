using NLog;
using System;

namespace Anticafe.Model
{
     public class Log : ILog
     {
        private readonly ILogger _logger;

		public Log(ILogger logger)
		{
			_logger = logger;
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
