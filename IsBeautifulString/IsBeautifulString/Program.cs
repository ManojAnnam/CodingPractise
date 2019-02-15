using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBeautifulString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            bool result = isBeautifulString(inputString);
        }

        private static bool isBeautifulString(string inputString)
        {
            string res = String.Concat(inputString.OrderBy(c => c));
            char[] dist = res.Distinct().ToArray();
            bool condition = true;
            if (dist[0] != 'a')
            {
                condition = false;
            }
            else
            {
                for (int i = 0; i < dist.Length - 1; i++)
                {
                    if (dist[i + 1] - dist[i] > 1)
                    {
                        condition = false;
                    }
                }
            }
            if (condition)
            {
                int max = Int32.MaxValue;
                foreach (char c in dist)
                {
                    int temp = res.Where(ch => ch == c).Count();
                    if (temp > max)
                    {
                        return false;
                    }
                    else
                    {
                        max = temp;
                    }
                }
                return true;
            }
            return false;
            
        }
    }
}
