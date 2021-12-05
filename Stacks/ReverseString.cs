using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class ReverseString
    {
        public static string ReverseExpression(String expression)
        {
            if (expression.Length == 0)
                throw new Exception("Empty String");

            Stack<char> chars = new Stack<char>();
            foreach (char c in expression)
                chars.Push(c);

            StringBuilder reversed = new StringBuilder();
            foreach (char c in chars)
                reversed.Append(c);

            return reversed.ToString();

        }
    }

}