using System;

namespace NodeInitialization_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Node<int> node = Node<int>.intNode("1 2 3 4 5"); ;
            Node<string> strNode = Node<string>.stringNode("this is a test");
            Node<int>.printNode(node);
            Console.WriteLine($"the length of the node is: {node.gitIntNodeCounter()}");
            Console.WriteLine("str node");
            Node<string>.printNode(strNode);
            Console.WriteLine($"str node length {strNode.gitStrNodeCounter()}");

            Console.ReadKey();
        }
      

    }
}
 