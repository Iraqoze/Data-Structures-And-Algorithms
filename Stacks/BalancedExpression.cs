using System;
using System.Collections.Generic;

namespace Staks
{
    public class BalancedExpressions
    {
        private static List<char> leftBrackets = new List<char>(){
            '(','{','[','<'
        };
        private static List<char> rightBrackets = new List<char>(){
            ')','}',']','>'
        };

        public static bool CheckIfExpressionIsBalanced(string expression)
        {
            if (expression.Length == 0)
                throw new Exception("Empty String");

            Stack<char> brackets = new Stack<char>();

            foreach (char c in expression.ToCharArray())
            {
                if (isLeftBracket(c))
                    brackets.Push(c);
                else if (isRightBracket(c))
                {
                    int index = rightBrackets.IndexOf(c);
                    char ch = leftBrackets[index];

                    if (ch == brackets.Peek())
                    {
                        brackets.Pop();
                    }
                    else
                        return false;
                }
            }
            if (brackets.Count == 0)
                return true;

            return false;
        }

        private static bool isLeftBracket(char c)
        {
            if (leftBrackets.Contains(c))
                return true;
            return false;
        }
        private static bool isRightBracket(char c)
        {
            if (rightBrackets.Contains(c))
                return true;
            return false;
        }
    }

}