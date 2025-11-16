using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            GeneratePermutations(input.ToCharArray(), 0, input.Length - 1);
        }

        static void GeneratePermutations(char[] arr, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(new string(arr));
                return;
            }

            for (int i = l; i <= r; i++)
            {
                Swap(ref arr[l], ref arr[i]);
                GeneratePermutations(arr, l + 1, r);
                Swap(ref arr[l], ref arr[i]); 
            }
        }

        static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            char temp = a;
            a = b;
            b = temp;
        }
    }
}
