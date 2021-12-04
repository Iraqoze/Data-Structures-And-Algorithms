using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            System.Console.WriteLine("ADDING FIRST/ LAST\n");
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(50);

            System.Console.WriteLine("\nINDEX OF\n");
            Console.WriteLine(linkedList.IndexOf(40));

            System.Console.WriteLine("\nCONTAINS\n");
            System.Console.WriteLine(linkedList.Contains(20));
            Console.WriteLine(linkedList.Contains(70));

            System.Console.WriteLine("\nREMOVE FIRST\n");
            // linkedList.RemoveFirst();

            System.Console.WriteLine("\nREMOVE FIRST\n");
            // linkedList.RemoveLast();

            System.Console.WriteLine("\nKTH NODE\n");
            Console.WriteLine(linkedList.KthNode(2));

            System.Console.WriteLine("\nTO ARRAY\n");
            var array = linkedList.ToArray();
            foreach (var value in array)
                Console.WriteLine(value);

            System.Console.WriteLine("CLEAR THE LIST\n");
            //linkedList.Clear();

            linkedList.Reverse();
            Console.ReadLine();
        }
    }
}
