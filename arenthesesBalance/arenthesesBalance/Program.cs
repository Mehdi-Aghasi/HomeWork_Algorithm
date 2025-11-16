using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arenthesesBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string containing (), {}, []: ");
            string input = Console.ReadLine();

            bool balanced = IsBalanced(input);
            Console.WriteLine(balanced);
        }

        static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char open = stack.Pop();
                    if (!Matches(open, c))
                        return false;
                }
            }

            return stack.Count == 0;
        }

        static bool Matches(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}
