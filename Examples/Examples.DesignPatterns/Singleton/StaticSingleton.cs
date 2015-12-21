using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Singleton
{
    /// <summary>
    /// sealed static singleton
    /// avoid to inherit to mutiple instance, but not lazy loading
    /// </summary>
    public sealed class StaticSingleton : Counter
    {
        private static StaticSingleton _instance=new StaticSingleton(); // can't lazy loading

        public static StaticSingleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
