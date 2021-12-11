using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {

            CharacterFinder characterFinder = new CharacterFinder();
            // System.Console.WriteLine(characterFinder.GetFirstNonRepeatingChar("A green Apples"));
            //System.Console.WriteLine(characterFinder.GetFirstRepeatingChar("Green Apples"));

            HashTable hash = new HashTable(5);
            hash.Add(111, "Lio");
            hash.Add(12435, "Ira");
            hash.Add(123, "Papi");
            hash.Add(12435, "Dear Boy");
            System.Console.WriteLine(hash.Get(123));

            hash.Remove(123);
            Console.ReadLine();
        }
    }
}
