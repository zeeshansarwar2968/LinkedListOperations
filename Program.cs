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
            obj.InsertFront(70);
            obj.InsertFront(30);
            obj.InsertFront(56);
            //Display Operation
            Console.WriteLine("*****Insertion at First*****");
            obj.Display();

            Console.ReadKey();
        }
    }
}
