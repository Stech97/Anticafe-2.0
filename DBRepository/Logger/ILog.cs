namespace DBRepository.Logger
{
    public interface ILog
    {
        void Trace(string TraceMessage);
        void Debug(string DebugMessage);
        void Info(string InfoMessage);
        void Warn(string WarmMessage);
        void Errors(string ErorrsMessage);
        void Fatal(string FatalMessage);
    }
}
