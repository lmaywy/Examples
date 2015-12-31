using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Algorithm.Sort
{
    public class SelectSort
    {
        public static int[] Sort(int[] array, string orderby = "asc")
        {
            Console.WriteLine("Select sort by {0}, source:{1}", orderby, string.Join("", array));
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    switch (orderby)
                    {
                        case "desc":
                            if (array[i] < array[j])  //desc
                            {
                                var tmp = array[i];
                                array[i] = array[j];
                                array[j ] = tmp;
                            }
                            break;
                        case "asc":
                            if (array[i] > array[j])  //asc
                            {
                                var tmp = array[i];
                                array[i] = array[j];
                                array[j] = tmp;
                            }
                            break;
                        default:
                            break;
                    }

                }
            }
            Console.WriteLine("result:{0}", string.Join("", array));
            return array;
        }
    }
}
