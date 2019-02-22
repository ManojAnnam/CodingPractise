using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IsDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            Regex pattern = new Regex(@"^\d$");
            bool result = pattern.IsMatch(input);
            Console.WriteLine();
        }
    }
}
