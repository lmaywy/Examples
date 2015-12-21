namespace Examples.DesignPatterns.Obeserver
{
    public interface IObserver
    {
        string Name { get; set; }
        void DisplayLatestPrice(Stock stock);
    }
}
