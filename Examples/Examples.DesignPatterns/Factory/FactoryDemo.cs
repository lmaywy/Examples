using System;
using System.Configuration;
using System.Reflection;

namespace Examples.DesignPatterns.Factory
{
    public class FactoryDemo
    {
        /// <summary>
        /// demo sutiation:
        ///     given developer using factory pattern to get a instance of class
        ///     when using app.config to toggle which concreate class should be 
        ///     then using reflection to resolve the instance of the concreate class
        /// </summary>
        public static void Demo()
        {
            string factoryName = ConfigurationManager.AppSettings["factoryName"]; // need to add reference:system.Configuration
            Console.WriteLine("---------Factory Pattern Demo start-------");

            //var factory=new FileFactory(); 
            //var assemblyName = Assembly.GetAssembly(typeof(ILogFactory)).FullName;
            //var factory = (ILogFactory)Assembly.Load(assemblyName).CreateInstance(factoryName);
            var factory = (ILogFactory)Activator.CreateInstance(Type.GetType(factoryName)); 
            var log = factory.Create();
            log.Write("logging test info");
            Console.WriteLine("---------Factory Pattern Demo end-------\n");
        }
    }
}
