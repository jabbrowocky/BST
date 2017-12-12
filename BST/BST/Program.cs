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
            
            Console.WriteLine(searchy.SearchNode(15));
            Console.ReadKey();
        }
    }
}
