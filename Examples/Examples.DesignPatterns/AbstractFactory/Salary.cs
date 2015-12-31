using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.AbstractFactory
{
    public class Salary
    {
        const double BaseMonthlySalary = 4000;

        private IBonus _ibonus;
        private ITax _itax;

        public Salary(IBonus ibonus, ITax itax)
        {
            _ibonus = ibonus;
            _itax = itax;
        }

        public double Calculate()
        {
            var salaryBeforeTax = BaseMonthlySalary + _ibonus.Calculate(BaseMonthlySalary);
            var salaryAfterTax = salaryBeforeTax - _itax.Calculate(salaryBeforeTax);
            return salaryAfterTax;
        }
    }
}
