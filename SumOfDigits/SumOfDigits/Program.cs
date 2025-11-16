using System;

namespace SumOfDigits
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

            int sum = SumDigits(n);
            Console.WriteLine(sum);
        }

        static int SumDigits(int num)
        {
            num = Math.Abs(num); 
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
