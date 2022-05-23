using System;

namespace LinkedListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Linked List Implementation in C#");
            Console.WriteLine("");
            Console.WriteLine("1.Inserted into list(From Last)");
            Console.WriteLine("2.Inserted into list(Front)");
            Console.WriteLine("3.Inserting in middle");
            Console.WriteLine("4.Delete the First Element");
            Console.WriteLine("5.Delete the Last Element");
            Console.WriteLine("6.Searching the Element");
            Console.WriteLine("7.Searching and Inserting an Element");
            Console.WriteLine("");


            Console.WriteLine("\t\t\t\t\t\tEnter 0 to exit");
            Console.WriteLine("");

            //Creating object for Custom Linked list class
            Operations obj = new Operations();
            bool flag = true;
            
            while (flag)
            {
                Console.Write("Please enter your option to execute : ");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 0:
                        flag = false;
                        break;
                    case 1:
                        obj.InsertLast(56);
                        obj.InsertLast(30);
                        obj.InsertLast(70);
                        obj.Display();
                        Console.WriteLine("");

                        break;
                    case 2:
                        obj.InsertFront(56);
                        obj.InsertFront(30);
                        obj.InsertFront(70);
                        obj.Display();
                        Console.WriteLine("");

                        break;
                    case 3:
                        obj.InsertLast(56);
                        obj.InsertLast(70);
                        obj.InsertBetween(2, 30);
                        obj.Display();
                        Console.WriteLine("");
                        break;
                    case 4:
                        obj.InsertFront(56);
                        obj.InsertFront(30);
                        obj.InsertFront(70);
                        Console.WriteLine("Before delete operation : ");
                        obj.Display();
                        //Console.WriteLine("");

                        obj.DeleteFirst();
                        Console.WriteLine("After delete operation : ");
                        obj.Display();
                        Console.WriteLine("");

                        break;
                    case 5:
                        obj.InsertLast(56);
                        obj.InsertLast(30);
                        obj.InsertLast(70);
                        obj.DeleteLast();
                        obj.Display();
                        break;
                    case 6:
                        obj.InsertLast(56);
                        obj.InsertLast(30);
                        obj.InsertLast(70);
                        obj.Search(30);
                        break;
                    case 7:
                        obj.InsertLast(56);
                        obj.InsertLast(30);
                        obj.InsertLast(70);
                        obj.Insert(30, 40);
                        obj.Display();
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid option");
                        break;

                }
            }
           

            //Console.ReadKey();
        }
    }
}
