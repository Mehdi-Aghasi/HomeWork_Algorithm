using System;

namespace ReverseIntegerSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            bool valid = int.TryParse(Console.ReadLine(), out int n);

            while (!valid)
            {
                Console.Write("Invalid input. Enter an integer: ");
                valid = int.TryParse(Console.ReadLine(), out n);
            }

            int reversed = ReverseNumber(n);
            Console.WriteLine(reversed);
        }

        static int ReverseNumber(int num)
        {
            int sign = num < 0 ? -1 : 1;
            num = Math.Abs(num);
            int result = 0;

            while (num > 0)
            {
                int digit = num % 10;
                result = result * 10 + digit;
                num /= 10;
            }

            return result * sign;
        }
    }
}
