using NLog;

namespace DBRepository.Logger
{
     public class Log : ILog
     {
        private readonly ILogger _logger;

		public Log(ILogger logger)
		{
			_logger = logger;
		}

        public void Trace(string TraceMessage)
        {
            _logger.Trace(TraceMessage);
        }

        public void Debug(string DebugMessage)
        {
            _logger.Debug(DebugMessage);
        }
        public void Info(string InfoMessage)
        {
            _logger.Info(InfoMessage);
        }
        public void Warn(string WarmMessage)
        {
            _logger.Warn(WarmMessage);
        }
        public void Errors(string ErorrsMessage)
        {
            _logger.Error(ErorrsMessage);
        }
        public void Fatal(string FatalMessage)
        {
            _logger.Fatal(FatalMessage);
        }
    }
}
