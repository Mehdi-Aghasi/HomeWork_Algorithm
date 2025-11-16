using System;

namespace CountDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            bool valid = int.TryParse(Console.ReadLine(), out int n);

            while (!valid || n <= 0)
            {
                Console.Write("Invalid input. Enter a positive integer: ");
                valid = int.TryParse(Console.ReadLine(), out n);
            }

            int digitCount = CountDigits(n);
            Console.WriteLine("count is : "+digitCount);
        }

        static int CountDigits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }
    }
}
