using System;
using System.Collections.Generic;

namespace Examples.FrameworkClassLibrary.Indexers
{
    class Sample : ISample
    {
        private int[] arr = { 100, 200, 300, 400 };
     
        public int this[int i]
        {
            get
            {
                if (i < 4 && i >= 0)
                {
                    return arr[i];
                }
                return 0;
            }

            set
            {
                if (i < 4 && i >= 0)
                {
                    arr[i] = value * 100 + i;
                }
            }
        }
    }
}
