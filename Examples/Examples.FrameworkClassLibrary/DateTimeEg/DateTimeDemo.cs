using System.Globalization;
using System;

namespace Examples.FrameworkClassLibrary.DateTimeEg
{
    public class DateTimeDemo
    {
        public static void Demo()
        {
            // parse the given format datetime string to datetime type using CurrentCulture 
            var date = DateTime.ParseExact("05/12/2015", "dd/MM/yyyy", CultureInfo.CurrentCulture);
        }
    }
}
