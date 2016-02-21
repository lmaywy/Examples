using System;
using System.Collections.Generic;
using System.Linq;

namespace Examples.FrameworkClassLibrary.Linq
{
    public class LinqDemo
    {
        public static void Demo()
        {
            #region linq overview
            //inherit IEnumberable
            //set datasource
            int[] numbers = { 1,4,5,6,7,2,9,8,3};

            //using system.linq 
            //linq: 
            //1.query , lazy load
            var even = from num in numbers
                      where num % 2 == 0
                      orderby num 
                      select num;

            //excution
            foreach (var item in even)  // query excution when access them
            {
                Console.Write("{0} ", item);
            }

            //2.method using lamda
            var even2 = numbers.Where(n => n % 2 == 0).OrderBy(n=>n); // lazy load

            //excution
            foreach (var item in even2)
            {
                Console.Write("{0} ", item);
            }
            #endregion

            #region linq basic operations
            //linq basic operations
            var customers = new List<Customer>
            {
                new Customer {Name="li Lei",Address="Shanghai" },
                new Customer {Name="Wang meimei",Address="Shanghai" },
                new Customer {Name="Zhang san",Address="Beijing" },
            };

            //using group in linq
            var customersGBAddress = from c in customers
                                     group c by c.Address; // group by 之后不能用select
            Console.WriteLine();
            foreach (var item in customersGBAddress)
            {
                Console.WriteLine(item.Key);
                item.ToList().ForEach(c => Console.WriteLine(" {0}", c.Name));
            }

            // using join to collect two datasource then select the data you wanted
            var orders = new List<Order>
            {
                new Order {CustomerName="li Lei",TotalPrice=2000 },
                new Order {CustomerName="Wang meimei",TotalPrice=3000 },
            };

            var detailOrders = from o in orders
                               join c in customers on o.CustomerName equals c.Name
                               orderby o.TotalPrice
                               select new
                               {
                                   name=o.CustomerName,
                                   addr=c.Address,
                                   totalPrice=o.TotalPrice
                               };

            foreach (var item in detailOrders)
            {
                Console.WriteLine("{0}-{1}:{2}", item.name, item.addr, item.totalPrice);
            }

            //using into to create a temp variable for group  by result in query
            //using group in linq
            var customersInto = from c in customers
                                group c by c.Address into cusGroup
                                where cusGroup.Count() == 1
                                select cusGroup;

            Console.WriteLine();
            foreach (var item in customersInto)
            {
                Console.WriteLine(item.Key);
                item.ToList().ForEach(c => Console.WriteLine(" {0}", c.Name));
            }

            //using key word 'let' to create temp variable for query
            string warms = "Hello Linq, it's nice to see you";
            var upperWords = from c in warms.Split(' ')
                             let u = c.ToUpper()
                             select u;
            
            #endregion
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Order
    {
        public string CustomerName { get; set; }
        public int TotalPrice { get; set; }
    }
}
