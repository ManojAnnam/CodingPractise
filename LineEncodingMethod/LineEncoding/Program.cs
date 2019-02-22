using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string res = LineEncoding(input);
            Console.WriteLine();
        }

        private static string LineEncoding(string input)
        {
            string output = string.Empty;
            int count;
            for(int i = 0;i<input.Length;i++)
            {
                char temp = input[i];
                count = 1;
                while((i+1)<input.Length && input[i+1]==temp)
                {
                    count++;
                    i++;
                }
                if(count>1)
                {
                    output += count.ToString() + temp.ToString();
                }
                else
                {
                    output += temp;
                }
            }
            return output;
        }
    }
}
