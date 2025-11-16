using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProductOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integers (space separated): ");
            int[] arr = Array.ConvertAll(
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (arr.Length < 3)
            {
                Console.WriteLine("Array must have at least three elements.");
                return;
            }

            long maxProduct = MaxProductOfThree(arr);
            Console.WriteLine(maxProduct);
        }

        static long MaxProductOfThree(int[] arr)
        {
            Array.Sort(arr); 

            int n = arr.Length;

 
            long prod1 = (long)arr[n - 1] * arr[n - 2] * arr[n - 3];
            long prod2 = (long)arr[0] * arr[1] * arr[n - 1];

            return Math.Max(prod1, prod2);
        }
    }
}
