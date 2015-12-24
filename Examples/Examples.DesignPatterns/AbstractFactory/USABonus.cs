using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.AbstractFactory
{
    public class USABonus : IBonus
    {
        public double Calculate(double salary)
        {
            return salary * 0.6;
        }
    }
}
