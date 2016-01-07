using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amout)
        {
            Console.WriteLine("Check bank for " + c.Name);
            if (amout > 10000)
                return true;
            else
                return false;
        }
    }
}
