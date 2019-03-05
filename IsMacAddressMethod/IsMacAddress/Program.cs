using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMacAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MacAddressValidatorClass macAddressValidatorClass = new MacAddressValidatorClass();
            bool isValid = macAddressValidatorClass.IsMacAddress(input);
            Console.ReadLine();
        }
    }
}
