using System;
using System.Configuration;
using System.Reflection;

namespace Examples.DesignPatterns.Factory
{
    public class FactoryDemo
    {
        public static void Demo()
        {
            string factoryName = ConfigurationSettings.AppSettings["factoryName"];
            Console.WriteLine("---------Factory Pattern Demo start-------");

            //var factory=new FileFactory();
            var assemblyName = Assembly.GetAssembly(typeof(ILogFactory)).FullName;
            ILogFactory factory = (ILogFactory)Assembly.Load(assemblyName).CreateInstance(assemblyName+factoryName);
            var log = factory.Create();
            log.Write("logging test info");
            Console.WriteLine("---------Factory Pattern Demo end-------\n");
        }
    }
}
