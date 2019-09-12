using System;
using System.IO;

namespace Anticafe_4._0_Model
{
	public static class Logger
	{
		public static void TraceLog(string message)
		{
			var path = "C:\\log\\Anticafe";

			Directory.CreateDirectory(path);

			path = path + "\\trace_" + DateTime.Now.Date.ToShortDateString() + ".log";
			using (StreamWriter logger = new StreamWriter(path,true))
			{
                if (message.Equals("Exit"))
                {
                    logger.WriteLine();
                    logger.WriteLine();
                    logger.WriteLine();
                    logger.WriteLine();
                }
                else
                    logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + message);
			}
		}

		public static void ExeptionLog(Exception exp)
		{
			var path = "C:\\log\\Anticafe";

			Directory.CreateDirectory(path);

			path = path + "\\exeption_" + DateTime.Now.Date.ToShortDateString() + ".log";
			using (StreamWriter logger = new StreamWriter(path, true))
			{
				//реализовать exeption
			}
		}

	}
}
