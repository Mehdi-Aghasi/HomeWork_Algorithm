using System;

namespace PalindromeNumber
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

            if (IsPalindrome(n))
                Console.WriteLine("عدد پالیندروم است");
            else
                Console.WriteLine("عدد پالیندروم نیست");
        }

        static bool IsPalindrome(int num)
        {
            if (num < 0)
                return false; 

            int original = num;
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            return original == reversed;
        }
    }
}
