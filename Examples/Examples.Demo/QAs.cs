using System.Collections.Generic;
using System.Data;

namespace Examples.Demo
{
    public class QAs
    {
        public static void Demo()
        {
            var a = DictinctOrders(new List<int>() { 1, 2, 3, 2, 4, 6 });
            var students = DictinctOrders(new List<Person>()
            {
                new Person() {Name = "Zhangsan", Age = 12},
                new Person() {Name = "Zhangsan", Age = 12},
                new Person() {Name = "Lisi", Age = 22},
                new Person() {Name = "Lisi", Age = 22}
            });

            var isEqual0 = StringEqual("", "");
            var isEqual1 = StringEqual(null, null);
            var isEqual2 = StringEqual("", null);
            var isEqual3 = StringEqual("1234", "1234");
            var isEqual4 = StringEqual("123456", "123478");
            var isEqual5 = StringEqual("12", "1234");

        }

        /// <summary>
        /// remove duplicated records using DataView.ToTable
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static DataTable Distinct(DataTable table)
        {
            var view = new DataView(table);
            return view.ToTable(true);
        }


        /// <summary>
        /// using List to remove duplicated records 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IList<T> DictinctOrders<T>(IList<T> data)
        {
            if (data == null || data.Count <= 1)
            {
                return data;
            }
            var noDuplicatedData = new List<T> { data[0] };

            for (int i = 1; i < data.Count; i++)
            {
                var isExsit = false;
                var j = 0;
                for (j = 0; j < noDuplicatedData.Count; j++)
                {
                    if (noDuplicatedData[j].Equals(data[i]))
                    {
                        isExsit = true;
                    }
                }

                if (!isExsit)
                {
                    noDuplicatedData.Add(data[i]);
                }
            }

            return noDuplicatedData;
        }

        public static bool StringEqual(string source, string target)
        {
            if (source == null && target == null)
            {
                return true;
            }
            else if ((source == null && target != null) || (target == null && source != null))
            {
                return false;
            }
            else if (source != null && target != null && source.Length != target.Length)
            {
                return false;
            }
            else
            {
                var arr1 = source.ToCharArray();
                var arr2 = target.ToCharArray();

                for (int i = 0; i < source.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
