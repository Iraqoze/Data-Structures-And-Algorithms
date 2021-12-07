using System;
using System.Collections.Generic;

namespace HashTables
{
    public class CharacterFinder
    {

        public char GetFirstNonRepeatingChar(string str)
        {

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (char c in str.ToCharArray())
            {
                int count = dictionary.ContainsKey(c) ? dictionary[c] : 0;

                dictionary[c] = count + 1;
            }

            foreach (char c in str.ToCharArray())
            {
                if (dictionary.GetValueOrDefault(c) == 1)
                    return c;
            }
            return char.MinValue;

        }
        public char GetFirstRepeatingChar(string str)
        {

            HashSet<char> set = new HashSet<char>();
            foreach (char c in str.ToCharArray())
            {
                if (set.Contains(c))
                    return c;
                set.Add(c);
            }
            return Char.MinValue;

        }

    }

}