using NLog;
using System;
using System.IO;
using NLog.Config;

namespace Anticafe_4._0_Model
{
	public static class Logger
	{
        public static void TraceLog(string trace)
        {
			LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");

			var _path = "C:\\log\\Anticafe";
            
            if (Directory.Exists(_path))
            {
                _path = _path + "\\trace_" + DateTime.Now.Date.ToShortDateString() + ".log";
                using (StreamWriter logger = new StreamWriter(_path, true))
                {
                    if (trace.Equals("Exit"))
                    {
                        logger.WriteLine();
                        logger.WriteLine();
                        logger.WriteLine();
                        logger.WriteLine();
                    }
                    else
                        logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + trace);
                }
            }
            else
            {
                Directory.CreateDirectory(_path);

                _path = _path + "\\trace_" + DateTime.Now.Date.ToShortDateString() + ".log";
                using (StreamWriter logger = new StreamWriter(_path, true))
                {
                    if (trace.Equals("Exit"))
                    {
                        logger.WriteLine();
                        logger.WriteLine();
                        logger.WriteLine();
                        logger.WriteLine();
                    }
                    else
                        logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + trace);
                }
            }
		}

		public static void ExeptionLog(string exp)
		{
            var _path = "C:\\log\\Anticafe";

            if (Directory.Exists(_path))
            {
                _path = _path + "\\exeption_" + DateTime.Now.Date.ToShortDateString() + ".log";
                using (StreamWriter logger = new StreamWriter(_path, true))
                {
                    logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + exp);
                }

                SaveToDB.SaveExeptionToDB(DateTime.Now, exp);
            }
            else
            {
                Directory.CreateDirectory(_path);

                _path = _path + "\\exeption_" + DateTime.Now.Date.ToShortDateString() + ".log";
                using (StreamWriter logger = new StreamWriter(_path, true))
                {
                    logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + exp);
                }

                SaveToDB.SaveExeptionToDB(DateTime.Now, exp);
            }
		}

	}
}
