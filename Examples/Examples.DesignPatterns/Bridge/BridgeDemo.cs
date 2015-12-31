namespace Examples.DesignPatterns.Bridge
{
    /// <summary>
    ///  given log need two  dimensions extended one is for different log way(database,textfile ..) and the other is on different platforms:.net / java
    ///  when the first using inheritance to extend and the other using object combination to extended (using implementor for different platforms)
    ///  then this should follow Bridge pattern.
    /// </summary>
    public class BridgeDemo
    {
        public static void Demo()
        {
            //.NET平台下的Database Log

            Log dblog = new DatabaseLog();
            dblog.Implementor = new NImpLog();
            dblog.Write();

            //Java平台下的Text File Log
            Log txtlog = new TextLog();
            txtlog.Implementor = new JImpLog();
            txtlog.Write();
        }
    }
}
