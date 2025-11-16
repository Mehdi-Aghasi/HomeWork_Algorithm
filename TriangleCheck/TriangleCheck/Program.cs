using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter positive integers (space separated): ");
            int[] arr = Array.ConvertAll(
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            bool canForm = CanFormTriangle(arr);
            Console.WriteLine(canForm);
        }

        static bool CanFormTriangle(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            Array.Sort(arr); 

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if ((long)arr[i] + arr[i + 1] > arr[i + 2]) 
                    return true;
            }

            return false;
        }
    }
}
