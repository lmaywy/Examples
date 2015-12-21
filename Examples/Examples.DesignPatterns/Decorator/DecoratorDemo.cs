namespace Examples.DesignPatterns.Decorator
{
    /// <summary>
    /// demo situation: 
    ///     given a log writter
    ///     when extends function:set priority/ error function using warpper
    ///     should the log function been extended using decorator pattern
    /// advantage:
    ///     avoiding using lots of inheritance hierarchy
    /// </summary>
    public class DecoratorDemo
    {
        public static void Demo()
        {
            //对textLog对象包装两次，分别扩展Set Error和Set Priority功能
            var textLog =new TextFileLog();
            var errorLog=new LogErrorWrapper(textLog);
            var priorityLog=new LogPriorityWarpper(errorLog); 
            priorityLog.Write("text file logging start");

            //对textLog对象包装一次，分别扩展Set Priority功能
            var dblog=new DatabaseLog();
            var prLog=new LogPriorityWarpper(dblog);
            prLog.Write("database logging start");
        }
    }
}
