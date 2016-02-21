using System;
using System.Linq;

namespace Examples.FrameworkClassLibrary.ExtensionMethods
{
    public class ExtensionDemo
    {
        public static  void Demo()
        {
            int[] arr = { 10,5,20,34,2,7};
            arr.OrderBy(o => o); //System.Linq namespace extension this method for this IEnumerable<TSource> type

            //using the customized one
            var date = DateTime.Now;
            Console.WriteLine(date.ToShortString());
        }
    }

    /// <summary>
    /// 扩展方法必须写在静态类里面，
    /// 扩展方法必须为静态方法，
    /// 扩展方法必须指明扩展哪个类，利用this type,this DateTime date
    /// </summary>
    public static class DateExtension
    {
        public static string ToShortString(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
    }
}
