using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Demo
{
    public class QAs
    {
        public static void Demo()
        {
            var a = QAs.DictinctOrders(new List<int>() { 1, 2, 3, 2, 4, 6 });
            var students = QAs.DictinctOrders(new List<Person>()
            {
                new Person() {Name = "Zhangsan", Age = 12},
                new Person() {Name = "Zhangsan", Age = 12},
                new Person() {Name = "Lisi", Age = 22},
                new Person() {Name = "Lisi", Age = 22}
            });

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



    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
