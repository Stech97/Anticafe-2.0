using System;
using System.IO;

namespace Anticafe_4._0_Model
{
	public static class Logger
	{
        public static void TraceLog(string trace)
        {
            var _path = "C:\\log\\Anticafe";

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

		public static void ExeptionLog(string exp)
		{
            var _path = "C:\\log\\Anticafe";

            _path = _path + "\\exeption_" + DateTime.Now.Date.ToShortDateString() + ".log";
			using (StreamWriter logger = new StreamWriter(_path, true))
			{
                logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + exp);
            }

            SaveToDB.SaveExeptionToDB(DateTime.Now, exp);
		}

	}
}
