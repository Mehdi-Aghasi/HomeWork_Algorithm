using System;

namespace HomeWork_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number: ");
            bool Valid = long.TryParse(Console.ReadLine(), out long n);

            while (!Valid || n < 0)
            {
                Console.Write("Invalid input. Please Enter a non-negative Number: ");
                Valid = long.TryParse(Console.ReadLine(), out n);

            }

            if (n == 0)
            {
                Console.Write("Number is not Zero");
            }

            long item1 = 0;
            long item2 = 1;
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.Write(item1 + " ");
            Console.ResetColor();

            for (long i = 1; i <= n; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(item2 + " ");
                long item3 = item1 + item2;
                item1 = item2;
                item2 = item3;
            }

            Console.ResetColor();
        }
    }
}
