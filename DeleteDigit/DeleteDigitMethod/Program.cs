using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDigitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int result = DeleteDigit(input);
        }

        private static int DeleteDigit(int input)
        {
            string s = input.ToString();
            int[] ar = s.Select(c => Convert.ToInt32(c.ToString())).ToArray();

            return 0;
        }
    }
}
