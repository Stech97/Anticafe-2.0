using NLog.Config;

namespace Anticafe.Model
{
	public static class LogManager
	{
		static LogManager()
		{
			NLog.LogManager.Configuration = new XmlLoggingConfiguration("config/NLog.config");
		}

		public static ILog CreateLogger(string systemComponent, string loggerType)
		{
			var name = $"{systemComponent}_{loggerType}";
			return new Log(NLog.LogManager.GetLogger(name));
		}
	}
}
