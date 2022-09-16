using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInitialization_01
{
    internal class Node<T>
    {
        private T val;
        private Node<T> next;
        static private int intNodeCounter =0;
        static private int stringNodeConter=0;

        public T Val { get { return val; } set { val = value; } }
        public Node<T> Next { get { return next; } set { next = value; } }

        public Node(T val)
        {
            if(val is int)
            {
              intNodeCounter++;
            }
            if (val is string)
                stringNodeConter++;

            Val = val;
            Next = null;
            

        }
        public Node(T val, Node<T> next)
        {
            if (val is int)
                intNodeCounter++;

            if (val is string)
                stringNodeConter++;

            Val = val;
            Next = next;
            
        }
        public int gitIntNodeCounter() => intNodeCounter;
        public static Node<int> intNode(string str)
        {
            Node<int> node = null;
            string n = "";
            int intN = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[str.Length - 1 - i] != ' ')
                {
                    n = str[str.Length - 1 - i] + n;
                }
                if (str[str.Length - 1 - i] == ' ' || i == str.Length - 1)
                {
                    intN = int.Parse(n);
                    n = "";

                    node = new Node<int>(intN, node);

                }
            }

            return node;
        }
        public static void printNode(Node<T> node)
        {
            while(node != null)
            {
                Console.Write(node);
                node = node.Next;
            }
            Console.WriteLine("null");
        }

        public override string ToString()
        {
            return $"{val} -> ";
        }
    }
}
