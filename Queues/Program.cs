using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue(5);

            queue.Add(20);
            queue.Add(50);
            queue.Add(30);
            queue.Add(40);
            queue.Add(10);
            Console.WriteLine(queue.Peek());
            queue.Remove();

            Console.ReadLine();

        }
    }
}
