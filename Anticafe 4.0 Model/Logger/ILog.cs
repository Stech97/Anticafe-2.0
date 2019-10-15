using System;

namespace Anticafe.Model
{
    public interface ILog
    {
        void Trace(String message);
        void Debug(String message);
        void Info(String message);
        void Warn(String message);
        void Errors(String message);
        void Fatal(String message);
    }
}
