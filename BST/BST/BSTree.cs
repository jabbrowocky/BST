using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BSTree
    {
        private Node head;
        public BSTree()
        {
            
        }
        public void Add(int data)
        {
            Node current = head;
            Node toAdd = new Node(data);

            if (current == null)
            {
                head = toAdd;
                return;
            }
            if (current.Data == toAdd.Data)
            {
                Console.WriteLine("{0} already exists", current.Data);
                return;
            }
            while (current != null)
            {
                if (current.Data < toAdd.Data)
                {
                    if (current.right == null)
                    {
                        current.right = toAdd;
                        return;
                    }
                    current = current.right;

                }
                else if (current.Data > toAdd.Data)
                {
                    if (current.left == null)
                    {
                        current.left = toAdd;
                        return;
                    }
                    current = current.left;
                }
            }
        }
        public bool SearchNode(int toCheck)
        {
            Node current = head;
            List<string> pathLog = new List<string>();
            while (current != null)
            {
                if (current.Data == toCheck)
                {
                    Console.WriteLine(PrintPathDirections(pathLog));
                    return true;
                }
                else if (current.Data < toCheck)
                {
                    current = current.right;
                    pathLog.Add("right");
                }
                else if (current.Data > toCheck)
                {
                    current = current.left;
                    pathLog.Add("left");
                }
                
            }
            return false;

        }
        private string PrintPathDirections(List <string> pathLog)
        {
            StringBuilder pathString = new StringBuilder();
            for (int i = 0; i < pathLog.Count; i++)
            {
                if (i == pathLog.Count - 1)
                {
                    pathString.Append(pathLog[i]);
                }
                else
                {
                    pathString.Append(pathLog[i] + " ");
                }
            }
            return pathString.ToString();
        }

    }
}
