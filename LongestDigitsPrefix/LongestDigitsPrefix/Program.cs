using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LongestDigitsPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "123";
            longestDigitsPrefix(inputString);
            Console.ReadLine();
        }

        private static string longestDigitsPrefix(string inputString)
        {
            Regex onlyNumbers = new Regex("^[0-9]+$");
            Regex onlyNonNumbers = new Regex("[^0-9]");
            bool containsOnlyNonNumbers = onlyNonNumbers.IsMatch(inputString);
            bool containsOnlyNumbers = onlyNumbers.IsMatch(inputString);
            return null;

        }
    }
}
