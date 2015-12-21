namespace Examples.DesignPatterns.Singleton
{
    /// <summary>
    /// safe thread singleton : safe under mutiple threads
    /// double check to make sure there is only instance of the singleton class
    /// but can lazy loading, avoid to instantiation at the first run time
    /// </summary>
    public class SafeThreadSingleton: Counter
    {
        private static SafeThreadSingleton _instance=null;
        private readonly object _padlock = new object();

        public SafeThreadSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock) // only one thread can excute this inside logic
                    {
                        if (_instance == null)
                        {
                            _instance = new SafeThreadSingleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
