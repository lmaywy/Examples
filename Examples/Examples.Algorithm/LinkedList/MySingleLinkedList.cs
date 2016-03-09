using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Algorithm.LinkedList
{
    public class MySingleLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public int Length
        {
            get
            {
                Node<T> p = Head;
                int len = 0;
                while (p != null)
                {
                    ++len;
                    p = p.Next;
                }
                return len;
            }
        }

        //在单链表的末尾添加新元素  
        public void Append(T item)
        {
            var node = new Node<T>(item);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                var p = Head;
                while (p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = node;
            }
        }

        public Node<T> Reverse()
        {
            Node<T> newNode = null;
            Node<T> current = Head;

            while (current != null)
            {
                Head = current.Next;
                current.Next = newNode;
                newNode = current;
                current = Head;
            }
            Head = newNode;
            return Head;
        }

        public void Display()
        {
            Node<T> p = new Node<T>();
            p = Head;
            while (p != null)
            {
                Console.Write(p.Data + " ");
                p = p.Next;
            }
        }

        public Node<T> IndexOf(int index)
        {

            var i = 0;
            var node = Head;
            while (i <= index && index < Length && node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T item, Node<T> node)
        {
            Data = item;
            Next = node;
        }


        public Node(T value)
        {
            Data = value;
        }

        public Node()
        {
        }
    }
}
