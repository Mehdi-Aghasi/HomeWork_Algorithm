using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter integers separated by space: ");
            int[] arr = Array.ConvertAll(
                Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                int.Parse
            );


            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                    currentLength++;
                else
                    currentLength = 1;

                if (currentLength > maxLength)
                    maxLength = currentLength;
            }

            Console.WriteLine($"Length of longest increasing subarea: {maxLength}");
        }
    }
}
