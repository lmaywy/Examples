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

            Console.WriteLine("Customer {0} is asking loan at bank");

            if (ret)
            {
                Console.WriteLine("he can loan");
            }
            else
            {
                Console.WriteLine("He can't loan because his conditions are not satisfied ");
            }
        }
    }
}
