using System;

namespace PrimeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            bool valid = int.TryParse(Console.ReadLine(), out int n);

            while (!valid || n <= 0)
            {
                Console.Write("Invalid input. Enter a positive integer: ");
                valid = int.TryParse(Console.ReadLine(), out n);
            }

            if (IsPrime(n))
                Console.WriteLine("عدد اول است");
            else
                Console.WriteLine("عدد اول نیست");
        }

        static bool IsPrime(int num)
        {
            if (num == 1)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;

            int limit = (int)Math.Sqrt(num);
            for (int i = 3; i <= limit; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}

