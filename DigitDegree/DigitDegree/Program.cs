using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(digitDegree(n));
            Console.ReadLine();
        }

        private static int digitDegree(int n)
        {
            int temp = n;
            int count = 0;
            string s = temp.ToString();
            if(s.Length == 1)
            {
                return 0;
            }
            while(true)
            {
               n = sumOfDigits(n);
                count++;
                temp = n;
               if ((temp.ToString()).Length == 1)
               {
                    return count;
               }
            }
           
            
        }

        private static int sumOfDigits(int k)
        {
            int r = 0;
            while (k > 0)
            {
                r += k % 10;
                k = k / 10;
            }
            return r;
        }
    }
}
