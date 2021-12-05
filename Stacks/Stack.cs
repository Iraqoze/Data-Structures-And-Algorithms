using System;
namespace Stacks
{
    class Stack<T>
    {
        private T[] Values;
        private T val;
        int Count;
        public Stack(int Length)
        {
            Values = new T[Length];
        }


        //Push
        public void Push(T value)
        {
            if (Count == Values.Length)
                throw new Exception("Stack Overflow");
            Values[Count++] = value;

        }
        //Peek
        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Empty Stack");
            return Values[Count - 1];
        }

        //Pop
        public void Pop()
        {
            if (IsEmpty())
                throw new Exception("Empty Stack");
            Values[Count - 1] = val;
            Count--;
        }
        //Is Empty
        private bool IsEmpty() => Count == 0;

        //Count
        public int GetCount() => Count;

    }

}