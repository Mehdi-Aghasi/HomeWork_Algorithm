using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            bool valid = long.TryParse(Console.ReadLine(), out long n); 

            while (!valid)
            {
                Console.Write("Invalid input. Enter a valid integer: ");
                valid = long.TryParse(Console.ReadLine(), out n);
            }

            int reversed = ReverseNumber(n);
            Console.WriteLine(reversed);
        }

        static int ReverseNumber(long num) 
        {
            long result = 0;
            int sign = num < 0 ? -1 : 1;
            num = Math.Abs(num);

            while (num > 0)
            {
                int digit = (int)(num % 10);
                result = result * 10 + digit;

                if (result > int.MaxValue)
                    return 0; 
                num /= 10;
            }

            return (int)(result * sign);
        }
    }
}
