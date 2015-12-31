using System;

namespace Examples.Algorithm
{
    public class BubbleSort
    {
        public static int[] Sort(int[] array, string orderby="asc")
        {
            Console.WriteLine("Bubble sort by {0}, source:{1}", orderby, string.Join("", array));
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    switch (orderby)
                    {
                        case "desc":
                            if (array[j] < array[j+1])  //desc
                            {
                                var tmp = array[j];
                                array[j] = array[j+1];
                                array[j+1] = tmp;
                            }
                            break;
                        case "asc":
                            if (array[j] > array[j+1])  //asc
                            {
                                var tmp = array[j];
                                array[j] = array[j+1];
                                array[j+1] = tmp;
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
