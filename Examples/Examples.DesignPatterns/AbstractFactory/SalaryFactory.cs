using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.AbstractFactory
{
    public abstract class SalaryFactory
    {
        public abstract IBonus CreateBonus();
        public abstract ITax CreateTax();
    }

    public class ChineseSalaryFactory : SalaryFactory
    {
        public override IBonus CreateBonus()
        {
            return new ChineseBonus();
        }

        public override ITax CreateTax()
        {
            return new ChineseTax();
        }
    }

    public class USASalaryFactory : SalaryFactory
    {
        public override IBonus CreateBonus()
        {
            return new USABonus();
        }

        public override ITax CreateTax()
        {
            return new USATax();
        }
    }
}
