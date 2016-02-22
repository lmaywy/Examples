using System;

namespace Examples.FrameworkClassLibrary.Convertions
{
    /// <summary>
    /// The demo of C# conversion
    /// </summary>
    public class ConversionDemo
    {
        public static void Demo()
        {
            #region implicitly/explicitly conversion between value type
            //implicitly conversion
            int i = 10;
            double j = i; // i to j using implict int => double
            //int k = j; //Cannot implicitly convert type 'double' to 'int' 

            //explicitly conversion using (int) before 'j'
            int k = (int)j;
            float f = 21474836470;
            int l = (int)f; //when the value is exceed the max value of int ,it will be the min value:-2147483648 rather than throw exception
            Console.WriteLine("i:{0},j:{1},k:{2},l:{3}", i, j, k,l);
            #endregion

            #region implicitly/explicitly conversion between reference type,also include 'as' /'is'
            #endregion

            #region using method(.net self method/your customize method) to do conversion like DTO framework automapper
            #endregion

            #region boxing/unboxing & nullable type & operator '??'
            #endregion

        }
    }
}
