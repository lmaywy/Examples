namespace Examples.DesignPatterns.Adapter
{
    public class LogAdpater : ILogTarget  //对象适配器
    {
        private readonly LogAdaptee _adaptee;

        public LogAdpater(LogAdaptee adpatee)
        {
            _adaptee = adpatee;
        }

        public void Write(string message)
        {
            _adaptee.WriteLog(message);
        }
    }


}
