using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree searchy = new BSTree();
            searchy.Add(55);
            searchy.Add(22);
            searchy.Add(75);
            searchy.Add(15);
            searchy.Add(100);
            searchy.Add(65);
            searchy.Add(62);
            
            Console.WriteLine(searchy.SearchNode(65));
            Console.ReadKey();
        }
    }
}
