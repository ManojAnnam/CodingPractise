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
            MaximumNumberFinder maximumNumberFinder = new MaximumNumberFinder(Convert.ToInt32(Console.ReadLine()));
            int result = maximumNumberFinder.DeleteDigit();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
