using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree bst1 = new Tree();

            bst1.Insert(30);
            bst1.Insert(10);
            bst1.Insert(5);
            bst1.Insert(20);
            bst1.Insert(15);
            bst1.Insert(26);
            bst1.Insert(1);
            bst1.Insert(8);
            bst1.Insert(50);
            bst1.Insert(45);
            bst1.Insert(60);
            bst1.Insert(55);
            bst1.Insert(70);

            Tree bst = new Tree();

            bst.Insert(30);
            bst.Insert(10);
            bst.Insert(5);
            bst.Insert(20);
            bst.Insert(15);
            bst.Insert(26);
            bst.Insert(1);
            bst.Insert(8);
            bst.Insert(50);
            bst.Insert(45);
            bst.Insert(60);
            bst.Insert(55);
            bst.Insert(80);
            //System.Console.WriteLine(bst.Find(60));
            //System.Console.WriteLine(bst.Find(10));

            Console.WriteLine("\nPREORDER TRAVERSAL\n");
            bst1.PreOrderTraversal();
            Console.WriteLine("\nINORDER TRAVERSAL\n");
            bst1.InOrderTraversal();
            Console.WriteLine("\nPOSTORDER TRAVERSAL\n");
            bst1.PostOrderTraversal();

            Console.WriteLine("\nHEIGHT OF THE TREE\n");
            System.Console.WriteLine(bst1.Height());
            System.Console.WriteLine("\nTHE MINIMUM VALUE\n");
            System.Console.WriteLine(bst1.Min());
            System.Console.WriteLine("\nTHE MAXIMUM VALUE\n");
            System.Console.WriteLine(bst1.Max());
            System.Console.WriteLine("\nIS EQUAL\n");
            System.Console.WriteLine(bst1.Equals(bst));
            System.Console.WriteLine("\nVALIDATE BST\n");
            System.Console.WriteLine(bst1.IsBinarySearchTree());

            System.Console.WriteLine("\nNODES AT DISTANCE D\n");
            bst1.GetNodesAtDistance(3);

            System.Console.WriteLine("\nBREADTH FIRST TRAVERSAL\n");
            bst1.BreadthFirstTraversal();

            Console.WriteLine("\nCOUNT\n");
            Console.WriteLine(bst1.GetCount());

            Console.ReadLine();
        }
    }
}
