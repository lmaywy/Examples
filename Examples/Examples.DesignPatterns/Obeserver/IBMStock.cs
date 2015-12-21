using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Obeserver
{
    public class IBMStock:Stock
    {
        public IBMStock(string name,double price):base( name, price)
        {

        }
    }
}
