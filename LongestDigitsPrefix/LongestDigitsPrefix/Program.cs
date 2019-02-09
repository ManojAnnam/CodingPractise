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

            string inputString = "123abddef123as12345";
            string result = longestDigitsPrefix(inputString);
            Console.ReadLine();
        }

        private static string longestDigitsPrefix(string inputString)
        {
            string result = string.Empty;
            for (int i = 0; i< inputString.Length;i++ )
            {
                if(Char.IsDigit(inputString[i]))
                {
                    result += inputString[i];
                }
                else
                {
                    return result;
                }
            }
            return result;
        }
    }
}
