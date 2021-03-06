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
        public void InsertLast(int newData)
        {
            Node newNode = new Node(newData);
            //check if linkedlist is empty 
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("Inserted into list from the end : " + newNode.data);
        }


        //Creating a method to insert at the front of the list 
        public void InsertFront(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("Inserted the list in front " + newNode.data);
        }

        
        //Appending a new node
        public void Append(int newData)
        {
            Node newNode = new Node(newData);
            //check if linkedlist is empty 
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

        //Method/function to insert values in the middle of the list
        public void InsertBetween(int pos, int newData)
        {
            Node newNode = new Node(newData);
            if (pos == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else if (pos <= 0)
            {
                Console.WriteLine("Invalid Position!!!");
            }
            else if (pos > 0)
            {
                Node temp = head;
                while (pos != 0)
                {
                    if (pos == 2)
                    {
                        Console.WriteLine("==> Insertion performed between two nodes");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(pos);
                    pos--;
                }

            }
        }

        //Deleting first element stored in the list
        //Deleting the first node
        public Node DeleteFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }


        //Delete Last element stored in the list
        public Node DeleteLast()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return newNode;

        }

        //Searching the particular element in linked list
        public Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Element found.. " + value);
                    return temp;
                }
                temp = temp.next;

            }
            Console.WriteLine("Element not found!!!!!!!!");
            return default;
        }

        //Searching the particular element
        //-->If element is found,then after that insert the element..
        public int Insert(int searchdata, int data)
        {
            Node temp = Search(searchdata);
            Node newNode = new Node(data);
            newNode.next = temp.next;
            temp.next = newNode;
            return (newNode.data);

        }

        //search and delete method

        public int DeleteInBetween(int value)
        {
            Node temp = head;
            
            
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                int size = Size();
                return size;
            }
            while (temp.next != null)
            {
                if (temp.next.data == value)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("The value " + value + " is deleted from the list");
                }
                temp = temp.next;
            }

            int sizeofList = Size();
            return sizeofList;
        }
        public int Size()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        //sorting
        public void Sort()
        {
            Node i, j;
            int temp;
            for (i = this.head; i.next != null; i = i.next)
            {
                for (j = i.next; j != null; j = j.next)
                {
                    if (i.data > j.data)
                    {
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
            }
        }


        //Display the nodes
        public void Display()
        {
            Console.WriteLine("---------------Displaying Nodes---------------");
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
                    Console.Write( temp.data + " -> ");
                    temp = temp.next;
                }
            }
            Console.WriteLine("");
        }

    }
}
