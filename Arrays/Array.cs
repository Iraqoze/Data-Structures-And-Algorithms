using System;

namespace Arrays
{
    class Array
    {
        private int[] array;
        private int Count;

        public Array(int lenght)
        {
            array = new int[lenght];
        }

        //Inserting values into the array
        public void Insert(int value)
        {
            if (!IsArrayFull())
                array[Count++] = value;
            else
                throw new Exception("The Array Is Full");
        }

        //Get value at a given Index
        public int ElementAt(int index)
        {
            if (IsValidIndex(index))
            {
                return array[index];
            }
            throw new Exception("Invalid Index");

        }

        //Remove At
        public void RemoveAt(int index)
        {
            if (!IsValidIndex(index))
                throw new Exception("Invalid Index");

            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Count--;
            array[Count] = 0;
        }

        //Index Of

        public int IndexOf(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }
        //Checking if the array is full
        private bool IsArrayFull()
        {
            if (Count == array.Length)
                return true;
            return false;
        }

        //Validate index
        private bool IsValidIndex(int index)
        {
            if (index >= 0 && index <= array.Length - 1)
                return true;
            return false;
        }

        //Printing the array
        public void PrintArray()
        {
            for (int i = 0; i < Count; i++)
                Console.WriteLine(array[i]);
        }

    }
}
