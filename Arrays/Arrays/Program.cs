using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(8);
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.Insert(50);
            array.Insert(60);
            array.Insert(70);
            array.Insert(80);
            //array.PrintArray();

            //Console.WriteLine(array.ElementAt(4));
            System.Console.WriteLine("\n\n");

            //array.RemoveAt(0);

            array.PrintArray();
            array.RemoveAt(4);
            System.Console.WriteLine(array.IndexOf(60));

            Console.ReadLine();

        }
    }
}
