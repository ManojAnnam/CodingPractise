using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEmailDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = Console.ReadLine();
            string result = findEmailDomain(address);
        }

        private static string findEmailDomain(string address)
        {
            int index = address.LastIndexOf('@');
            return address.Substring(index + 1);
            
        }
    }
}
