using System;
namespace Queues
{
    public class PriorityQueue
    {
        private int[] Items;
        int Count;
        public PriorityQueue(int lenght)
        {
            Items = new int[lenght];
        }
        //Add
        public void Add(int item)
        {
            if (IsFull())
                throw new Exception("Full Queue Exception");

            int i = ShiftItems(item);
            Items[i + 1] = item;
            Count++;
        }
        //Peek
        public int Peek()
        {
            if (IsEmpty())
                throw new Exception("Empty Queue Exception");
            return Items[0];
        }
        //Remove
        public void Remove()
        {
            if (IsEmpty())
                throw new Exception("Empty Queue Exception");
            for (int i = 0; i < Count - 1; i++)
                Items[i] = Items[i + 1];
            Count--;
            Items[Count] = 0;
        }

        //Shift
        private int ShiftItems(int item)
        {
            int i;
            for (i = Count - 1; i >= 0; i--)
            {

                if (item < Items[i])
                    Items[i + 1] = Items[i];
                else
                    break;

            }
            return i;
        }
        //Is Empty
        private bool IsEmpty() => Count == 0;

        //Is Full
        private bool IsFull() => Count == Items.Length;


    }

}