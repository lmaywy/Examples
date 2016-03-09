using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Algorithm.Trees
{
    public class BinaryTreeDemo
    {

        public static void TraversalDemo()
        {
            var tree = new BinaryTree<int>(new Node<int>
            {
                Data = 1,
                LNode = new Node<int> { Data = 5 },
                RNode = new Node<int> { Data = 6 }
            });

            tree.PreTraversal(tree.Head);
            tree.MidTraversal(tree.Head);
            tree.AfterTraversal(tree.Head);
        }
    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> LNode { get; set; }
        public Node<T> RNode { get; set; }

        public Node() { }

        public Node(T value)
        {
            Data = value;
        }
    }

    public class BinaryTree<T>
    {
        public Node<T> Head { get; set; }

        public BinaryTree()
        {
        }

        public BinaryTree(Node<T> head)
        {
            Head = head;
        }
        
        #region tree traversal
        public void PreTraversal(Node<T> rootNode)
        {
            if (rootNode != null)
            {
                Console.WriteLine(rootNode.Data);
                PreTraversal(rootNode.LNode);
                PreTraversal(rootNode.RNode);
            }
        }

        public void MidTraversal(Node<T> rootNode)
        {
            if (rootNode != null)
            {
                MidTraversal(rootNode.LNode);
                Console.WriteLine(rootNode.Data);
                MidTraversal(rootNode.RNode);
            }
        }

        public void AfterTraversal(Node<T> rootNode)
        {
            if (rootNode != null)
            {
                AfterTraversal(rootNode.LNode);
                AfterTraversal(rootNode.RNode);
                Console.WriteLine(rootNode.Data);
            }
        }
        #endregion
    }
}
