using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integers (space separated): ");
            int[] arr = Array.ConvertAll(
                Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse
            );

            bool hasDuplicate = HasDuplicate(arr);
            Console.WriteLine(hasDuplicate);
        }

        static bool HasDuplicate(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                if (seen.Contains(num))
                    return true;
                seen.Add(num);
            }

            return false;
        }
    }
}
