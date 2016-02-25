using System;

namespace Examples.FrameworkClassLibrary.Exceptions
{
    public class ExceptionDemo
    {
        public static void Demo()
        {
            try
            {
                Add(1000, 10);
            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine("Exception details:");
                Console.WriteLine("StackTrace:{0}", ex.StackTrace);
                Console.WriteLine("Message:{0}", ex.Message);
                Console.WriteLine("Source:{0}", ex.Source);
                Console.WriteLine("TargetSite:{0}", ex.TargetSite);
                Console.WriteLine("HelpLink:{0}", ex.HelpLink);
            }
            finally
            {
                Console.WriteLine("finally code block should be called whether the exception occurs or not ");
            }
        }

        private static int Add(int a, int b)
        {
            if (a > 100)
            {
                throw new InvalidArgumentException("arguments should not >100");
            }
            return a + b;
        }
    }

    class InvalidArgumentException : Exception
    {
        internal InvalidArgumentException(string exceptionMessage) : base(exceptionMessage)
        {

        }
    }
}
