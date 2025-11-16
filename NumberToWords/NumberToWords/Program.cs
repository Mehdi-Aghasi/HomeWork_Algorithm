using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1 - 9999): ");
            bool valid = int.TryParse(Console.ReadLine(), out int n);

            while (!valid || n < 1 || n > 9999)
            {
                Console.Write("Invalid input. Enter a number between 1 and 9999: ");
                valid = int.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine("Result: " + NumberToWords(n));
        }

        static string NumberToWords(int n)
        {
            if (n == 0) return "Zero";

            string result = "";

            if (n >= 1000)
            {
                result += OneDigit(n / 1000) + " Thousand ";
                n %= 1000;
            }

            if (n >= 100)
            {
                result += OneDigit(n / 100) + " Hundred ";
                n %= 100;
            }

            if (n >= 20)
            {
                result += Tens(n / 10) + " ";
                n %= 10;
            }
            else if (n >= 10)
            {
                result += Teens(n) + " ";
                n = 0;
            }

            if (n > 0)
                result += OneDigit(n) + " ";

            return result.Trim();
        }

        static string OneDigit(int n)
        {
            string[] arr = { "", "One", "Two", "Three", "Four", "Five",
                "Six", "Seven", "Eight", "Nine" };
            return arr[n];
        }

        static string Teens(int n)
        {
            string[] arr = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            return arr[n - 10];
        }

        static string Tens(int n)
        {
            string[] arr = { "", "", "Twenty", "Thirty", "Forty", "Fifty",
                "Sixty", "Seventy", "Eighty", "Ninety" };
            return arr[n];

        }
    }
}
