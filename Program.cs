using System;

namespace LinkedListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Linked List Implementation in C#");

            //UseCase 1 : Append the numbers into a list
            Operations obj = new Operations();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertLast(54);
            obj.InsertLast(45);
            obj.InsertLast(78);
            obj.InsertLast(21);
            obj.InsertLast(70);
            obj.Display();
            Console.WriteLine("*************************");

            obj.InsertBetween(5, 30);
            //obj.InsertBetween(2, 40);
            //obj.InsertBetween(3, 74);
            //obj.InsertBetween(6, 40);

            //Display Operation
            Console.WriteLine("*****Insertion at Last*****");
            obj.Display();

            Console.ReadKey();
        }
    }
}
