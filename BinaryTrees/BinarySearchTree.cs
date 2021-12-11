using System;
namespace BinaryTrees
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int Value;
            public Node LeftChild;
            public Node RightChild;
            public Node(int value)
            {
                Value = value;
            }

        }

        public Node Root;
        int Count;


        //Insert

        public void Insert(int value)
        {
            var node = new Node(value);
            if (Root == null)
            {
                Root = node;
                Count++;
                return;
            }

            var current = Root;
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                        break;
                    }
                    current = current.LeftChild;

                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                        break;
                    }
                    current = current.RightChild;
                }

            }
            Count++;


        }

        //Find
        public bool Find(int value)
        {
            if (Root == null)
                return false;
            var current = Root;
            while (current != null)
            {

                if (value < current.Value)
                    current = current.LeftChild;
                else if (value > current.Value)
                    current = current.RightChild;
                else
                    return true;
            }
            return false;

        }

        //PRE-Order Traversal: ROOT, LEFT, RIGHT 
        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }
        private void PreOrderTraversal(Node root)
        {
            if (root == null)
                return;

            //Print Root
            Console.WriteLine(root.Value);

            PreOrderTraversal(root.LeftChild);
            PreOrderTraversal(root.RightChild);

        }
        //IN-Order Traversal: LEFT, ROOT, RIGHT 
        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
        }
        private void InOrderTraversal(Node root)
        {
            if (root == null)
                return;
            InOrderTraversal(root.LeftChild);
            Console.WriteLine(root.Value);
            InOrderTraversal(root.RightChild);

        }

        //POST-Order Traversal: LEFT, RIGHT, ROOT
        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }
        private void PostOrderTraversal(Node root)
        {
            if (root == null)
                return;

            PostOrderTraversal(root.LeftChild);
            PostOrderTraversal(root.RightChild);

            //Print Root
            Console.WriteLine(root.Value);

        }

        //Height of the Tree
        public int Height()
        {
            if (Root == null)
                return -1;
            return Height(Root);
        }
        private int Height(Node root)
        {
            if (root == null)
                return -1;
            if (IsLeaf(root))
                return 0;

            return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
        }



        //Minimum Value in The Tree
        public int Min() => Min(Root);
        private int Min(Node root)
        {
            if (root == null)
                throw new Exception("Empty Tree Exception");
            var current = root;
            var last = current;
            while (current != null)
            {
                last = current;
                current = current.LeftChild;
            }
            return last.Value;
        }

        //Maximum Value in The Tree
        public int Max() => Max(Root);
        private int Max(Node root)
        {
            if (root == null)
                throw new Exception("Empty Tree Exception");
            var current = root;
            var last = current;
            while (current != null)
            {
                last = current;
                current = current.RightChild;
            }
            return last.Value;
        }

        //Is Leaf Node
        private bool IsLeaf(Node node) => node.LeftChild == null && node.RightChild == null;
        //Equals
        public bool Equals(BinarySearchTree bst)
        {
            if (bst == null)
                return false;
            return Equals(Root, bst.Root);
        }
        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null)
                return true;
            if (first != null && second != null)
                return first.Value == second.Value
                 && Equals(first.LeftChild, second.LeftChild)
                 && Equals(first.RightChild, second.RightChild);

            return false;

        }

        //Validate Binary Search Tree
        public bool IsBinarySearchTree() => IsBinarySearchTree(Root, int.MinValue, int.MaxValue);
        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
                return true;
            if (root.Value < min || root.Value > max)
                return false;
            return IsBinarySearchTree(root.LeftChild, min, root.Value - 1)
            && IsBinarySearchTree(root.RightChild, root.Value + 1, max);

        }

        //Nodes At K Distance from the Root Node
        public void GetNodesAtDistance(int distance)
        {
            if (Math.Abs(distance) > Height())
                throw new Exception("Distance Greater Than Height Exception");
            GetNodesAtDistance(Root, Math.Abs(distance));
        }
        private void GetNodesAtDistance(Node root, int distance)
        {
            if (root == null)
                return;

            if (distance == 0)
            {
                Console.WriteLine(root.Value);
                return;
            }
            GetNodesAtDistance(root.LeftChild, distance - 1);
            GetNodesAtDistance(root.RightChild, distance - 1);
        }

        //LEVEL ORDER TRAVERSAL/BREADTH FIRST TRAVERSAL
        public void BreadthFirstTraversal()
        {
            BreadthFirstTraversal(Root);
        }
        private void BreadthFirstTraversal(Node root)
        {
            if (root == null)
                return;
            for (int i = 0; i <= Height(); i++)
                GetNodesAtDistance(i);

        }

        //COUNT
        public int GetCount() => Count;
    }

}