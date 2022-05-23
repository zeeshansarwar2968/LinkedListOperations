using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOperations
{
    internal class Operations
    {
        //Creating a head node to point to the first element in the list
        public Node head;
        
        //Creating a method to insert last 
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list from last " + new_node.data);
        }

        //Creating a method to insert at the front of the list 
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted the list in front " + new_node.data);
        }

        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        //Appending a new node
        public void Append(int newData)
        {
            Node newNode = new Node(newData);
            //check linkedlist empty 
            if (head == null)
            {
                head = newNode;

            }
            else
            {
                //traverse to last node
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;

            }
        }

        //Display the nodes
        public void Display()
        {
            Console.WriteLine("**********Displaying Nodes************");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }

    }
}
