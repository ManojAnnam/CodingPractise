using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCharactersForPalindromeMaking
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string res = buildPalindrome(input);
            Console.WriteLine();
        }

        private static string buildPalindrome(string input)
        {
            bool isPallindrome = true;
            int i = 0;
            string s = string.Empty;
            while(isPallindrome)
            {
                s = input[i] + s;

                isPallindrome = checkPallindrome(input+s);
                if (isPallindrome)
                {
                    
                    break;
                }
                i++;
                isPallindrome = true;

            }
           
            return input+s;
        }

        private static bool checkPallindrome(string input)
        {
            return input.SequenceEqual(input.Reverse());
        }
    }
}
