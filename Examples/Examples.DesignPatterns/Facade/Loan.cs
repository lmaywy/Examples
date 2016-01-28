using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Facade
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine("Check loans for " + customer.Name);
            return true;
        }
    }
}
