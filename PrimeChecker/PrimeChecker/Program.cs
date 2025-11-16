using System;

namespace PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter positiveNumber: ");
            bool valid = int.TryParse(Console.ReadLine(), out int n);

            while (!valid || n < 0)
            {
                Console.Write("Invalid input. Enter a positive number: ");
                valid = int.TryParse(Console.ReadLine(),out n);

            }

            if (IsPrime(n))
            {
                Console.WriteLine($"{n} is Prime.");
            }
            else
            {
                Console.WriteLine($"{n} is Not Prime.");
            }
        }

        static bool IsPrime(int n)
        {
            if (n == 1) return false;     
            if (n == 2) return true;      
            if (n % 2 == 0) return false;  

            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2) 
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
