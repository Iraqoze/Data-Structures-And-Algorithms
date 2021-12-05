using System;
namespace Queues
{
    public class Queue
    {
        private int[] Items;
        private int Count;
        private int Rear;
        private int Front;

        public Queue(int lenght)
        {
            Items = new int[lenght];
        }

        //Enqueue
        public void Enqueue(int item)
        {
            if (IsFull())
                throw new Exception("Queue is Full");

            Items[Rear] = item;
            Rear = GetRear(Rear);
            Count++;
        }

        //Dequeue
        public int Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Empty Queue");

            var item = Items[Front];
            Items[Front] = 0;
            Front = GetFront(Front);
            Count--;
            return item;

        }

        //Peek
        public int Peek()
        {
            if (IsEmpty())
                throw new Exception("Empty Queue");
            return Items[Front];
        }
        //Is Empty
        public bool IsEmpty() => Count == 0;

        //Is Full
        public bool IsFull() => Count == Items.Length;

        //Get Rear Position
        private int GetRear(int rear) => (rear + 1) % Items.Length;
        //Get Front Position
        private int GetFront(int front) => (front + 1) % Items.Length;

    }

}