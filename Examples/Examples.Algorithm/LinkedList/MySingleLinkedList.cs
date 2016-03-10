using System;

namespace Examples.Algorithm.LinkedList
{
    public class MySingleLinkedListDemo
    {
        public static void Demo()
        {
            var list = new MySingleLinkedList<int>()
            {
                Head = new Node<int>
                {
                    Data = 10
                }
            };
            list.Append(11);
            list.Append(12);
            list.Append(13);
            list.Append(14);
            list.ReverseFromIndex(3);

            var node = list.IndexOf(6);
            list.Display();
            list.ReverseFromIndex(3);
            list.Reverse(list.Head);
            list.Display();

        }
    }

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

        public Node<T> Reverse(Node<T> node)
        {
            Node<T> newNode = null;
            Node<T> current = node;

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

        public Node<T> Reverse(Node<T> node, int i, int v)
        {
            Node<T> newNode = null;
            Node<T> current = node;

            while (current != null && i < v)
            {
                Head = current.Next;
                current.Next = newNode;
                newNode = current;
                current = Head;
                i++;
            }
            Head = newNode;
            return Head;
        }

        public Node<T> ReverseFromIndex(int v)
        {
            var node = new Node<T>();
            for (int i = 0; i < Length / v; i = i + v)
            {
                //node = IndexOf(i);
                node = Remove(0, 2);
                node = Reverse(node, i, v);

            }

            return node;
        }

        public Node<T> Remove(int index, int length)
        {
            Node<T> p = new Node<T>();
            p = Head;
            var i = 0;
            var newNode = p;
            while (p != null && i > length && i < index + length)
            {

                Console.Write(p.Data + " ");
                if (i == index)
                {
                    newNode = p;
                }
                if (i == index + length)
                {
                    p.Next = null;

                }
                p = p.Next;
                i++;
            }

            return newNode;
        }

        /// <summary>
        /// 显示List中的data
        /// </summary>
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

        /// <summary>
        /// 取出给定下标的node
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Node<T> IndexOf(int index)
        {
            var i = 0;
            var node = index == 0 ? Head : new Node<T>();
            while (i < index && index < Length && node.Next != null)
            {
                node = node.Next;
                i++;
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
