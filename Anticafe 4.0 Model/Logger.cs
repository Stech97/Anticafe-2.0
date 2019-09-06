using System;
using System.IO;

namespace Anticafe_4._0_Model
{
	public static class Logger
	{
		public static void Log(string message)
		{
			var path = Environment.CurrentDirectory + "\\log";

			Directory.CreateDirectory(path);

			path = path + "\\" + DateTime.Now.Date.ToShortDateString() + ".log";
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

	}
}
