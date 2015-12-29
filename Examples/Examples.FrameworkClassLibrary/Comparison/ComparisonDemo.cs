using System;

namespace Examples.FrameworkClassLibrary.Comparison
{
    public class ComparisonDemo
    {
        /// <summary>
        /// Demo Situation:
        ///     Compare value type, reference type and string type using ==,equals,ReferenceEquals
        ///     Given two value type variable with same value
        ///     Then call ==,equals should be true,ReferenceEquals should be false
        ///     Given two reference type variable with same value
        ///     Then call equals should be true,== and ReferenceEquals should be false
        ///     Given two string variable with same value not new
        ///      ==,equals,ReferenceEquals should be true (==,equals only check the value of the string,reference equals need to check the reference address)
        /// </summary>
        public static void Demo()
        {
            /*
            ==比较的是栈内的内容，对于值类型而言，”==“比较的就是两个对象的值，除字符串（字符串类型是一个特殊情况）以外的引用类型比较的就是两个引用类型在栈内的地址
            Equals方法是定义在Object中的虚方法，用来比较两者引用对象的值是否相等，.NET中类型就都可以重写Equals方法，例如，在.NET中string类型就重写了Equals方法，用于比较两个字符串的值是否相等，而不是字符串引用是否相等。
            */
            object obj1 = 1;
            object obj2 = 1;
            object obj3 = obj1;
            Console.WriteLine("object compare using equals:{0} and {1}", obj1.Equals(obj2), obj3.Equals(obj1)); // true and true
            Console.WriteLine("object compare using ==:{0} and {1}", obj1 == obj2, obj3 == obj1); // false and true
            Console.WriteLine("object compare using ReferenceEquals:{0} and {1}", ReferenceEquals(obj3, obj1), ReferenceEquals(obj3, obj2)); // true and false


            //Equals and == : Determines whether this instance and another specified System.String object have the same value.
            //ReferenceEquals : Determines whether the specified System.Object instances are the same instance.
            //notice : String Interning
            string str1 = "A";
            string str2 = "A";
            string str3 = new string(new char[] { 'l', 'i' });
            string str4 = new string(new char[] { 'l', 'i' });
            string str5 = "li";
            Console.WriteLine("string compare using equals:{0} and {1} and {2}", str1.Equals(str2), str3.Equals(str4), str3.Equals(str5)); // true and true and true
            Console.WriteLine("string compare using ==:{0} and {1} and {2}", str1 == str2, str3 == str4, str3 == str5); // true and true and true
            Console.WriteLine("string compare using ReferenceEquals:{0} and {1} and {2}", ReferenceEquals(str1, str2), ReferenceEquals(str3, str4), ReferenceEquals(str3, str5)); // true and false and false

            //Equals and == : Determines whether this instance and another specified System.String object have the same value.
            //ReferenceEquals :false for all value type
            Console.WriteLine("value type compare using ReferenceEquals:{0}", 6 == 6); // false

            //== and ReferenceEquals both is true
            Console.WriteLine("null compare using ==:{0}", null == null);
            Console.WriteLine("null compare using ReferenceEquals:{0}", ReferenceEquals(null, null));
            Console.ReadLine();
        }
    }
}
