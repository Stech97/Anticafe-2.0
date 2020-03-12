using NLog.Config;

namespace DBRepository.Logger
{
	public static class LogManager
	{
		static LogManager()
		{
			NLog.LogManager.Configuration = new XmlLoggingConfiguration("Logger/NLog.config");
		}

		public static ILog CreateLogger(string systemComponent, string loggerType)
		{
			var name = $"{systemComponent}_{loggerType}";
			return new Log(NLog.LogManager.GetLogger(name));
		}
	}
}
