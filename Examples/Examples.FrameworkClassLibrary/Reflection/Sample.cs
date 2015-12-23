using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Examples.FrameworkClassLibrary.Reflection
{
    class Sample : ISample
    {
        public string Name { get; set; }
        public string Age;

        public void ShowName()
        {
            Console.WriteLine("Public method to show Name Property value:{0}", Name);
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("implement the method which inherited from interface");
        }

        public void PublicMethodWithParameters(string arg0, string arg1)
        {
            Console.WriteLine("Public Method invoked , the parameters:{0},{1}", arg0, arg1);
        }
    }

    interface ISample
    {
        void InterfaceMethod();
    }
}
