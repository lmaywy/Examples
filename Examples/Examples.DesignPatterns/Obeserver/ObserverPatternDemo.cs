namespace Examples.DesignPatterns.Obeserver
{
    /// <summary>
    /// demo situation: 
    ///     given lots of app subscribed the different companies' stocks latest data
    ///     when the price changes
    ///     should notify all the related apps to show the latest price
    /// </summary>
    public class ObserverPatternDemo
    {
        public static void Demo()
        {
            var andirodApp = new TongHuaShunApp { Name = "同花顺安卓app客户端" };
            var iosApp = new TongHuaShunApp {Name = "同花顺ios app客户端"};
            var ibmStock = new IBMStock("IBM", 65);
            var emcStock = new EmcStock("EMC", 33);

            ibmStock.AddObserver(andirodApp);
            ibmStock.AddObserver(iosApp);
            ibmStock.Notify();

            emcStock.AddObserver(iosApp);
            emcStock.Notify();
        }
    }
}
