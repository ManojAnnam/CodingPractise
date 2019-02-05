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
            Regex onlyNumbers = new Regex("^[0-9]+$");
            Regex onlyNonNumbers = new Regex("[\\D]");
            Regex onlyAlphabet = new Regex("^[a-zA-Z]+$");
            List<string> chunks = new List<string>();
            string temp = string.Empty;
            if (onlyNumbers.IsMatch(inputString))
            {
               // return inputString;
            }
            else if (onlyAlphabet.IsMatch(inputString))
            {
                 return null;
            }
            else
            {
                for(int i=0;i<inputString.Length;i++)
                {
                    while(i < inputString.Length && onlyNumbers.IsMatch(inputString[i].ToString()))
                    {
                        temp += inputString[i];
                        i++;
                    }
                    if(temp!=string.Empty)
                    {
                        chunks.Add(temp);
                        temp = string.Empty;
                    }
                    while (i < inputString.Length && onlyNonNumbers.IsMatch(inputString[i].ToString()))
                    {
                        temp += inputString[i];
                        i++;
                    }
                    if (temp != string.Empty)
                    {
                        chunks.Add(temp);
                        temp = string.Empty;
                    }
                    i--;
                }
            }
            return null;

        }
    }
}
