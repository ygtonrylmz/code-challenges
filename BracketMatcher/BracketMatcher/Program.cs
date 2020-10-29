using System;
using System.Collections;
using System.Linq;

namespace BracketMatcher
{
    //    Have the function BracketMatcher(str) take the str parameter being passed and return 1 if the brackets are correctly matched and each one is accounted for. Otherwise return 0. For example: if str is "(hello (world))", then the output should be 1, but if str is "((hello (world))" the the output should be 0 because the brackets do not correctly match up.Only "(" and ")" will be used as brackets.If str contains no brackets return 1.
    //Examples
    //Input: "(coder)(byte))"
    //Output: 0
    //Input: "(c(oder)) b(yte)"
    //Output: 1
    class Program
    {
        public static int BracketMatcher(string str)
        {

            if (!str.Contains('(') && !str.Contains(')'))
                return 1;
            // Build stack
            Stack stack = new Stack();
            foreach (var item in str)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    if (stack.Count == 0)
                        return 0;
                    else
                        stack.Pop();
                }
            }
            return stack.Count == 0 ? 1 : 0;

        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(BracketMatcher("(hello (world))"));
        }
    }
}
