using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Insert(30);
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(20);
            tree.Insert(15);
            tree.Insert(26);
            tree.Insert(1);
            tree.Insert(8);
            tree.Insert(50);
            tree.Insert(45);
            tree.Insert(60);
            tree.Insert(55);
            tree.Insert(70);

            BinarySearchTree bst = new BinarySearchTree();

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
            tree.PreOrderTraversal();
            Console.WriteLine("\nINORDER TRAVERSAL\n");
            tree.InOrderTraversal();
            Console.WriteLine("\nPOSTORDER TRAVERSAL\n");
            tree.PostOrderTraversal();

            Console.WriteLine("\nHEIGHT OF THE TREE\n");
            System.Console.WriteLine(tree.Height());
            System.Console.WriteLine("\nTHE MINIMUM VALUE\n");
            System.Console.WriteLine(tree.Min());
            System.Console.WriteLine("\nTHE MAXIMUM VALUE\n");
            System.Console.WriteLine(tree.Max());
            //System.Console.WriteLine("\nIS EQUAL\n");
            // System.Console.WriteLine(bst1.Equals(bst));
            System.Console.WriteLine("\nVALIDATE BST\n");
            System.Console.WriteLine(tree.IsBinarySearchTree());

            System.Console.WriteLine("\nNODES AT DISTANCE D\n");
            tree.GetNodesAtDistance(3);

            System.Console.WriteLine("\nBREADTH FIRST TRAVERSAL\n");
            tree.BreadthFirstTraversal();

            Console.WriteLine("\nCOUNT\n");
            Console.WriteLine(tree.GetCount());

            Console.WriteLine("\nLEAVES COUNT\n");
            Console.WriteLine(tree.GetLeavesCount());

            Console.WriteLine("\nMAX VALUE USING RECURSION\n");
            Console.WriteLine(bst.MaxValue());
            Console.WriteLine("\nMIN VALUE USING RECURSION\n");
            Console.WriteLine(bst.MinValue());
            Console.WriteLine("\nCONTAINS VALUE USING RECURSION\n");
            Console.WriteLine(bst.Contains(100));




            Console.ReadLine();
        }
    }
}
