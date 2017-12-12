using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Node
    {
        int data;
        public Node left;
        public Node right;
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node()
        {

        }
        public Node(int data)
        {
            this.data = data;
        }
        
    }
}
