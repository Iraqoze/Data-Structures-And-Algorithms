using System;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();
            tree.Insert(10);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(50);
            Console.ReadLine();
        }
    }
}
