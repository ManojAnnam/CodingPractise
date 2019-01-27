using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxConsecutiveSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 8 };
            int k = 2;
            int j = maxSum(a,k);
            Console.WriteLine();
        }

        private static int maxSum(int[] inputArray, int k)
        {
            List<int> sumResults = new List<int>();
            for(int i=0; i<=(inputArray.Length-k);i++)
            {
                int temp = k,sum = 0;int addVariable = i;
                while(temp>0)
                {
                    sum += inputArray[addVariable];
                    temp--;
                    addVariable++;
                }
                sumResults.Add(sum);
            }
            return sumResults.Max();
        }
    }
}
