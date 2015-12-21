
namespace Examples.DesignPatterns.Decorator
{
    public abstract class LogWrapper : ILog
    {
        private readonly ILog _log;

        public LogWrapper(ILog log)
        {
            _log = log;
        }

        public virtual void Write(string log)
        {
           _log.Write(log);
        }
    }
}
