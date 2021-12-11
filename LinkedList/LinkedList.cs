using System;
namespace LinkedList
{
    public class LinkedList
    {
        //Node Class
        private class Node
        {
            public int Value;
            public Node Next;
            public Node(int value)
            {
                Value = value;
            }

        }

        private Node First;
        private Node Last;
        public int Count;

        //Adding First
        public void AddFirst(int value)
        {
            var node = new Node(value);
            if (First == null)
                First = Last = node;
            else
            {
                node.Next = First;
                First = node;
            }
            Count++;
        }

        //Adding Last
        public void AddLast(int value)
        {
            var node = new Node(value);
            if (First == null)
                First = Last = node;
            else
            {
                Last.Next = node;
                Last = node;
            }
            Count++;
        }

        //Index Of
        public int IndexOf(int value)
        {

            var current = First;
            int index = 0;
            while (current != null)
            {
                if (current.Value == value)
                    return index;

                current = current.Next;
                index++;
            }
            return -1;
        }

        //Contains
        public bool Contains(int value)
        {
            if (IndexOf(value) == -1)
                return false;
            return true;
        }
        //Count
        public int GetCount() => Count;

        //Remove First
        public void RemoveFirst()
        {
            if (First == null)
                throw new Exception("Can't remove first on an Empty List");

            var second = First.Next;
            First = second;
            Count--;


        }
        //Remove Last
        public void RemoveLast()
        {

            if (First == null)
                throw new Exception("Can't remove first on an Empty List");

            var current = First;
            while (current != null)
            {
                if (current.Next == Last)
                    break;
                current = current.Next;
            }
            Last = current;
            Last.Next = null;
            Count--;

        }

        //Kth Element
        public int KthNode(int distance)
        {

            if (distance < 0 || distance > Count)
                throw new Exception("Invalid Distance");

            var current = First;
            var kthNode = First;
            for (int i = 0; i < distance; i++)
                current = current.Next;
            while (current != null)
            {
                current = current.Next;
                kthNode = kthNode.Next;
            }
            return kthNode.Value;
        }

        //ToArray
        public int[] ToArray()
        {
            int[] array = new int[Count];
            var current = First;
            for (int i = 0; i < Count; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }
            return array;
        }

        //Clear the List
        public void Clear()
        {
            First = Last = null;
            Count = 0;
        }

        //Reverse LinkedLis
        public void Reverse()
        {
            if (First == null)
                throw new Exception("Can't Reverse an empty list");

            var current = First;
            Node temp = null;
            while (current != null)
            {
                var next = current.Next;
                current.Next = temp;
                temp = current;
                current = next;
            }

            var f = First;
            First = Last;
            Last = f;
            Last.Next = null;
        }
    }


}
