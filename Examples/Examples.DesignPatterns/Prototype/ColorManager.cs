using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Prototype
{
    public class ColorManager
    {
        Hashtable colors = new Hashtable();

        public ColorPrototype this[string name]

        {
            get
            {
                return (ColorPrototype)colors[name];
            }
            set
            {
                colors.Add(name, value);
            }
        }
    }
}
