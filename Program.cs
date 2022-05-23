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
            obj.Append(56);
            obj.Append(30);
            obj.Append(70);
            //Display Operation
            //Console.WriteLine("*****Appending*****");
            obj.Display();

            Console.ReadKey();
        }
    }
}
