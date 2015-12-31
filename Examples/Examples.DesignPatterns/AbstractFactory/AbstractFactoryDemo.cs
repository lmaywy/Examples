using System;
using System.Configuration;

namespace Examples.DesignPatterns.AbstractFactory
{
    /// <summary>
    /// demo sutiation:
    ///     given developer using factory pattern to get a series instance of classes (product cluster)
    ///     when using app.config to toggle which concreate class should be 
    ///     then using reflection to resolve the concrete factory to instance the related class
    /// </summary>
    public class AbstractFactoryDemo
    {
        public static readonly string factoryName = ConfigurationManager.AppSettings["abstractFactoryName"].ToString();
        public static void Demo()
        {
            var factory =(SalaryFactory)Activator.CreateInstance(Type.GetType(factoryName));
            var salaryCalculator = new Salary(factory.CreateBonus(), factory.CreateTax());
            var salary = salaryCalculator.Calculate();
            Console.WriteLine("{1} Your salary is:{0}", "", salary);
        }
    }
}
