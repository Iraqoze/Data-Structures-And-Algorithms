using System;
using Staks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //String rev = ReverseString.ReverseExpression("ABCDE");
            //Console.WriteLine(rev);

            // System.Console.WriteLine(BalancedExpressions.CheckIfExpressionIsBalanced("()()<>[]{{}}"));
            // Console.WriteLine(BalancedExpressions.CheckIfExpressionIsBalanced("<Lio}"));
            // Console.ReadLine();

            Stack<String> stackClass = new Stack<String>(5);
            stackClass.Push("ONE");
            stackClass.Push("TWO");
            stackClass.Push("THREE");
            stackClass.Push("FOUR");
            stackClass.Push("FIVE");
            Console.WriteLine(stackClass.Peek());
            stackClass.Pop();
            Console.ReadLine();
        }
    }
}
