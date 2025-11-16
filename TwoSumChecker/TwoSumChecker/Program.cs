using System;
using System.Collections.Generic;

namespace TwoSumChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array elements (space separated): ");
            int[] arr = Array.ConvertAll(
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            Console.WriteLine("Enter target:");
            int target = int.Parse(Console.ReadLine());

            var seen = new HashSet<int>();

            foreach (var n in arr)
            {
                int need = target - n;

                if (seen.Contains(need))
                {
                    Console.WriteLine("YES");
                    Console.WriteLine($"{need} + {n} = {target}");
                    return;
                }

                seen.Add(n);
            }

            Console.WriteLine("NO");
        }
    }
}
