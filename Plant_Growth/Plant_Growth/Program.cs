using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Growth
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 10;
            int c = 2;
            float f = (a - b) /(float) (b - c);
            double d = Math.Ceiling(f + 1);
            int res = Convert.ToInt32(d);
            Console.WriteLine();
        }
    }
}
