using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Prototype
{
    class ConcteteColorPrototype : ColorPrototype
    {
        private int _red, _green, _blue;

        public ConcteteColorPrototype(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override ColorPrototype Clone()
        {
            return (ColorPrototype)this.MemberwiseClone();
        }

        public void Display(string _colorname)
        {
            Console.WriteLine("{0}'s RGB Values are: {1},{2},{3}", _colorname, _red, _green, _blue);
        }
    }
}
