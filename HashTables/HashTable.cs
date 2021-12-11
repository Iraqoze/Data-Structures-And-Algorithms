using System;
using System.Collections.Generic;

namespace HashTables
{
    public class HashTable
    {
        private class Entry
        {
            public int Key;
            public string Value;
            public Entry(int key, string value)
            {
                Key = key;
                Value = value;
            }
        }

        private LinkedList<Entry>[] Entries;
        public HashTable(int size)
        {
            Entries = new LinkedList<Entry>[Math.Abs(size)];
        }

        //ADD
        public void Add(int key, string value)
        {
            var index = Hash(Math.Abs(key));
            if (Entries[index] == null)
            {
                Entries[index] = new LinkedList<Entry>();
                Entries[index].AddLast(new Entry(key, value));
                return;
            }

            var bucket = Entries[index];
            foreach (var entry in bucket)
            {
                if (entry.Key == key)
                    entry.Value = value;
            }
        }

        //HASH
        private int Hash(int key) => key % Entries.Length;

        //GET
        public string Get(int key)
        {

            int index = Hash(Math.Abs(key));
            if (Entries[index] == null)
                throw new Exception("No Such Entry");

            var bucket = Entries[index];

            foreach (var entry in bucket)
            {
                if (entry.Key == key)
                    return entry.Value;
            }
            return null;
        }

        //REMOVE
        public void Remove(int key)
        {
            var index = Hash(Math.Abs(key));
            if (Entries[index] == null)
                throw new Exception("Null Entry Exception");

            var bucket = Entries[index];

            foreach (var entry in bucket)
            {
                if (entry.Key == key)
                    bucket.Remove(entry);
                return;
            }
            throw new Exception("No Such Entry Exception");
        }
    }
}