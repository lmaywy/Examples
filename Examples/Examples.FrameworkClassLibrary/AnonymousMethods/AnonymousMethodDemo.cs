using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples.FrameworkClassLibrary.AnonymousMethods
{
    public class AnonymousMethodDemo
    {
        delegate int TestDelegate(int a, int b);
        delegate TResult Func<TArgs, TResult>(TArgs arg0);
        private static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Demo()
        {
            #region create delegate instance using new/anonymous method/lambda
            // using new delegate to create TestDelegate instance
            TestDelegate d = new TestDelegate(Add); // TestDelegate d =Add;

            var result = d(1, 3); //also can call like this:d.Invoke(1, 3)

            // using Anonymous method to create TestDelegate instance
            TestDelegate d1 = delegate (int a, int b) { return a - b; }; //a,b can't be ref/out
            var result1 = d1.Invoke(5, 3);

            // using lambda expression to create TestDelegate instance 
            TestDelegate d2 = (int a, int b) => { return a * b; }; //(int a, int b) to (a,b) also works
            var result2 = d2.Invoke(3, 10);


            //using no parameter anonymous/lambda expression
            Thread thread = new Thread(delegate ()
              {
                  Console.WriteLine("using anonymous method");
              });
            thread.Start();

            Thread thread2 = new Thread(() =>
            {
                Console.WriteLine("using lambda method");
            });
            thread2.Start();
            #endregion

            #region lambda grammar
            //grammar:([parameter list])=>{expression/code block}
            TestDelegate del = (x, y) => x + y;
            TestDelegate del2 = (x, y) => { return x + y; };
            #endregion

            #region lambda with generic type
            Func<int, bool> func = x => x % 5 == 0;
            Console.WriteLine(func(10));
            #endregion
        }


    }
}
