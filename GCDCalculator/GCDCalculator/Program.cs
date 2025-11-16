using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integers separated by space: ");
            string[] inputs = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (inputs.Length != 2 || !int.TryParse(inputs[0], out int a) || !int.TryParse(inputs[1], out int b))
            {
                Console.WriteLine("Invalid input. Please enter two integers.");
                return;
            }

            int gcd = CalculateGCD(a, b);
            Console.WriteLine(gcd);
        }

        static int CalculateGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
