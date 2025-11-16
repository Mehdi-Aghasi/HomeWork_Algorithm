using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUniqueChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char? result = FirstNonRepeatingChar(input);


            if (result != null)
                Console.WriteLine("First non-repeating character: "+result);
            else
                Console.WriteLine("-1"); 
        }

        static char? FirstNonRepeatingChar(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            var counts = new Dictionary<char, int>();

            foreach (char c in str)
                counts[c] = counts.ContainsKey(c) ? counts[c] + 1 : 1;

            foreach (char c in str)
                if (counts[c] == 1)
                    return c;

            return null; 
        }
    }
}
