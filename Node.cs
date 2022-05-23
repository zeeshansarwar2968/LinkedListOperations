using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOperations
{
    internal class Node
    {
        //creating a Node to store the data points in the list
        public int data;
        public Node next;

        //constructor to initialise the declared variables
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
