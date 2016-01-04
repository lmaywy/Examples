using System.Globalization;
using System;
using System.Threading;

namespace Examples.FrameworkClassLibrary.DateTimeEg
{
    public class DateTimeDemo
    {
        public static void Demo()
        {
            DateTime c;

            // parse the given format datetime string to datetime type using CurrentCulture 
            var date = DateTime.ParseExact("05/12/2015", "MM/dd/yyyy", CultureInfo.CurrentCulture);

            //将日期和时间的字符串表示形式转换为其等效的 DateTime。
            var date1 = DateTime.Parse("05/12/2015");

            var seconds = TimeSpan.FromMilliseconds(1000);

            Thread.Sleep(seconds);
        }
    }
}
