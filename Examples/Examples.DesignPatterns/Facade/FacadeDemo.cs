using System;
using System.Runtime.InteropServices;

namespace Examples.DesignPatterns.Facade
{
    /// <summary>
    /// Facade Pattern:
    /// 为子系统中的一组接口提供一个一致的界面，Facade模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
    /// </summary>
    public class FacadeDemo
    {
        //without facade pattern
        //client calling every subsystem to check if this customer can do the loan in current situation
        public static void DemoWithoutFacade()
        {
            //declare the customer
            var customer = new Customer() { Name = "ZhangSan" };

            //declare the sub systems(assume these 3 are subsystems)
            var bank = new Bank();
            var loan = new Loan();
            var credit = new Credit();

            //to check if the customer able to loan
            var ret = bank.HasSufficientSavings(customer, 20000) && loan.HasNoBadLoans(customer) && credit.HasGoodCredit(customer);

            Console.WriteLine("Customer {0} is asking loan at bank", customer.Name);
            Console.WriteLine("\n" + customer.Name + " has been " + (ret ? "Approved" : "Rejected"));
            Console.ReadLine();
        }


        /// <summary>
        /// demo with facade pattern
        /// create encapsulate class which contains the subsytem:Bank,Loan,Credit
        /// for client: we can decoupleing the relationship for the subsystems , only focus on the customer and his behavior
        /// </summary>
        public static void DemoWithFacade()
        {
            //declare the customer
            var customer = new Customer() { Name = "ZhangSan" };

            //facade 
            var mortgage = new Mortgage();

            bool eligable = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("Customer {0} is asking loan at bank", customer.Name);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligable ? "Approved" : "Rejected"));
            Console.ReadLine();
        }
    }
}
