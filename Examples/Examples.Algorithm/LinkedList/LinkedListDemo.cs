using System;
using System.Collections.Generic;
using System.Linq;

namespace Examples.Algorithm.LinkedList
{
    public class LinkedListDemo
    {
        public static LinkedList<int> RemoveDuplicated(LinkedList<int> lst)
        {
            if (lst == null || lst.Count == 0)
            {
                return lst;
            }
            var node = lst.First;
            var result = new LinkedList<int>();
            while (node != null)
            {
                if (!result.Contains(node.Value))
                {
                    result.AddLast(node.Value);
                }

                node = node.Next;
            }
            return result;
        }
    }
}
