using System;
namespace AVLTree
{
    public class AVLTree
    {
        private class AVLNode
        {
            public int Value;
            public int Height;
            public AVLNode LeftChild;
            public AVLNode RightChild;
            public AVLNode(int value)
            {
                Value = value;
            }

        }

        private AVLNode Root;

        //INSERT
        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }
        private AVLNode Insert(AVLNode root, int value)
        {
            if (root == null)
                return new AVLNode(value);
            if (value < root.Value)
                root.LeftChild = Insert(root.LeftChild, value);
            else
                root.RightChild = Insert(root.RightChild, value);

            root.Height = 1 + Math.Max(
                GetNodeHeight(root.LeftChild),
                GetNodeHeight(root.RightChild)
                );

            return Balance(root);

        }

        //BALANCE TREE
        private AVLNode Balance(AVLNode root)
        {
            if (IsLeftHeavy(root))
            {
                if (BalanceFactor(root.LeftChild) < 0)
                    root.LeftChild = RotateLeft(root.LeftChild);
                return RotateRight(root);
            }
            if (IsRightHeavy(root))
            {
                if (BalanceFactor(root.RightChild) > 0)
                    root.RightChild = RotateRight(root.RightChild);
                return RotateLeft(root);

            }
            SetHeight(root);
            return root;
        }

        //HEIGHT OF A NODE
        private int GetNodeHeight(AVLNode node)
        {
            return (node == null) ? -1 : node.Height;
        }

        //BALANCE FACTOR
        private int BalanceFactor(AVLNode root)
        {
            if (root == null)
                return 0;
            return GetNodeHeight(root.LeftChild) - GetNodeHeight(root.RightChild);
        }

        //IS LEFT HEAVY
        private bool IsLeftHeavy(AVLNode node) => BalanceFactor(node) > 1;
        //IS RIGHT HEAVY
        private bool IsRightHeavy(AVLNode node) => BalanceFactor(node) < -1;

        //ROTATE LEFT
        private AVLNode RotateLeft(AVLNode node)
        {

            var newRoot = node.RightChild;
            node.RightChild = newRoot.LeftChild;
            newRoot.LeftChild = node;
            SetHeight(node);
            SetHeight(newRoot);
            return newRoot;
        }
        //ROTATE RIGHT
        private AVLNode RotateRight(AVLNode node)
        {

            var newRoot = node.LeftChild;
            node.LeftChild = newRoot.RightChild;
            newRoot.RightChild = node;
            SetHeight(node);
            SetHeight(newRoot);
            return newRoot;
        }

        //HEIGHT OF NODE
        private void SetHeight(AVLNode root)
        {
            root.Height = 1 + Math.Max(GetNodeHeight(root.LeftChild), GetNodeHeight(root.RightChild));
        }

    }
}

