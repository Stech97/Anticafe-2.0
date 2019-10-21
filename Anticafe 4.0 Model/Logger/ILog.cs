using System;

namespace Anticafe.Model
{
    public interface ILog
    {
        void Trace(String TraceMessage);
        void Debug(String DebugMessage);
        void Info(String InfoMessage);
        void Warn(String WarmMessage);
        void Errors(String ErorrsMessage);
        void Fatal(String FatalMessage);
    }
}
